using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
   public class DatosgetInv
   {
        public int Codigo { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int Inv_Minimo { get; set; }
        public string Mercancia_Utilizada { get; set; }
        public string Precio_Venta { get; set; }
        public string Precio_PorMayor { get; set; }

        public DatosgetInv() { }

        public DatosgetInv(int pCodigo, string pNombre_Producto, string pDescripcion, int pCantidad, int pInv_Minimo, string pMercancia_Utilizada, string Precio_Venta, string Precio_PorMayor)
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
