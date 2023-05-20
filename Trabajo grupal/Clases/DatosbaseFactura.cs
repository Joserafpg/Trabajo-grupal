using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
    public class DatosbaseFactura
    {
        public static int Agregar(Datosgetfactura pget)
        {

            int retorno = 0;

            Conexion.opoencon();

            SqlCommand Comando = new SqlCommand(string.Format("Insert into FacturaTittle (Empleado, Cliente, Fecha, Total) values ('{0}','{1}','{2}','{3}')",
                    pget.Empleado, pget.Cliente, pget.Fecha.ToString("yyyy-MM-dd HH:mm:ss"), pget.Total), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;

        }
    }
}
