using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
    public class DatosgetEmpleados
    {
        public Int64 Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Sueldo { get; set; }
        public string AFP { get; set; }
        public string SFS { get; set; }
        public string Puesto { get; set; }

        public DatosgetEmpleados() { }

        public DatosgetEmpleados(Int64 pCodigo, string pCedula, string pNombre, string pTelefono, string pDireccion, DateTime pFecha_Nac, DateTime pFecha_Ingres, string pSueldo, string aFP, string sFS, string pPuesto)
        {
            this.Codigo = pCodigo;
            this.Cedula = pCedula;
            this.Nombre = pNombre;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
            this.Fecha_Nac = pFecha_Nac;
            this.Fecha_Ingreso = pFecha_Ingres;
            this.Sueldo = pSueldo;
            this.AFP = aFP;
            this.SFS = sFS;
            this.Puesto = pPuesto;
        }
    }
}
