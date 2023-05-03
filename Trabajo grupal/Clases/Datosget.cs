using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
    public class Datosget
    {
        public int Codigo { get; set; }
        public string Nombre_Mercancia { get; set; }
        public string Descripcion { get; set; }
        public string Tipo_Producto { get; set; }
        public int Cantidad { get; set; }
        public int Inv_Minimo { get; set; }
        public string Color_Producto { get; set; }
        public string Precio_Compra { get; set; }
        public string Precio_Venta { get; set; }
        public string Precio_PorMayor { get; set; }

        public Datosget() { }

        public Datosget(int pCodigo, string pNombre_Mercancia, string pDescripcion, string pTipo_Producto,  int pCantidad, int pInv_Minimo, string pColor_Producto, string Precio_Compra, string Precio_Venta, string Precio_PorMayor)
        {
            this.Codigo = pCodigo;
            this.Nombre_Mercancia = pNombre_Mercancia;
            this.Descripcion = pDescripcion;
            this.Tipo_Producto = pTipo_Producto;
            this.Cantidad = pCantidad;
            this.Inv_Minimo = pInv_Minimo;
            this.Color_Producto = pColor_Producto;
            this.Precio_Compra = Precio_Compra;
            this.Precio_Venta = Precio_Venta;
            this.Precio_PorMayor = Precio_PorMayor;


        }


    }
}
