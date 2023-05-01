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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            chmodificarinventario.Checked = false;
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
            groupBox1.Text = "Agregar Nuevo Usuario";
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

            else if (txtusuario.Text.Length < 4 )
            {
                MessageBox.Show("El usuario debe tener al menos " + 4 + " caracteres.");
            }
            
            else if (txtcontraseña.Text.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos " + 4 + " caracteres.");
            }

            else
            {
                RejuegoOFF();
                Limpiar();
                groupBox1.Text = "Permisos";
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
            if (txtcontraseña.Text == txtcontraseña.Text)
                if (UsuariosDAL.CrearCuentas(txtempleado.Text, txtusuario.Text, txtcontraseña.Text, agregaruser.Checked, modificaruser.Checked, eliminaruser.Checked, consultaruser.Checked, agregarcobros.Checked, modificarcobros.Checked, consultarcobros.Checked, eliminarcobros.Checked, agregarpagos.Checked, modificarpagos.Checked, consultarpagos.Checked, eliminarpagos.Checked, chagregarfactura.Checked, chmodificarfacttura.Checked, chconsultarfactura.Checked, cheliminarfactura.Checked, chagregarclientes.Checked, chmodificarclientes.Checked, chconsultarclientes.Checked, cheliminarclientes.Checked, chagregarmercancia.Checked, chmodificarinventario.Checked, checonsultar.Checked, cheliminarmercancia.Checked) > 0)
                {
                    MessageBox.Show("Cuenta creada con exito");
                }
                else
                    MessageBox.Show("Nose pudo crear la cuenta");

            RejuegoON();
            groupBox1.Text = "Agregar Nuevo Usuario";
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 10; // El máximo de caracteres permitidos

            if (txtusuario.Text.Length > maxLength)
            {
                txtusuario.Text = txtusuario.Text.Substring(0, maxLength);
                txtusuario.SelectionStart = maxLength;
                txtusuario.SelectionLength = 0;
            }
        }

        private int _counter = 0;
        private bool _execute = true;
        private void chAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (_execute)
            {
                if (chAdmin.Checked)
                {
                    chagregarmercancia.Checked = true;
                    checonsultar.Checked = true;
                    chmodificarinventario.Checked = true;
                    cheliminarmercancia.Checked = true;

                    chagregarclientes.Checked = true;
                    chconsultarclientes.Checked = true;
                    chmodificarclientes.Checked = true;
                    cheliminarclientes.Checked = true;

                    chagregarfactura.Checked = true;
                    chconsultarfactura.Checked = true;
                    chmodificarfacttura.Checked = true;
                    cheliminarfactura.Checked = true;

                    agregaruser.Checked = true;
                    consultaruser.Checked = true;
                    eliminaruser.Checked = true;
                    modificaruser.Checked = true;
                }
                else
                {
                    chagregarmercancia.Checked = false;
                    checonsultar.Checked = false;
                    chmodificarinventario.Checked = false;
                    cheliminarmercancia.Checked = false;

                    chagregarclientes.Checked = false;
                    chconsultarclientes.Checked = false;
                    chmodificarclientes.Checked = false;
                    cheliminarclientes.Checked = false;

                    chagregarfactura.Checked = false;
                    chconsultarfactura.Checked = false;
                    chmodificarfacttura.Checked = false;
                    cheliminarfactura.Checked = false;

                    agregaruser.Checked = false;
                    consultaruser.Checked = false;
                    eliminaruser.Checked = false;
                    modificaruser.Checked = false;
                }
            }
        }
    }
}