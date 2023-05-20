using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
    public class Datosgetfactura
    {
        public Int64 ID_Factura { get; set; }
        public string Empleado { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public Datosgetfactura() { }

        public Datosgetfactura(long iD_Factura, string empleado, string cliente, DateTime fecha, decimal total)
        {
            ID_Factura = iD_Factura;
            Empleado = empleado;
            Cliente = cliente;
            Fecha = fecha;
            Total = total;
        }
    }
}
