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

        public static int Modificar(Datosgetfactura pAlumno)
        {
            int retorno = 0;
            Conexion.opoencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("update FacturaTittle set Empleado = '{0}', Cliente = '{1}', Fecha = '{2}', Total = '{3}' where Id_Factura = {4}",
                    pAlumno.Empleado, pAlumno.Cliente, pAlumno.Fecha.ToString("yyyy-MM-dd HH:mm:ss"), pAlumno.Total, pAlumno.ID_Factura), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            Conexion.cerrarcon();
            return retorno;
        }

        public static int Eliminar(int pID)
        {
            int retorno = 0;
            Conexion.opoencon();
            SqlCommand Comando = new SqlCommand(string.Format("Delete from FacturaTittle where Id_Factura = {0}", pID), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;
        }

        public static List<Datosgetfactura> BuscarFactura(Int64 pID, string pCliente)
        {
            List<Datosgetfactura> lista = new List<Datosgetfactura>();
            Conexion.opoencon();
            {

                SqlCommand comando = new SqlCommand(String.Format("SELECT Empleado, Cliente, Fecha, Total FROM FacturaTittle where Id_Factura like '%{0}%' and Cliente like '%{1}%' ", pID, pCliente),
                    Conexion.ObtenerConexion());

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Datosgetfactura pEmpleados = new Datosgetfactura();
                    pEmpleados.ID_Factura = Convert.ToInt64(reader.GetValue(0));
                    pEmpleados.Empleado = reader.GetString(1);
                    pEmpleados.Cliente = reader.GetString(2);
                    pEmpleados.Fecha = Convert.ToDateTime(reader.GetValue(3));
                    pEmpleados.Total = reader.GetDecimal(4);

                    lista.Add(pEmpleados);
                }
                Conexion.cerrarcon();
                return lista;
            }
        }

        public static Datosgetfactura ObtenerFactura(Int64 pId)
        {
            Conexion.opoencon();
            {
                Datosgetfactura pAlumno = new Datosgetfactura();
                SqlCommand comando = new SqlCommand(string.Format(
                   "SELECT Empleado, Cliente, Fecha, Total From FacturaTittle where Id_Factura = {0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pAlumno.ID_Factura = Convert.ToInt64(reader.GetValue(0));
                    pAlumno.Empleado = reader.GetString(1);
                    pAlumno.Cliente = reader.GetString(2);
                    pAlumno.Fecha = reader.GetDateTime(3);
                    pAlumno.Total = reader.GetDecimal(4);
                }
                Conexion.cerrarcon();
                return pAlumno;
            }
        }
    }
}
