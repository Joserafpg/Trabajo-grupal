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
            SqlCommand comando = new SqlCommand(string.Format(" insert into InvPantalones (Nombre_Producto, Size, Stock, Inv_Minimo, Mercancia_Utilizada, Precio) values ('{0}','{1}','{2}','{3}','{4}', '{5}')",
                pget.Nombre_Producto,  pget.Size, pget.Stock, pget.Inv_Minimo, pget.Mercancia_Utilizada, pget.Precio), Conexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;



        }
        public static int Modificar(DatosgetInv pInventarioPantalon)
        {

            int retorno = 0;
            Conexion.opoencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("Update InvPantalones set Nombre_Producto ='{0}', Size = '{1}', Stock = '{2}', Inv_Minimo = '{3}', Mercancia_Utilizada = '{4}', Precio = '{5}' where Codigo={6}",
                     pInventarioPantalon.Nombre_Producto,  pInventarioPantalon.Size, pInventarioPantalon.Stock, pInventarioPantalon.Inv_Minimo, pInventarioPantalon.Mercancia_Utilizada, pInventarioPantalon.Precio, pInventarioPantalon.Codigo), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            Conexion.cerrarcon();
            return retorno;
        }
        public static int Eliminar(int pId)
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
                    "SELECT  Codigo, Nombre_Producto, Size, Stock, Inv_Minimo, Mercancia_Utilizada, Precio FROM InvPantalones  where Codigo like '%{0}%'", pNombre_Producto, pCodigo), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DatosgetInv pInventarioPantalon = new DatosgetInv();


                    pInventarioPantalon.Codigo = reader.GetInt32(0);
                    pInventarioPantalon.Nombre_Producto = reader.GetString(1);
                    pInventarioPantalon.Size = reader.GetString(2);
                    pInventarioPantalon.Stock = reader.GetInt32(3);
                    pInventarioPantalon.Inv_Minimo = reader.GetString(4);
                    pInventarioPantalon.Mercancia_Utilizada = reader.GetString(5);
                    pInventarioPantalon.Precio = reader.GetDecimal(6);
                
                   



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
                    "Select Codigo, Nombre_Producto, Size, Stock, Inv_Minimo, Mercancia_Utilizada, Precio FROM InvPantalones where Codigo={0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pInventarioPantalon.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pInventarioPantalon.Nombre_Producto = reader.GetString(1);
                    pInventarioPantalon.Size = reader.GetString(2);
                    pInventarioPantalon.Stock = reader.GetInt32(3);
                    pInventarioPantalon.Inv_Minimo = reader.GetString(4);
                    pInventarioPantalon.Mercancia_Utilizada = reader.GetString(5);
                    pInventarioPantalon.Precio = reader.GetDecimal(6);
                    


                }
                Conexion.cerrarcon();
                return pInventarioPantalon;
            }
        }
    }
}
