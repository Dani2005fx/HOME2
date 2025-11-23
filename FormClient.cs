using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudEjemplo.Clases
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            //cargar los datos en la interfaz
            Clases.CClient objetoClientes = new Clases.CClient();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoClientes.mostrarClientes(dgvTotalClientes);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cree un boton para hacer la verificacion a la base de datos
            // llamar al método estático conexion() directamente
            MySqlConnection conexion = Clases.CConexion.conexion();

            try
            {
                conexion.Open();
                MessageBox.Show("Conexión establecida correctamente");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //cargar los datos en la interfaz
            Clases.CClient objetoClientes = new Clases.CClient();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoClientes.guardarClientes(txtNombre, txtApellido, txtmail, txtTelefono);
            objetoClientes.mostrarClientes(dgvTotalClientes);
            // Ejemplo de cómo llamar el método
            
        }

        private void dgvTotalUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
        }

        //El metodo seleccionar se ejecuta al hacer doble click en una de las celdas de usuarios 
        private void dgvTotalUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Este objeto sabe cómo manejar la información de usuarios
            Clases.CClient objetoUsuarios = new Clases.CClient();
            // Llama al método seleccionarclientes del objeto creado y Le pasa todos los parámetros necesarios a La tabla donde se hizo doble clic
            objetoUsuarios.seleccionarClientes(dgvTotalClientes, txtId, txtNombre, txtApellido, txtmail, txtTelefono);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //cargar los datos en la interfaz
            Clases.CClient objetoClientes = new Clases.CClient();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoClientes.modificarClientes(txtId, txtNombre, txtApellido, txtmail, txtTelefono);
            objetoClientes.mostrarClientes(dgvTotalClientes);
      
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //cargar los datos en la interfaz
            Clases.CClient objetoClientes = new Clases.CClient();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoClientes.eliminarClientes(txtId);
            objetoClientes.mostrarClientes(dgvTotalClientes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
