using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
    public class Datosget
    {
        public Int64 Codigo { get; set; }
        public string Nombre_Mercancia { get; set; }
        public string Descripcion { get; set; }
        public string Tipo_Producto { get; set; }
        public bool Docenas { get; set; }
        public bool Unidad { get; set; }
        public bool Lotes { get; set; }
        public Int64 Cantidad { get; set; }
        public Int64 Inv_Minimo { get; set; }
        public string Color_Producto { get; set; }
        public string Precio_Compra { get; set; }
        
        public Datosget() { }

        public Datosget(Int64 pCodigo, string pNombre_Mercancia, string pDescripcion, string pTipo_Producto, bool Docenas, bool Unidad, 
            bool Lotes,Int64 pCantidad,  Int64 pInv_Minimo, string pColor_Producto, string Precio_Compra)
        {
            this.Codigo = pCodigo;
            this.Nombre_Mercancia = pNombre_Mercancia;
            this.Descripcion = pDescripcion;
            this.Tipo_Producto = pTipo_Producto;
            this.Docenas = Docenas;
            this.Unidad = Unidad;
            this.Lotes = Lotes;
            this.Cantidad = pCantidad;
            this.Inv_Minimo = pInv_Minimo;
            this.Color_Producto = pColor_Producto;
            this.Precio_Compra = Precio_Compra;
            
        }
    }
}
