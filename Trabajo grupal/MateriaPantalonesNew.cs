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

namespace Trabajo_grupal
{
    public partial class MateriaPantalonesNew : Form
    {
        public MateriaPantalonesNew()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarMateriaPrima()
        {
            String query = "SELECT Codigo, Nombre_Mercancia, Descripcion, Unidad_Medida, Precio_Compra, Stock FROM NuevoInventario where ";

            if (btnbuscar.Text != "")
            {
                query = query + "  ( Nombre_Mercancia like '%" + txtnombre.Text + "%')";
            }

            Conexion.opoencon();
            SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtproductos.DataSource = ds.Tables[0];
            Conexion.cerrarcon();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            MostrarMateriaPrima();
        }
    }
}
