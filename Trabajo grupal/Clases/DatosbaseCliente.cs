using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Trabajo_grupal;
using Trabajo_grupal.Clases;

namespace Trabajo_grupal
{
    public class DatosbaseCliente
    {
        public static int Agregar(DatosgetClientes pget)
        {

            int retorno = 0;

            Conexion.opoencon();

            SqlCommand Comando = new SqlCommand(string.Format("Insert into Clientes (Nombre, Apellido, Telefono, Direccion, Correo, Fecha_Ingreso) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
              pget.Nombre, pget.Apellido, pget.Telefono, pget.Direccion, pget.Correo, pget.Fecha_Ingreso.ToString("yyyy-MM-dd HH:mm:ss")), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;

        }

        public static int Modificar(DatosgetClientes pClientes)
        {
            int retorno = 0;
            Conexion.opoencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("Update Clientes set Nombre='{0}',Apellido='{1}',Telefono='{2}',Direccion='{3}',Correo='{4}' where Fecha_Ingreso='{5}'",
                 pClientes.Nombre, pClientes.Apellido, pClientes.Telefono, pClientes.Direccion, pClientes.Correo, pClientes.Fecha_Ingreso.ToString("yyyy-MM-dd HH:mm:ss"), pClientes.Codigo), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

            }

            Conexion.cerrarcon();
            return retorno;

        }

        public static int Eliminar(int pId)
        {
            {
                int retorno = 0;
                Conexion.opoencon();
                SqlCommand comando = new SqlCommand(string.Format("Delete From Clientes where Codigo = {0}", pId), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                Conexion.cerrarcon();
                return retorno;

            }
        }
    }
}



