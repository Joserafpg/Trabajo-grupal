using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_grupal.Clases;

namespace Trabajo_grupal
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            btnbuscar.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "select * from Usuarios where ";

            if (btnbuscar.Text != "")
            {
                query = query + "  ( Empleado like '%" + txtempleado.Text + "%')";
            }

            Conexion.opoencon();
            SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgdatos.DataSource = ds.Tables[0];
            Conexion.cerrarcon();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
