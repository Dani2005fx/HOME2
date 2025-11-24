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
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
            //cargar los datos en la interfaz
            Clases.CVentas objetoVentas = new Clases.CVentas();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoVentas.mostrarVentas(dgvTotalobjetoVentas);
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
            Clases.CVentas objetoVentas = new Clases.CVentas();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoVentas.guardarVentas(txtIdCliente, txtIdProducto, txtCantidad, txtPrecioUnit, txtTotal);
            objetoVentas.mostrarVentas(dgvTotalobjetoVentas);
            // Ejemplo de cómo llamar el método
            
        }

        private void dgvTotalUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
        }

        //El metodo seleccionar se ejecuta al hacer doble click en una de las celdas de productos 
        private void dgvTotalUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Este objeto sabe cómo manejar la información de usuarios
            Clases.CVentas objetoVentas = new Clases.CVentas();
            // Llama al método seleccionarclientes del objeto creado y Le pasa todos los parámetros necesarios a La tabla donde se hizo doble clic
            objetoVentas.seleccionarVentas(dgvTotalobjetoVentas, txtIdVenta, txtIdCliente, txtIdProducto, txtFecha_Venta, txtCantidad, txtPrecioUnit, txtTotal);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //cargar los datos en la interfaz
            Clases.CVentas objetoVentas = new Clases.CVentas();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoVentas.modificarVentas(txtIdVenta, txtIdCliente, txtIdProducto, txtCantidad, txtPrecioUnit, txtTotal);
            objetoVentas.mostrarVentas(dgvTotalobjetoVentas);
      
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //cargar los datos en la interfaz
            Clases.CVentas objetoVentas = new Clases.CVentas();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoVentas.eliminarVentas(txtIdVenta);
            objetoVentas.mostrarVentas(dgvTotalobjetoVentas);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProductoCat_SelectedIndexChanged(object sender, EventArgs e)
        {
                  
        }

        private void btnVerCategoria_Click(object sender, EventArgs e)
        {

            DocVentas llamar = new DocVentas();
            llamar.FormClosed += (s, args) => this.Show(); // Mostrar este form cuando se cierre el otro
            llamar.Show();
            this.Hide();
        }
    }
}
