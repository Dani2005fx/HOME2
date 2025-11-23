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
    public partial class FormProct : Form
    {
        public FormProct()
        {
            InitializeComponent();
            //cargar los datos en la interfaz
            Clases.CProducts objetoClientes = new Clases.CProducts();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoClientes.mostrarProductos(dgvTotalProductos);
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
            Clases.CProducts objetoProductos = new Clases.CProducts();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoProductos.guardarProductos(txtNombreProducto, txtPrecio, txtExistenciasProducto, txtCodCategoria);
            objetoProductos.mostrarProductos(dgvTotalProductos);
            // Ejemplo de cómo llamar el método
            
        }

        private void dgvTotalUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
        }

        //El metodo seleccionar se ejecuta al hacer doble click en una de las celdas de productos 
        private void dgvTotalUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Este objeto sabe cómo manejar la información de usuarios
            Clases.CProducts objetoProductos = new Clases.CProducts();
            // Llama al método seleccionarclientes del objeto creado y Le pasa todos los parámetros necesarios a La tabla donde se hizo doble clic
            objetoProductos.seleccionarProductos(dgvTotalProductos, txtIdProducto, txtNombreProducto, txtPrecio, txtExistenciasProducto, txtCodCategoria);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //cargar los datos en la interfaz
            Clases.CProducts objetoProductos = new Clases.CProducts();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoProductos.modificarProductos(txtIdProducto, txtNombreProducto, txtPrecio, txtExistenciasProducto, txtCodCategoria);
            objetoProductos.mostrarProductos(dgvTotalProductos);
      
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //cargar los datos en la interfaz
            Clases.CProducts objetoProductos = new Clases.CProducts();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoProductos.eliminarProductos(txtIdProducto);
            objetoProductos.mostrarProductos(dgvTotalProductos);
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
            using (MySqlConnection connection = CConexion.conexion())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Categoria ORDER BY Codigo_Categoria";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        StringBuilder mensaje = new StringBuilder();
                        mensaje.AppendLine("INFORMACIÓN DE CATEGORÍAS:");
                        mensaje.AppendLine("===========================");
                        mensaje.AppendLine();

                        foreach (DataRow row in dt.Rows)
                        {
                            mensaje.AppendLine($"Código: {row["Codigo_Categoria"]}");
                            mensaje.AppendLine($"Nombre: {row["Nombre_Categoria"]}");
                            mensaje.AppendLine($"Descripción: {row["Descripcion"] ?? "Sin descripción"}");
                            mensaje.AppendLine("------------------------");
                        }

                        MessageBox.Show(mensaje.ToString(), "Datos de Categorías",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No hay categorías registradas en el sistema.",
                                      "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al acceder a la base de datos: {ex.Message}",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
