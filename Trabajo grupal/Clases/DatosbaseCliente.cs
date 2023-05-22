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

            SqlCommand Comando = new SqlCommand(string.Format("Insert into Clientes (Nombre, Apellido, Telefono, Direccion, Correo, Fecha_de_ingreso) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
              pget.Nombre, pget.Apellido, pget.Telefono, pget.Direccion, pget.Correo, pget.Fecha_de_Ingreso.ToString("yyyy-MM-dd HH:mm:ss")), Conexion.ObtenerConexion());

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
                 pClientes.Nombre, pClientes.Apellido, pClientes.Telefono, pClientes.Direccion, pClientes.Correo, pClientes.Fecha_de_Ingreso.ToString("yyyy-MM-dd HH:mm:ss"), pClientes.Codigo), Conexion.ObtenerConexion());
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


        public static List<DatosgetClientes> BuscarClientes(string pNombre, string pTelefono)
        {
            List<DatosgetClientes> lista = new List<DatosgetClientes>();
            Conexion.opoencon();
            {

                SqlCommand comando = new SqlCommand(String.Format(
               "SELECT Codigo,Cedula, Nombre, APellido, Telefono, Direccion, Correo,Fecha_de_Ingreso FROM  where codigo like '%{0}%' and telefono like '%{1}%' ", pNombre, pTelefono),
                    Conexion.ObtenerConexion());

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DatosgetClientes pClientes = new DatosgetClientes();
                    pClientes.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pClientes.Nombre = reader.GetString(1);
                    pClientes.Apellido = reader.GetString(2);
                    pClientes.Direccion = reader.GetString(3);
                    pClientes.Telefono = reader.GetString(4);
                    pClientes.Correo = reader.GetString(5);
                    pClientes.Fecha_de_Ingreso = Convert.ToDateTime(reader.GetValue(6));

                    lista.Add(pClientes);
                }
                Conexion.cerrarcon();
                return lista;
            }
        }
        public static DatosgetClientes ObtenerClientes(Int64 pId)
        {
            Conexion.opoencon();
            {
                DatosgetClientes pClientes = new DatosgetClientes();
                SqlCommand comando = new SqlCommand(string.Format(
                   "select Codigo, Nombre, Apellido, Direccion, Telefono,Correo,Fecha_de_Ingreso Fecha From Clientes where Codigo = {0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pClientes.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pClientes.Nombre = reader.GetString(1);
                    pClientes.Apellido = reader.GetString(2);
                    pClientes.Direccion = reader.GetString(3);
                    pClientes.Telefono = reader.GetString(4);
                    pClientes.Correo = reader.GetString(5);
                    pClientes.Fecha_de_Ingreso = reader.GetDateTime(5);

                }

                
                Conexion.cerrarcon();
                return pClientes;
            }
        }
    }
}

     


    




