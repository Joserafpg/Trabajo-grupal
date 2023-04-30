using proveedores;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabajo_grupal
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        void RejuegoON()
        {
            btnguardar.Visible = false;
            btnchange.Visible = true;
            formpermiso.Visible = false;
        }

        void RejuegoOFF()
        {
            btnguardar.Visible = true;
            btnchange.Visible = false;
            formpermiso.Visible = true;
        }

        void Limpiar()
        {
            txtempleado.ResetText();
            txtusuario.Clear();
            txtcontraseña.Clear();
            chagregarmercancia.Checked = false;
            checonsultar.Checked = false;
            checkBox3.Checked = false;
            cheliminarmercancia.Checked = false;
            chagregarclientes.Checked = false;
            chmodificarclientes.Checked = false;
            cheliminarclientes.Checked = false;
            chconsultarclientes.Checked = false;
            chagregarfactura.Checked = false;
            chmodificarfacttura.Checked = false;
            chconsultarfactura.Checked = false;
            cheliminarfactura.Checked = false;
            agregaruser.Checked = false;
            consultaruser.Checked = false;
            modificaruser.Checked = false;
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            formpermiso.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPermisos frm = new FormPermisos();
            frm.Show();
        }

        /*Metodo ReleaseCapture*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
            RejuegoON();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.Show();
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtempleado.Text == "" || txtusuario.Text == "" || txtcontraseña.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos.");
            }
            else
            {
                RejuegoOFF();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtempleado.Text == "" || txtusuario.Text == "" || txtcontraseña.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos.");
            }
            else
            {
                RejuegoOFF();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            RejuegoON();
        }
    }
}
