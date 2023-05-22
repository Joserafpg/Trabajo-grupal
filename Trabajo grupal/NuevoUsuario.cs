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
using System.Data.SqlClient;

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
            eliminaruser.Checked = false;
            agregarcobros.Checked = false;
            modificarcobros.Checked = false;
            consultarcobros.Checked = false;
            eliminarcobros.Checked = false;
            agregarpagos.Checked = false;
            modificarpagos.Checked = false;
            consultarpagos.Checked = false;
            eliminarpagos.Checked = false;
        }

        private static SqlConnection Conn = new SqlConnection("Server = DESKTOP-NDDA7LS; database=Proyecto_Grupal; Integrated Security=True");
        void CargarComboBox()
        {
            Conn.Open();
            string consulta = "Select * from Empleados";
            SqlCommand comando = new SqlCommand(consulta, Conn);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                txtempleado.Items.Add(lector.GetString(1));
            }

            Conn.Close();
        }

        void CheckboxInventario()
        {
            if (chagregarmercancia.Checked || checonsultar.Checked || chmodificarinventario.Checked || cheliminarmercancia.Checked)
            {
                chforminventario.Checked = true;
            }

            else
            {
                chforminventario.Checked = false;
            }
        }

        void CheckboxClientes()
        {
            if (chagregarclientes.Checked || chconsultarclientes.Checked || chmodificarclientes.Checked || cheliminarclientes.Checked)
            {
                chformcliente.Checked = true;
            }

            else
            {
                chformcliente.Checked = false;
            }
        }

        void CheckboxFactura()
        {
            if (chagregarfactura.Checked || chconsultarfactura.Checked || chmodificarfacttura.Checked || cheliminarfactura.Checked)
            {
                chformfacturas.Checked = true;
            }

            else
            {
                chformfacturas.Checked = false;
            }
        }

        void CheckboxUsuarios()
        {
            if (agregaruser.Checked || consultaruser.Checked || modificaruser.Checked || eliminaruser.Checked)
            {
                chformusuarios.Checked = true;
            }

            else
            {
                chformusuarios.Checked = false;
            }
        }

        void CheckboxCuentasPagar()
        {
            if (agregarpagos.Checked || consultarpagos.Checked || modificarpagos.Checked || eliminarpagos.Checked)
            {
                chformpagar.Checked = true;
            }

            else
            {
                chformpagar.Checked = false;
            }
        }

        void CheckboxCuentasCobra()
        {
            if (agregarcobros.Checked || consultarcobros.Checked || modificarcobros.Checked || eliminarcobros.Checked)
            {
                chformcobrar.Checked = true;
            }

            else
            {
                chformcobrar.Checked = false;
            }
        }


        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            formpermiso.Visible = false;
            RejuegoON();
            CargarComboBox();
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
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtempleado.Text == "" || txtusuario.Text == "" || txtcontraseña.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos.");
            }

            else if (txtusuario.Text.Length < 4)
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
                if (UsuariosDAL.CrearCuentas(txtempleado.Text, txtusuario.Text, txtcontraseña.Text, agregaruser.Checked, modificaruser.Checked, eliminaruser.Checked, consultaruser.Checked, agregarcobros.Checked, modificarcobros.Checked, consultarcobros.Checked, eliminarcobros.Checked, agregarpagos.Checked, modificarpagos.Checked, consultarpagos.Checked, eliminarpagos.Checked, chagregarfactura.Checked, chmodificarfacttura.Checked, chconsultarfactura.Checked, cheliminarfactura.Checked, chagregarclientes.Checked, chmodificarclientes.Checked, chconsultarclientes.Checked, cheliminarclientes.Checked, chagregarmercancia.Checked, chmodificarinventario.Checked, checonsultar.Checked, cheliminarmercancia.Checked, chformusuarios.Checked, chformcobrar.Checked, chformpagar.Checked, chformfacturas.Checked, chformcliente.Checked, chforminventario.Checked) > 0)
                {
                    MessageBox.Show("Cuenta creada con exito");
                }

                else
                    MessageBox.Show("Nose pudo crear la cuenta");

            RejuegoON();
            groupBox1.Text = "Agregar Nuevo Usuario";
            Limpiar();
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

                    agregarcobros.Checked = true;
                    modificarcobros.Checked = true;
                    consultarcobros.Checked = true;
                    eliminarcobros.Checked = true;

                    agregarpagos.Checked = true;
                    modificarpagos.Checked = true;
                    consultarpagos.Checked = true;
                    eliminarpagos.Checked = true;
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

                    agregarcobros.Checked = false;
                    modificarcobros.Checked = false;
                    consultarcobros.Checked = false;
                    eliminarcobros.Checked = false;

                    agregarpagos.Checked = false;
                    modificarpagos.Checked = false;
                    consultarpagos.Checked = false;
                    eliminarpagos.Checked = false;
                }
            }
        }

        private void cheliminarmercancia_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxInventario();
        }

        private void chmodificarinventario_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxInventario();
        }

        private void checonsultar_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxInventario();
        }

        private void chagregarmercancia_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxInventario();
        }

        private void chagregarclientes_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxClientes();
        }

        private void chconsultarclientes_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxClientes();
        }

        private void chmodificarclientes_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxClientes();
        }

        private void cheliminarclientes_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxClientes();
        }

        private void chagregarfactura_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxFactura();
        }

        private void chconsultarfactura_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxFactura();
        }

        private void chmodificarfacttura_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxFactura();
        }

        private void cheliminarfactura_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxFactura();
        }

        private void agregaruser_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxUsuarios();
        }

        private void consultaruser_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxUsuarios();
        }

        private void modificaruser_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxUsuarios();
        }

        private void eliminaruser_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxUsuarios();
        }

        private void agregarpagos_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxCuentasPagar();
        }

        private void modificarpagos_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxCuentasPagar();
        }

        private void eliminarpagos_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxCuentasPagar();
        }

        private void consultarpagos_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxCuentasPagar();
        }

        private void agregarcobros_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxCuentasCobra();
        }

        private void consultarcobros_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxCuentasCobra();
        }

        private void modificarcobros_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxCuentasCobra();
        }

        private void eliminarcobros_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxCuentasCobra();
        }
    }
}