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
            SqlCommand comando = new SqlCommand(string.Format(" insert into NuevoInventario (Codigo, Nombre_Mercancia, Descripcion, Tipo_Producto, Cantidad, Inv_Minimo, Color_Producto, Precio_Compra, Precio_Venta, Precio_PorMayor) " +
                "values ('{0}','{1}','{2}','{3}','{4}', '{5}','{6}','{7}','{8}','{9}')",
                    pget.Codigo, pget.Nombre_Mercancia, pget.Descripcion, pget.Tipo_Producto, pget.Cantidad, pget.Inv_Minimo,pget.Color_Producto, pget.Precio_Compra, pget.Precio_Venta, pget.Precio_PorMayor), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;



        }
        public static int Modificar(Datosget pNuevoInventario)
        {

            int retorno = 0;
            Conexion.opoencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("Update NuevoInventario set Nombre_Mercancia ='{0}', Descripcion='{1}',Tipo_Producto='{2}', Cantidad='{3}',Inv_Minimo='{4}', Color_Producto ='{5}', Precio_Compra ='{6}', Precio_Venta ='{7}',Precio_PorMayor ='{8}' where Codigo={9}",
                     pNuevoInventario.Codigo, pNuevoInventario.Nombre_Mercancia, pNuevoInventario.Descripcion, pNuevoInventario.Tipo_Producto, pNuevoInventario.Cantidad, pNuevoInventario.Inv_Minimo,
                     pNuevoInventario.Color_Producto, pNuevoInventario.Precio_Compra, pNuevoInventario.Precio_Venta, pNuevoInventario.Precio_PorMayor), Conexion.ObtenerConexion());
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

        public static List<Datosget> BuscarNuevoInventario(string pNombre_Mercancia, Int16 Codigo) 
        {
            List<Datosget> lista = new List<Datosget>();
            Conexion.opoencon();
            {

                SqlCommand comando = new SqlCommand(String.Format(
                    "SELECT  Nombre_Mercancia, Descripcion, Tipo_Producto, Cantidad, Inv_Minimo, Color_Producto, Precio_Compra, Precio_Venta, Precio_PorMayor FROM NuevoInventario  where Codigo like '%{0}%'", pNombre_Mercancia, Codigo), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Datosget pNuevoInventario = new Datosget();
                    

                    pNuevoInventario.Codigo = reader.GetInt32(0);
                    pNuevoInventario.Nombre_Mercancia = reader.GetString(1);
                    pNuevoInventario.Descripcion = reader.GetString(2);
                    pNuevoInventario.Tipo_Producto = reader.GetString(3);
                    pNuevoInventario.Cantidad = reader.GetInt32(4);
                    pNuevoInventario.Inv_Minimo = reader.GetInt32(5);
                    pNuevoInventario.Color_Producto = reader.GetString(6);
                    pNuevoInventario.Precio_Compra = reader.GetString(7);
                    pNuevoInventario.Precio_Venta = reader.GetString(8);
                    pNuevoInventario.Precio_PorMayor = reader.GetString(9);


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
                    "Select Nombre_Mercancia, Descripcion, Tipo_Producto, Cantidad, Inv_Minimo, Color_Producto, Precio_Compra, Precio_Venta, Precio_PorMayor FROM NuevoInventario  where Codigo={0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pNuevoInventario.Codigo = reader.GetInt32(0);
                    pNuevoInventario.Nombre_Mercancia = reader.GetString(1);
                    pNuevoInventario.Descripcion = reader.GetString(2);
                    pNuevoInventario.Tipo_Producto = reader.GetString(3);
                    pNuevoInventario.Cantidad = reader.GetInt32(4);
                    pNuevoInventario.Inv_Minimo = reader.GetInt32(5);
                    pNuevoInventario.Color_Producto = reader.GetString(6);
                    pNuevoInventario.Precio_Compra = reader.GetString(7);
                    pNuevoInventario.Precio_Venta = reader.GetString(8);
                    pNuevoInventario.Precio_PorMayor = reader.GetString(9);

                }
                Conexion.cerrarcon();
                return pNuevoInventario;
            }

        }

    }
}
