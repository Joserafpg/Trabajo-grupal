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

        public static bool AgregarUSER { set; get; }
        public static bool ModificarUSER { set; get; }
        public static bool ConsultarUSER { set; get; }
        public static bool EliminarUSER { set; get; }
    }
}
