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
        public static int agregar(Datosget pget)
        {
            int retorno = 0;

            Conexion.opoencon();
            SqlCommand comando = new SqlCommand(string.Format(" insert into NuevoInventario (Codigo, Nombre_Mercancia, Descripcion, Tipo_Producto,Docenas, Unidad, Lotes, Cantidad, Inv_Minimo, Color_Producto, Precio_Compra) " +
                "values ('{0}','{1}','{2}','{3}','{4}', '{5}','{6}','{7}','{8}','{9}','{10}')",
                    pget.Codigo, pget.Nombre_Mercancia, pget.Descripcion, pget.Tipo_Producto, pget.Docenas, pget.Unidad, pget.Lotes, pget.Cantidad, pget.Inv_Minimo, pget.Color_Producto, pget.Precio_Compra), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;



        }
        public static int Modificar(Datosget pNuevoInventario)
        {

            int retorno = 0;
            Conexion.opoencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("Update NuevoInventario set Nombre_Mercancia ='{0}', Descripcion='{1}',Tipo_Producto='{2}',Docenas='{3}', Unidad='{4}',Lotes='{5}' ,Cantidad='{6}',Inv_Minimo='{7}', Color_Producto ='{8}', Precio_Compra ='{9}' where Codigo={10}",
                     pNuevoInventario.Codigo, pNuevoInventario.Nombre_Mercancia, pNuevoInventario.Descripcion, pNuevoInventario.Tipo_Producto, pNuevoInventario.Docenas, pNuevoInventario.Unidad, pNuevoInventario.Lotes, pNuevoInventario.Cantidad, pNuevoInventario.Inv_Minimo,
                     pNuevoInventario.Color_Producto, pNuevoInventario.Precio_Compra), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            Conexion.cerrarcon();
            return retorno;
        }
        public static int Eliminar(Int64 pId)
        {
            int retorno = 0;
            Conexion.opoencon();
            SqlCommand comando = new SqlCommand(string.Format("Delete  From NuevoInventario where Codigo={0}", pId), Conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;
        }

        public static List<Datosget> BuscarNuevoInventario(string pNombre_Mercancia, Int32 pCodigo)
        {
            List<Datosget> lista = new List<Datosget>();
            Conexion.opoencon();
            {

                SqlCommand comando = new SqlCommand(String.Format(
                    "SELECT  Nombre_Mercancia, Descripcion, Tipo_Producto,Docenas, Unidad, Lotes, Cantidad, Inv_Minimo, Color_Producto, Precio_Compra FROM NuevoInventario  where Codigo like '%{0}%'", pNombre_Mercancia, pCodigo), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Datosget pNuevoInventario = new Datosget();


                    pNuevoInventario.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pNuevoInventario.Nombre_Mercancia = reader.GetString(1);
                    pNuevoInventario.Descripcion = reader.GetString(2);
                    pNuevoInventario.Tipo_Producto = reader.GetString(3);
                    pNuevoInventario.Docenas = reader.GetBoolean(4);
                    pNuevoInventario.Unidad = reader.GetBoolean(5);
                    pNuevoInventario.Lotes = reader.GetBoolean(6);
                    pNuevoInventario.Cantidad = Convert.ToInt64(reader.GetValue(7));
                    pNuevoInventario.Inv_Minimo = Convert.ToInt64(reader.GetValue(8));
                    pNuevoInventario.Color_Producto = reader.GetString(9);
                    pNuevoInventario.Precio_Compra = reader.GetString(10);



                    lista.Add(pNuevoInventario);
                }
                Conexion.cerrarcon();
                return lista;
            }

        }
        public static Datosget ObtenerNuevoInventario(Int64 pId)
        {
            Conexion.opoencon();
            {
                Datosget pNuevoInventario = new Datosget();
                SqlCommand comando = new SqlCommand(String.Format(
                    "Select Nombre_Mercancia, Descripcion, Tipo_Producto, Docenas, Unidad, Lotes, Cantidad, Inv_Minimo, Color_Producto, Precio_Compra FROM NuevoInventario  where Codigo={0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pNuevoInventario.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pNuevoInventario.Nombre_Mercancia = reader.GetString(1);
                    pNuevoInventario.Descripcion = reader.GetString(2);
                    pNuevoInventario.Tipo_Producto = reader.GetString(3);
                    pNuevoInventario.Docenas = reader.GetBoolean(4);
                    pNuevoInventario.Unidad = reader.GetBoolean(5);
                    pNuevoInventario.Lotes = reader.GetBoolean(6);
                    pNuevoInventario.Cantidad = Convert.ToInt64(reader.GetValue(7));
                    pNuevoInventario.Inv_Minimo = Convert.ToInt64(reader.GetValue(8));
                    pNuevoInventario.Color_Producto = reader.GetString(9);
                    pNuevoInventario.Precio_Compra = reader.GetString(10);


                }
                Conexion.cerrarcon();
                return pNuevoInventario;
            }
        }
    }
}
