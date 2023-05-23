using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
    public class DatosgetMateriaPrima
    {
        public Int64 Codigo { get; set; }
        public string Nombre_Mercancia { get; set; }
        public string Descripcion { get; set; }
        public string Tipo_Producto { get; set; }
        public string Unidad_Medida { get; set; }
        public int Stock { get; set; }
        public int Inv_Minimo { get; set; }
        public decimal Precio_Compra { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        
        public DatosgetMateriaPrima() { }

        public DatosgetMateriaPrima(Int64 pCodigo, string pNombre_Mercancia, string pDescripcion, string pTipo_Producto,  
            string pUnidad_Medida,int pStock,  int pInv_Minimo, DateTime Fecha_Ingreso, decimal Precio_Compra )
        {
            this.Codigo = Codigo = pCodigo;
            this.Nombre_Mercancia = pNombre_Mercancia;
            this.Descripcion = pDescripcion;
            this.Tipo_Producto = pTipo_Producto;
            this.Unidad_Medida = pUnidad_Medida;
            this.Stock = pStock;
            this.Inv_Minimo = pInv_Minimo;
            this.Precio_Compra = Precio_Compra;
            this.Fecha_Ingreso = Fecha_Ingreso;
            
        }
    }
}
