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
    public partial class Sub_Menú_Facturacion : Form
    {
        public Sub_Menú_Facturacion()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Sub_Menú_Facturacion_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = Permisos.ModificarFACTURA;
            btneliminar.Enabled = Permisos.EliminarFACTURA;
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * from FacturaTittle where Id_Factura = @No_Factura", Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@No_Factura", txtnofactura.Text);
            Conexion.opoencon();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtempleado.Text = registro["Empleado"].ToString();
                txtcliente.Text = registro["Cliente"].ToString();
                dtpfecha.Text = registro["Fecha"].ToString();
                txttotal.Text = registro["Total"].ToString();

            }
            Conexion.cerrarcon();

            String query = "select Codigo, Producto, Size, Precio, Cantidad, SubTotal from Factura where ";
            if (btnconsultar.Text != "")
            {
                query = query + "( No_Factura like '%" + Convert.ToInt64(txtnofactura.Text) + "%')";
            }

            Conexion.opoencon();
            SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Conexion.cerrarcon();

        }
    }
}
