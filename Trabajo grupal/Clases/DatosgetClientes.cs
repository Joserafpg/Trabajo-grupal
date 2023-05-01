using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
    public class DatosgetClientes
    {
        public Int64 Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha_Ingreso { get; set; }

        public DatosgetClientes() { }

        public DatosgetClientes(Int64 pCodigo, string pNombre, string pApellido, string pDireccion, string pTelefono, string pCorreo, DateTime pFecha_Ingreso)
        {
            this.Codigo = pCodigo;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Direccion = pDireccion;
            this.Telefono = pTelefono;
            this.Correo = pCorreo;
            this.Fecha_Ingreso = pFecha_Ingreso;
        }
    }
}
