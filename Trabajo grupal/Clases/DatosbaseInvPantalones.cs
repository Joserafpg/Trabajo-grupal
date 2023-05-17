using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal.Clases
{
    public class DatosbaseInvPantalones
    {
        public static int agregar(DatosgetInv pget)
        {
            int retorno = 0;

            Conexion.opoencon();
            SqlCommand comando = new SqlCommand(string.Format(" insert into InvPantalones (Codigo, Nombre_Producto, Descripcion, Size, Cantidad, Inv_Minimo, Mercancia_Utilizada, Precio_Venta, Precio_PorMayor) " +
                "values ('{0}','{1}','{2}','{3}','{4}', '{5}','{6}','{7}','{8}')",
                    pget.Codigo, pget.Nombre_Producto, pget.Descripcion, pget.Size, pget.Cantidad, pget.Inv_Minimo, pget.Mercancia_Utilizada, pget.Precio_Venta, pget.Precio_PorMayor), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;



        }
        public static int Modificar(DatosgetInv pInventarioPantalon)
        {

            int retorno = 0;
            Conexion.opoencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("Update InvPantalones set Nombre_Producto ='{0}', Descripcion='{1}',Size='{2}',Cantidad='{3}', Inv_Minimo='{4}', Mercancia_Utilizada='{5}' ,Precio_Venta='{6}',Precio_PorMayor='{7}' where Codigo={8}",
                     pInventarioPantalon.Codigo, pInventarioPantalon.Nombre_Producto, pInventarioPantalon.Descripcion, pInventarioPantalon.Size, pInventarioPantalon.Cantidad, pInventarioPantalon.Inv_Minimo, pInventarioPantalon.Mercancia_Utilizada, pInventarioPantalon.Precio_Venta, pInventarioPantalon.Precio_PorMayor
                     ), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            Conexion.cerrarcon();
            return retorno;
        }
        public static int Eliminar(string pId)
        {
            int retorno = 0;
            Conexion.opoencon();
            SqlCommand comando = new SqlCommand(string.Format("Delete  From InvPantalones where Codigo={0}", pId), Conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;
        }

        public static List<DatosgetInv> BuscarInventarioPantalones(string pNombre_Producto, string pCodigo)
        {
            List<DatosgetInv> lista = new List<DatosgetInv>();
            Conexion.opoencon();
            {

                SqlCommand comando = new SqlCommand(String.Format(
                    "SELECT  Codigo, Nombre_Producto, Descripcion, Size, Cantidad, Inv_Minimo, Mercancia_Utilizada, Precio_Venta, Precio_PorMayor FROM InvPantalones  where Codigo like '%{0}%'", pNombre_Producto, pCodigo), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DatosgetInv pInventarioPantalon = new DatosgetInv();


                    pInventarioPantalon.Codigo = reader.GetString(0);
                    pInventarioPantalon.Nombre_Producto = reader.GetString(1);
                    pInventarioPantalon.Descripcion = reader.GetString(2);
                    pInventarioPantalon.Size = reader.GetString(3);
                    pInventarioPantalon.Cantidad = reader.GetString(4);
                    pInventarioPantalon.Inv_Minimo = reader.GetString(5);
                    pInventarioPantalon.Mercancia_Utilizada = reader.GetString(6);
                    pInventarioPantalon.Precio_Venta = reader.GetString(7);
                    pInventarioPantalon.Precio_PorMayor= reader.GetString(8);
                   



                    lista.Add(pInventarioPantalon);
                }
                Conexion.cerrarcon();
                return lista;
            }

        }
        public static DatosgetInv ObtenerInvPantalones(Int64 pId)
        {
            Conexion.opoencon();
            {
                DatosgetInv pInventarioPantalon= new DatosgetInv();
                SqlCommand comando = new SqlCommand(String.Format(
                    "Select Nombre_Producto, Descripcion, Size, Cantidad, Inv_Minimo, Mercancia_Utilizada, Precio_Venta, Precio_PorMayor FROM InvPantalones  where Codigo={0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pInventarioPantalon.Codigo = reader.GetString(0);
                    pInventarioPantalon.Nombre_Producto = reader.GetString(1);
                    pInventarioPantalon.Descripcion = reader.GetString(2);
                    pInventarioPantalon.Size = reader.GetString(3);
                    pInventarioPantalon.Cantidad = reader.GetString(4);
                    pInventarioPantalon.Inv_Minimo = reader.GetString(5);
                    pInventarioPantalon.Mercancia_Utilizada = reader.GetString(6);
                    pInventarioPantalon.Precio_Venta = reader.GetString(7);
                    pInventarioPantalon.Precio_PorMayor = reader.GetString(8);


                }
                Conexion.cerrarcon();
                return pInventarioPantalon;
            }
        }
    }
}
