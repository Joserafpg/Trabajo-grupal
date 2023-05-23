using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trabajo_grupal.Clases
{
    public class Datosbasedt
    {
        public static int agregar(DatosgetMateriaPrima pget)
        {
            int retorno = 0;

            Conexion.opoencon();
            SqlCommand comando = new SqlCommand(string.Format(" insert into NuevoInventario (Codigo, Nombre_Mercancia, Descripcion, Tipo_Producto, Unidad_Medida, Stock, Inv_Minimo, Precio_Compra, Fecha_Ingreso) " +
                "values ('{0}','{1}','{2}','{3}','{4}', '{5}','{6}','{7}','{8}')",
                    pget.Codigo, pget.Nombre_Mercancia, pget.Descripcion, pget.Tipo_Producto, pget.Unidad_Medida, pget.Stock, pget.Inv_Minimo, pget.Precio_Compra, pget.Fecha_Ingreso), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;



        }
        public static int Modificar(DatosgetMateriaPrima pNuevoInventario)
        {

            int retorno = 0;
            Conexion.opoencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("Update NuevoInventario set Nombre_Mercancia ='{0}', Descripcion='{1}',Tipo_Producto='{2}', Unidad_Medida='{3}' ,Stock='{4}',Inv_Minimo='{5}', Precio_Compra ='{6}', Fecha_Ingreso = '{7}' where Codigo={8}",
                     pNuevoInventario.Codigo, pNuevoInventario.Nombre_Mercancia, pNuevoInventario.Descripcion, pNuevoInventario.Tipo_Producto, pNuevoInventario.Unidad_Medida,  pNuevoInventario.Stock, pNuevoInventario.Inv_Minimo,
                     pNuevoInventario.Precio_Compra, pNuevoInventario.Fecha_Ingreso), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            Conexion.cerrarcon();
            return retorno;
        }
        public static int Eliminar(int pId)
        {
            int retorno = 0;
            Conexion.opoencon();
            SqlCommand comando = new SqlCommand(string.Format("Delete  From NuevoInventario where Codigo={0}", pId), Conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;
        }

        public static List<DatosgetMateriaPrima> BuscarNuevoInventario(string pNombre_Mercancia, Int64 pCodigo)
        {
            List<DatosgetMateriaPrima> lista = new List<DatosgetMateriaPrima>();
            Conexion.opoencon();
            {

                SqlCommand comando = new SqlCommand(String.Format(
                    "SELECT  Nombre_Mercancia, Descripcion, Tipo_Producto, Unidad_Medida, Stock, Inv_Minimo, Precio_Compra, Fecha_Ingreso FROM NuevoInventario  where Codigo like '%{0}%'", pNombre_Mercancia, pCodigo), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DatosgetMateriaPrima pNuevoInventario = new DatosgetMateriaPrima();


                    pNuevoInventario.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pNuevoInventario.Nombre_Mercancia = reader.GetString(1);
                    pNuevoInventario.Descripcion = reader.GetString(2);
                    pNuevoInventario.Tipo_Producto = reader.GetString(3);
                    pNuevoInventario.Unidad_Medida = reader.GetString(4);
                    pNuevoInventario.Stock = Convert.ToInt32(reader.GetValue(5));
                    pNuevoInventario.Inv_Minimo = Convert.ToInt32(reader.GetValue(6));
                    pNuevoInventario.Precio_Compra = reader.GetDecimal(7);
                    pNuevoInventario.Fecha_Ingreso = Convert.ToDateTime(reader.GetValue(8));


                    lista.Add(pNuevoInventario);
                }
                Conexion.cerrarcon();
                return lista;
            }

        }
        public static DatosgetMateriaPrima ObtenerNuevoInventario(Int64 pId)
        {
            Conexion.opoencon();
            {
                DatosgetMateriaPrima pNuevoInventario = new DatosgetMateriaPrima();
                SqlCommand comando = new SqlCommand(String.Format(
                    "Select Nombre_Mercancia, Descripcion, Tipo_Producto, Unidad_Medida, Stock, Inv_Minimo, Precio_Compra, Fecha_Ingreso FROM NuevoInventario  where Codigo={0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pNuevoInventario.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pNuevoInventario.Nombre_Mercancia = reader.GetString(1);
                    pNuevoInventario.Descripcion = reader.GetString(2);
                    pNuevoInventario.Tipo_Producto = reader.GetString(3);
                    pNuevoInventario.Unidad_Medida = reader.GetString(4);
                    pNuevoInventario.Stock = Convert.ToInt32(reader.GetValue(5));
                    pNuevoInventario.Inv_Minimo = Convert.ToInt32(reader.GetValue(6));
                    pNuevoInventario.Precio_Compra = reader.GetDecimal(7);
                    pNuevoInventario.Fecha_Ingreso = Convert.ToDateTime(reader.GetValue(8));


                }
                Conexion.cerrarcon();
                return pNuevoInventario;
            }
        }
    }
}
