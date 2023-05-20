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
        public string Size { get; set; }
        public int Stock { get; set; }
        public string Inv_Minimo { get; set; }
        public string Mercancia_Utilizada { get; set; }
        public decimal Precio { get; set; }

        public DatosgetInv() { }

        public DatosgetInv(Int64 pCodigo, string pNombre_Producto,  string pSize, int pStock, string pInv_Minimo, string pMercancia_Utilizada, decimal pPrecio)
        {
            this.Codigo = pCodigo;
            this.Nombre_Producto = pNombre_Producto;
            this.Size = pSize;
            this.Stock = pStock;
            this.Inv_Minimo = pInv_Minimo;
            this.Mercancia_Utilizada = pMercancia_Utilizada;
            this.Precio = pPrecio;
            


        }
    }
}
