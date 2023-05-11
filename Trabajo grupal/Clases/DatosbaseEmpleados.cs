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

            SqlCommand Comando = new SqlCommand(string.Format("Insert into Empleados (Nombre_Completo, Cedula, Telefono, Direccion, Correo, Fecha_de_nacimiento, Fecha_de_ingreso, Sueldo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    pget.Nombre, pget.Cedula, pget.Telefono, pget.Direccion, pget.Correo, pget.Fecha_Nac.ToString("yyyy-MM-dd HH:mm:ss"), pget.Fecha_Ingreso.ToString("yyyy-MM-dd HH:mm:ss"), pget.Sueldo), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;

        }

        public static int Modificar(DatosgetEmpleados pAlumno)
        {
            int retorno = 0;
            Conexion.opoencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("update Empleados set Nombre_Completo = '{0}', Cedula = '{1}', Telefono = '{2}', Direccion = '{3}', Correo = '{4}', Fecha_de_nacimiento = '{5}', Fecha_de_ingreso = '{6}', Sueldo = '{7}',  where Codigo = {8}",
                    pAlumno.Nombre, pAlumno.Cedula, pAlumno.Telefono, pAlumno.Direccion, pAlumno.Correo, pAlumno.Fecha_Nac.ToString("yyyy-MM-dd HH:mm:ss"), pAlumno.Fecha_Ingreso.ToString("yyyy-MM-dd HH:mm:ss"), pAlumno.Sueldo, pAlumno.Codigo), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            Conexion.cerrarcon();
            return retorno;
        }

        public static int Eliminar(int pID)
        {
            int retorno = 0;
            Conexion.opoencon();
            SqlCommand Comando = new SqlCommand(string.Format("Delete from Alumnos where Codigo = {0}", pID), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;
        }

        public static List<DatosgetEmpleados> BuscarAlumnos(string pCodigo, string pCedula)
        {
            List<DatosgetEmpleados> lista = new List<DatosgetEmpleados>();
            Conexion.opoencon();
            {

                SqlCommand comando = new SqlCommand(String.Format("SELECT Codigo,Cedula, Nombre, Telefono, Direccion, Fecha_nacimiento FROM Alumnos where codigo like '%{0}%' and telefono like '%{1}%' ", pCodigo, pCedula),
                    Conexion.ObtenerConexion());

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DatosgetEmpleados pAlumnos = new DatosgetEmpleados();
                    pAlumnos.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pAlumnos.Nombre = reader.GetString(1);
                    pAlumnos.Cedula = reader.GetString(2);
                    pAlumnos.Telefono = reader.GetString(3);
                    pAlumnos.Direccion = reader.GetString(4);
                    pAlumnos.Correo = reader.GetString(5);
                    pAlumnos.Fecha_Nac = Convert.ToDateTime(reader.GetValue(6));
                    pAlumnos.Fecha_Ingreso = Convert.ToDateTime(reader.GetValue(7));
                    pAlumnos.Sueldo = reader.GetString(8);

                    lista.Add(pAlumnos);
                }
                Conexion.cerrarcon();
                return lista;
            }
        }


        public static DatosgetEmpleados ObtenerAlumnos(string pId)
        {
            Conexion.opoencon();
            {
                DatosgetEmpleados pAlumno = new DatosgetEmpleados();
                SqlCommand comando = new SqlCommand(string.Format(
                   "select codigo, Nombre, Cedula, Telefono, Direccion, Fecha_nacimiento From Alumnos where Codigo = {0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pAlumno.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pAlumno.Nombre = reader.GetString(1);
                    pAlumno.Telefono = reader.GetString(2);
                    pAlumno.Cedula = reader.GetString(3);
                    pAlumno.Direccion = reader.GetString(4);
                    pAlumno.Fecha_Nac = reader.GetDateTime(5);
                }
                Conexion.cerrarcon();
                return pAlumno;
            }
        }
    }
}
