using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
    public class DatosbaseEmpleados
    {
        public static int Agregar(DatosgetEmpleados pget)
        {

            int retorno = 0;

            Conexion.opoencon();

            SqlCommand Comando = new SqlCommand(string.Format("Insert into Empleados (Nombre_Completo, Cedula, Direccion, Telefono, Correo, Fecha_de_nacimiento, Sexo, Fecha_de_ingreso, Sueldo, AFP, SFS, Puesto) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                    pget.Nombre, pget.Cedula, pget.Direccion, pget.Telefono, pget.Correo, pget.Fecha_Nac.ToString("yyyy-MM-dd HH:mm:ss"), pget.Sexo, pget.Fecha_Ingreso.ToString("yyyy-MM-dd HH:mm:ss"), pget.Sueldo, pget.AFP, pget.SFS, pget.Puesto), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;

        }

        public static int Modificar(DatosgetEmpleados pAlumno)
        {
            int retorno = 0;
            Conexion.opoencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("update Empleados set Nombre_Completo = '{0}', Cedula = '{1}', Direccion = '{2}', Telefono = '{3}', Correo = '{4}', Fecha_de_nacimiento = '{5}', Sexo = '{6}', Fecha_de_ingreso = '{7}', Sueldo = '{8}', AFP = '{9}', SFS= '{10}', Puesto = '{11}'  where Id_Empleados = {12}",
                    pAlumno.Nombre, pAlumno.Cedula, pAlumno.Direccion, pAlumno.Telefono, pAlumno.Correo, pAlumno.Fecha_Nac.ToString("yyyy-MM-dd HH:mm:ss"), pAlumno.Sexo, pAlumno.Fecha_Ingreso.ToString("yyyy-MM-dd HH:mm:ss"), pAlumno.Sueldo, pAlumno.AFP, pAlumno.SFS, pAlumno.Puesto, pAlumno.Codigo), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            Conexion.cerrarcon();
            return retorno;
        }

        public static int Eliminar(int pID)
        {
            int retorno = 0;
            Conexion.opoencon();
            SqlCommand Comando = new SqlCommand(string.Format("Delete from Empleados where Id_Empleados = {0}", pID), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;
        }

        public static List<DatosgetEmpleados> BuscarEmpleados(string pNombre, string pCedula)
        {
            List<DatosgetEmpleados> lista = new List<DatosgetEmpleados>();
            Conexion.opoencon();
            {

                SqlCommand comando = new SqlCommand(String.Format("SELECT Id_Empleados, Nombre_Completo, Cedula, Direccion, Telefono, Correo, Fecha_de_nacimiento, Sexo, Fecha_de_ingreso, Sueldo, AFP, SFS, Puesto FROM Empleados where Nombre_Completo like '%{0}%' and Cedula like '%{1}%' ", pNombre, pCedula),
                    Conexion.ObtenerConexion());

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DatosgetEmpleados pEmpleados = new DatosgetEmpleados();
                    pEmpleados.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pEmpleados.Nombre = reader.GetString(1);
                    pEmpleados.Cedula = reader.GetString(2);
                    pEmpleados.Telefono = reader.GetString(3);
                    pEmpleados.Direccion = reader.GetString(4);
                    pEmpleados.Correo = reader.GetString(5);
                    pEmpleados.Fecha_Nac = Convert.ToDateTime(reader.GetValue(6));
                    pEmpleados.Sexo = reader.GetString(7);
                    pEmpleados.Fecha_Ingreso = Convert.ToDateTime(reader.GetValue(8));
                    pEmpleados.Sueldo = reader.GetString(9);
                    pEmpleados.AFP = reader.GetString(10);
                    pEmpleados.SFS = reader.GetString(11);
                    pEmpleados.Puesto = reader.GetString(12);

                    lista.Add(pEmpleados);
                }
                Conexion.cerrarcon();
                return lista;
            }
        }


        public static DatosgetEmpleados ObtenerEmpleados(string pId)
        {
            Conexion.opoencon();
            {
                DatosgetEmpleados pAlumno = new DatosgetEmpleados();
                SqlCommand comando = new SqlCommand(string.Format(
                   "select Id_Empleados, Nombre_Completo, Cedula, Direccion, Telefono, Correo, Fecha_de_nacimiento, Sexo, Fecha_de_ingreso, Sueldo, AFP, SFS, Puesto From Empleados where Id_Empleados = {0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pAlumno.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pAlumno.Nombre = reader.GetString(1);
                    pAlumno.Cedula = reader.GetString(2);
                    pAlumno.Direccion = reader.GetString(3);
                    pAlumno.Telefono = reader.GetString(4);
                    pAlumno.Correo = reader.GetString(5);
                    pAlumno.Fecha_Nac = reader.GetDateTime(6);
                    pAlumno.Sexo = reader.GetString(7);
                    pAlumno.Fecha_Ingreso = reader.GetDateTime(8);
                    pAlumno.Sueldo = reader.GetString(9);
                    pAlumno.AFP = reader.GetString(10);
                    pAlumno.SFS = reader.GetString(11);
                    pAlumno.Puesto = reader.GetString(12);
                }
                Conexion.cerrarcon();
                return pAlumno;
            }
        }
    }
}