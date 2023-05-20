using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_grupal
{
    public class Conexion
    {
        private static SqlConnection Conn = new SqlConnection("Data source = DESKTOP-NDDA7LS; Initial Catalog=Proyecto_Grupal; Integrated Security=True");

        public static SqlConnection ObtenerConexion()
        {
            return Conn;
        }

        public static void opoencon()
        {
            try
            {
                Conn.Open();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void cerrarcon()
        {
            if (Conn != null)
            {
                try
                {
                    Conn.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
