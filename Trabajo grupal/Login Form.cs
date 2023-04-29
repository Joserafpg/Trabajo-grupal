using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_grupal
{
    public partial class Login_Form : Form
    {

        public Login_Form()
        {
            InitializeComponent();
        }

        /*Metodo ReleaseCapture*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text.Equals(""))
            {
                MessageBox.Show("El usuario no debe estar en blanco!...");
                txtusuario.Focus();
                return;
            }

            if (txtcontraseña.Text.Equals(""))
            {
                MessageBox.Show("La contraseña no debe estar en blanco!...");
                txtcontraseña.Focus();
                return;
            }

            DataTable dt = new DataTable();
            string consulta;
            consulta = " select * from Usuarios where Usuario=@usuario AND Contraseña =@contrasena";
            Conexion.opoencon();
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conexion.ObtenerConexion());
            Conexion.cerrarcon();

            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 10).Value = txtusuario.Text;
            da.SelectCommand.Parameters.Add("@contrasena", SqlDbType.VarChar, 10).Value = txtcontraseña.Text;

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Permisos.FormUsuarios = Convert.ToBoolean(dt.Rows[0][4]);
                Permisos.AgregarUSER = Convert.ToBoolean(dt.Rows[0][5]);
                Permisos.ModificarUSER = Convert.ToBoolean(dt.Rows[0][6]);
                Permisos.EliminarUSER = Convert.ToBoolean(dt.Rows[0][7]);
                Permisos.ConsultarUSER = Convert.ToBoolean(dt.Rows[0][8]);
                Permisos.FormCuentasxCobrar = Convert.ToBoolean(dt.Rows[0][9]);
                Permisos.AgregarCuentasCobrar = Convert.ToBoolean(dt.Rows[0][10]);
                Permisos.ModificarCuentasCobrar = Convert.ToBoolean(dt.Rows[0][11]);
                Permisos.ConsultarCuentasCobrar = Convert.ToBoolean(dt.Rows[0][12]);
                Permisos.EliminarCuentasCobrar = Convert.ToBoolean(dt.Rows[0][13]);
                Permisos.FormCuentasPagar = Convert.ToBoolean(dt.Rows[0][14]);
                Permisos.AgregarCuentasPagar = Convert.ToBoolean(dt.Rows[0][15]);
                Permisos.ModificarCuentasPagar = Convert.ToBoolean(dt.Rows[0][16]);
                Permisos.ConsultarCuentasPagar = Convert.ToBoolean(dt.Rows[0][17]);
                Permisos.EliminarCuentasPagar = Convert.ToBoolean(dt.Rows[0][18]);
                Permisos.FormFacturas = Convert.ToBoolean(dt.Rows[0][19]);
                Permisos.AgregarFACTURA = Convert.ToBoolean(dt.Rows[0][20]);
                Permisos.ModificarFACTURA = Convert.ToBoolean(dt.Rows[0][21]);
                Permisos.ConsultarFACTURA = Convert.ToBoolean(dt.Rows[0][22]);
                Permisos.EliminarFACTURA = Convert.ToBoolean(dt.Rows[0][23]);
                Permisos.FormCliente = Convert.ToBoolean(dt.Rows[0][24]);
                Permisos.AgregarCLIENTE = Convert.ToBoolean(dt.Rows[0][25]);
                Permisos.ModificSarCLIENTES = Convert.ToBoolean(dt.Rows[0][26]);
                Permisos.ConsultarCLIENTES = Convert.ToBoolean(dt.Rows[0][27]);
                Permisos.EliminarCLIENTES = Convert.ToBoolean(dt.Rows[0][28]);
                Permisos.FormInventario = Convert.ToBoolean(dt.Rows[0][29]);
                Permisos.AgregarINVENTARIO = Convert.ToBoolean(dt.Rows[0][30]);
                Permisos.ModificarINVENTARIO = Convert.ToBoolean(dt.Rows[0][31]);
                Permisos.ConsultarINVENTARIO = Convert.ToBoolean(dt.Rows[0][32]);
                Permisos.EliminarINVENTARIO = Convert.ToBoolean(dt.Rows[0][33]);
                Form principal = new Form1();
                principal.Show();
                principal.Visible = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show(" Usuario o contraseña Incorrecto");
                txtcontraseña.Focus();
            }

            Conexion.cerrarcon();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
