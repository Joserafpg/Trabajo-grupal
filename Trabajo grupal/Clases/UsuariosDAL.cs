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
        public static int CrearCuentas(string pEmpleado,string pUsuario, string pContrasena, bool pAgregarUSER, bool pModificarUSER, bool pEliminarUSER, bool pConsultarUSER, bool pAgregarFACTURA, bool pModificarFACTURA, bool pConsultarFACTURA, bool pEliminarFACTURA, bool @checked)
        {

            int resultado = 0;
            try
            {
                Conexion.opoencon();
                SqlCommand comando = new SqlCommand(string.Format("Insert Into Usuarios (Empleado,Usuario,Contraseña,AgregarUSER,ModificarUSER,EliminarUSER,ConsultarUSER,AgregarFACTURA,ModificarFACTURA,ConsultarFACTURA,EliminarFACTURA) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                    pEmpleado, pUsuario, pContrasena, pAgregarUSER, pModificarUSER, pEliminarUSER, pConsultarUSER, pAgregarFACTURA, pModificarFACTURA, pConsultarFACTURA, pEliminarFACTURA ), Conexion.ObtenerConexion());

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
