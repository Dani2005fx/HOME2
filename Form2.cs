using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudEjemplo
{
    public partial class Form2 : Form
    {
        private bool ventana = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void Salirbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizarbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximizarbtn_Click(object sender, EventArgs e)
        {
            ventana =! ventana;
            if (ventana)
            {
                this.MaximumSize = Screen.FromControl(this).WorkingArea.Size;

                this.WindowState = FormWindowState.Maximized;
                Maximizarbtn.Image = CrudEjemplo.Properties.Resources.res;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Maximizarbtn.Image = CrudEjemplo.Properties.Resources.maxi;
            }
            

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            Maximizarbtn.Image = CrudEjemplo.Properties.Resources.maxi;
        }
    }
}
