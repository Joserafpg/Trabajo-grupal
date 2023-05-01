using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
    public class DatosgetClientes
    {
        public int Codigo { get; set; }
        public string Nombre_Mercancia { get; set; }
        public string Descripcion { get; set; }
        public string Tipo_Producto { get; set; }
        public int Cantidad { get; set; }
        public int Inv_Minimo { get; set; }
        public string Color_Producto { get; set; }
        public SByte Precio_Compra { get; set; }
        public SByte Precio_Venta { get; set; }
        public SByte Precio_PorMayor { get; set; }


    }
}
