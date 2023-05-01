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
        public static int CrearCuentas(string pEmpleado, string pUsuario, string pContrasena, bool pAgregarUSER, bool pModificarUSER, bool pEliminarUSER, bool pConsultarUSER, bool pAgregarCuentasCobrar, bool pModificarCuentascobrar, bool pConsultarCuentasCobrar, bool pEliminarCuentasCobrar, bool pAgregarCuentasPagar, bool pModificarCuentasPagar, bool pConsultarCuentasPagar, bool pEliminarCuentasPagar, bool pAgregarFACTURA, bool pModificarFACTURA, bool pConsultarFACTURA, bool pEliminarFACTURA, bool pAgregarCLIENTE, bool pModificSarCLIENTES, bool pConsultarCLIENTES, bool pEliminarCLIENTES, bool pAgregarINVENTARIO, bool pModificarINVENTARIO, bool pConsultarINVENTARIO, bool pEliminarINVENTARIO)
        {

            int resultado = 0;
            try
            {
                Conexion.opoencon();
                SqlCommand comando = new SqlCommand(string.Format("Insert Into Usuarios (Empleado,Usuario,Contraseña, AgregarUSER, ModificarUSER, EliminarUSER, ConsultarUSER, AgregarCuentasCobrar, ModificarCuentascobrar, ConsultarCuentasCobrar, EliminarCuentasCobrar, AgregarCuentasPagar, ModificarCuentasPagar, ConsultarCuentasPagar, EliminarCuentasPagar,  AgregarFACTURA, ModificarFACTURA, ConsultarFACTURA, EliminarFACTURA, AgregarCLIENTE, ModificSarCLIENTES, ConsultarCLIENTES, EliminarCLIENTES, AgregarINVENTARIO, ModificarINVENTARIO, ConsultarINVENTARIO, EliminarINVENTARIO) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}')",
                    pEmpleado, pUsuario, pContrasena, pAgregarUSER, pModificarUSER, pEliminarUSER, pConsultarUSER, pAgregarCuentasCobrar, pModificarCuentascobrar, pConsultarCuentasCobrar, pEliminarCuentasCobrar, pAgregarCuentasPagar, pModificarCuentasPagar, pConsultarCuentasPagar, pEliminarCuentasPagar, pAgregarFACTURA, pModificarFACTURA, pConsultarFACTURA, pEliminarFACTURA, pAgregarCLIENTE, pModificSarCLIENTES, pConsultarCLIENTES, pEliminarCLIENTES, pAgregarINVENTARIO, pModificarINVENTARIO, pConsultarINVENTARIO, pEliminarINVENTARIO), Conexion.ObtenerConexion());

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
