using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
   public class DatosgetInv
   {
        public Int64 Codigo { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public Int64 Cantidad { get; set; }
        public Int64 Inv_Minimo { get; set; }
        public string Mercancia_Utilizada { get; set; }
        public string Precio_Venta { get; set; }
        public string Precio_PorMayor { get; set; }

        public DatosgetInv() { }

        public DatosgetInv(Int64 pCodigo, string pNombre_Producto, string pDescripcion, Int64 pCantidad, Int64 pInv_Minimo, string pMercancia_Utilizada, string Precio_Venta, string Precio_PorMayor)
        {
            this.Codigo = pCodigo;
            this.Nombre_Producto = pNombre_Producto;
            this.Descripcion = pDescripcion;
            this.Cantidad = pCantidad;
            this.Inv_Minimo = pInv_Minimo;
            this.Mercancia_Utilizada = pMercancia_Utilizada;
            this.Precio_Venta = Precio_Venta;
            this.Precio_PorMayor = Precio_PorMayor;


        }
    }
}
