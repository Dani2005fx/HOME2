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
    public partial class DocVentas : Form
    {
        public DocVentas()
        {
            InitializeComponent();
            //cargar los datos en la interfaz
            Clases.CVentas objetoVentas = new Clases.CVentas();
            //llamar el metodo y incorporar el parametro DataGridView
            objetoVentas.mostrarVentas(dgvTotalVentas);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DocVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
