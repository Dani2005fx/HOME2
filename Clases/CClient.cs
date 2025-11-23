using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudEjemplo.Clases
{
    internal class CClient
    {
        //crear un metodo pra mostrar los clientes
        public void mostrarClientes(DataGridView tablaClientes)
        {
            //el try catch servira para ver si hay errores
            try
            {
                //limpiar el DataSource del DataGridV para eliminar datos anteriores
                tablaClientes.DataSource = null;
                //se crea un adaptador MySQL para ejecutar la consulta 
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from Clientes;", CConexion.conexion());
                //DataTable servira para almacenar los resultados de la consulta
                DataTable dt = new DataTable();
                //llena el DataTable con los datos que se  obtenidos de la consulta
                adapter.Fill(dt);
                tablaClientes.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostaron los datos de la base de datos, error:" + ex.ToString());
            }
        }

        //crear un metodo pra guardar los clientes 
        public void guardarClientes(TextBox nombre, TextBox apellido, TextBox mail, TextBox telefono)
        {
            //el try catch servira para ver si hay errores
            try
            {
                //comando sql para insertar datos
                string query = "INSERT INTO Clientes (Nombre_Cliente,Apellido_Cliente,Correo,Telefono)" +
                    "VALUES ('" + nombre.Text + "','" + apellido.Text + "','" + mail.Text + "','" + telefono.Text + "');";

                MySqlConnection conexion = CConexion.conexion();
                conexion.Open();
                // Ejecuta el comando en la base de datos
                MySqlCommand mycomand = new MySqlCommand(query, conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();
                MessageBox.Show("Se guardaron los registros");
                //muestra el recorrido del DataGridV de la tabla
                while (reader.Read())
                {

                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar" + ex.ToString());
            }
        }

        //crear un metodo selecionar
        //método tomara los datos de una fila seleccionada en una tabla 
        public void seleccionarClientes(DataGridView tablaClientes, TextBox id, TextBox nombre, TextBox apellido, TextBox mail, TextBox telefono)
        {
            //el try catch servira para ver si hay errores
            try
            {
                // Toma el valor de la celda 0 (primera columna) de la fila seleccionada y lo muestra en la caja de texto del ID
                id.Text = tablaClientes.CurrentRow.Cells[0].Value.ToString();
                //y los mismo con las siguientes
                nombre.Text = tablaClientes.CurrentRow.Cells[1].Value.ToString();
                apellido.Text = tablaClientes.CurrentRow.Cells[2].Value.ToString();
                mail.Text = tablaClientes.CurrentRow.Cells[3].Value.ToString();
                telefono.Text = tablaClientes.CurrentRow.Cells[4].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar" + ex.ToString());
            }
        }

        //crear un metodo pra modificar los clientes 
        public void modificarClientes(TextBox Id, TextBox nombre, TextBox apellido, TextBox mail, TextBox telefono)
        {
            //el try catch servira para ver si hay errores
            try
            {
                //comando sql para modificar datos
                string query = "Update  Clientes set Nombre_Cliente='"
                    + nombre.Text + "',Apellido_Cliente='" + apellido.Text + "',Correo='" + mail.Text + "',Telefono='" + telefono.Text + "' where Codigo_Cliente='" + Id.Text + "';";

                MySqlConnection conexion = CConexion.conexion();
                conexion.Open();
                // Ejecuta el comando en la base de datos
                MySqlCommand mycomand = new MySqlCommand(query, conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();
                MessageBox.Show("Se modifico correctamente los registros");
                //muestra el recorrido del DataGridV de la tabla
                while (reader.Read())
                {

                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar" + ex.ToString());
            }
        }

        //crear un metodo pra eliminar los Clientes 
        public void eliminarClientes(TextBox Id)
        {
            //el try catch servira para ver si hay errores
            try
            {
                //comando sql para modificar datos
                string query = "delete from  Clientes where Codigo_Cliente='" + Id.Text + "';";

                MySqlConnection conexion = CConexion.conexion();
                conexion.Open();
                // Ejecuta el comando en la base de datos
                MySqlCommand mycomand = new MySqlCommand(query, conexion);
                MySqlDataReader reader = mycomand.ExecuteReader();
                MessageBox.Show("Se elimino correctamente el usuario");
                //muestra el recorrido del DataGridV de la tabla
                while (reader.Read())
                {

                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar" + ex.ToString());
            }
        }
    }
}
