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

        //Permisos para el formulario NuevoUsuario
        public static bool AgregarUSER { set; get; }
        public static bool ModificarUSER { set; get; }
        public static bool ConsultarUSER { set; get; }
        public static bool EliminarUSER { set; get; }


        //Permisos para el formulario Inventario
        public static bool AgregarINVENTARIO { set; get; }
        public static bool ModificarINVENTARIO { set; get; }
        public static bool ConsultarINVENTARIO { set; get; }
        public static bool EliminarINVENTARIO { set; get; }

        //Permisos para el formulario Clientes 
        public static bool AgregarCLIENTE { set; get; }
        public static bool ModificSarCLIENTES { set; get; }
        public static bool ConsultarCLIENTES { set; get; }
        public static bool EliminarCLIENTES { set; get; }

        //Permisos para el formulario Facturas
        public static bool AgregarFACTURA { set; get; }
        public static bool ModificarFACTURA { set; get; }
        public static bool ConsultarFACTURA { set; get; }
        public static bool EliminarFACTURA { set; get; }

    }
}
