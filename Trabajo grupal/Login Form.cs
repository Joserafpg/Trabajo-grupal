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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                Permisos.AgregarUSER = Convert.ToBoolean(dt.Rows[0][4]);
                Permisos.ModificarUSER = Convert.ToBoolean(dt.Rows[0][5]);
                Permisos.EliminarUSER = Convert.ToBoolean(dt.Rows[0][6]);
                Permisos.ConsultarUSER = Convert.ToBoolean(dt.Rows[0][7]);
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
    }
}
