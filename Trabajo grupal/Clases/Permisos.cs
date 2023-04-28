using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal
{
    public class Permisos
    {
        public Permisos()
        {
        }

        //Permisos cuentas por cobrar
        public static bool FormCuentasxCobrar { set; get; }
        public static bool AgregarCuentasCobrar { set; get; }
        public static bool ModificarCuentasCobrar { set; get; }
        public static bool ConsultarCuentasCobrar { set; get; }
        public static bool EliminarCuentasCobrar { set; get; }

        //Permisos cuentas por pagar
        public static bool FormCuentasPagar { set; get; }
        public static bool AgregarCuentasPagar { set; get; }
        public static bool ModificarCuentasPagar { set; get; }
        public static bool ConsultarCuentasPagar { set; get; }
        public static bool EliminarCuentasPagar { set; get; }

        //Permisos para el formulario NuevoUsuario
        public static bool FormUsuarios { set; get; }
        public static bool AgregarUSER { set; get; }
        public static bool ModificarUSER { set; get; }
        public static bool ConsultarUSER { set; get; }
        public static bool EliminarUSER { set; get; }


        //Permisos para el formulario Inventario
        public static bool FormInventario { set; get; }
        public static bool AgregarINVENTARIO { set; get; }
        public static bool ModificarINVENTARIO { set; get; }
        public static bool ConsultarINVENTARIO { set; get; }
        public static bool EliminarINVENTARIO { set; get; }


        //Permisos para el formulario Clientes 
        public static bool FormCliente { set; get; }
        public static bool AgregarCLIENTE { set; get; }
        public static bool ModificSarCLIENTES { set; get; }
        public static bool ConsultarCLIENTES { set; get; }
        public static bool EliminarCLIENTES { set; get; }


        //Permisos para el formulario Facturas
        public static bool FormFacturas { set; get; }
        public static bool AgregarFACTURA { set; get; }
        public static bool ModificarFACTURA { set; get; }
        public static bool ConsultarFACTURA { set; get; }
        public static bool EliminarFACTURA { set; get; }

    }
}
