using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
    public class MateriaPrima
    {
        public Int64 Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Medida { get; set; }
        public decimal Precio { get; set; }

        public int Cantidad = 1;
    }
}
