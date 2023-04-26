using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_grupal
{
    internal class UsuariosDAL
    {
        public static int CrearCuentas(string pEmpleado,string pUsuario, string pContrasena, bool pAgregarUSER, bool pModificar, bool pEliminar, bool pConsultar, bool @checked)
        {

            int resultado = 0;
            try
            {
                Conexion.opoencon();
                SqlCommand comando = new SqlCommand(string.Format("Insert Into Usuarios (Empleado,Usuario,Contraseña,AgregarUSER,ModificarUSER,EliminarUSER,ConsultarUSER) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    pEmpleado, pUsuario, pContrasena, pAgregarUSER, pModificar, pEliminar, pConsultar), Conexion.ObtenerConexion());

                resultado = comando.ExecuteNonQuery();
                Conexion.cerrarcon();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al Guardar " + ex.Message);
            }
            return resultado;
        }
    }
}
