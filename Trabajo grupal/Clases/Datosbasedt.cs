using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trabajo_grupal.Clases
{
    class Datosbasedt
    {
        public static int agregar(Datosget pget)
        {
            int retorno = 0;

            Conexion.opoencon();
            SqlCommand comando = new SqlCommand(string.Format(" insert into NuevoInventario (Codigo, Nombre_Mercancia, Descripcion, Tipo_Producto, Cantidad, Inv_Minimo, Color_Producto, Precio_Compra, Precio_Venta, Precio_PorMayor) " +
                "values ('{0}','{1}','{2}','{3}','{4}', '{5}','{6}','{7}','{8}','{9}')",
                    pget.Codigo, pget.Nombre_Mercancia, pget.Descripcion, pget.Tipo_Producto, pget.Cantidad, pget.Inv_Minimo,pget.Color_Producto, pget.Precio_Compra, pget.Precio_Venta, pget.Precio_PorMayor), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;



        }






    }
}
