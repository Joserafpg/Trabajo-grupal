using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_grupal.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabajo_grupal
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent(); 
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
        }

        public void SumarColumna()
        {
            double Total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Total += Convert.ToDouble(row.Cells["Total"].Value);
            }
            txttotal.Text = Total.ToString();

        }

        void FacturarCredito()
        {
            pcredito.Visible = true;
        }
        void FacturarCreditoOFF()
        {
            pcredito.Visible = false;
        }

        void FacturarEfectivo()
        {
            PPago.Visible = true;
        }

        void FacturarEfectivoOFF()
        {
            PPago.Visible = false;
        }

        void Limpiar()
        {
            txtcodigo.Clear();
            txtdinero.Clear();
            txtcambio.ResetText();
            txttotal.Clear();
            dataGridView1.Rows.Clear();
            FacturarCreditoOFF();
            FacturarEfectivoOFF();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sub_Menú_Facturacion frm = new Sub_Menú_Facturacion();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No se ha agregado ningun produto para ser facturado.");
                return; // Salir del método sin ejecutar el código restante
            }

            FacturarEfectivo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoFacturaNew frm = new ProductoFacturaNew();
            frm.Show();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            PPago.Visible = false;
            pcredito.Visible = false;
            btnefectivo.Visible = false;

            btnfacturar.Enabled = Permisos.AgregarFACTURA;
            btndeshacer.Enabled = Permisos.AgregarFACTURA;
            btnagregarmanual.Enabled = Permisos.AgregarFACTURA;

            btnconsultar.Enabled = Permisos.ConsultarFACTURA;
            btnconsultar.Enabled = Permisos.ModificarFACTURA;
            btnconsultar.Enabled = Permisos.EliminarFACTURA;

            dataGridView1.AllowUserToAddRows = false;

        }

        private void txtdinero_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtdinero.Text, out int valorTextBox))
            {
                // Obtén el valor actual del Label y conviértelo en un número
                if (int.TryParse(txttotal.Text, out int valorLabel))
                {
                    // Resta el valor del TextBox del valor del Label
                    int resultado = valorTextBox - valorLabel;

                    // Actualiza el texto del Label con el nuevo valor
                    txtcambio.Text = resultado.ToString();
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            btncredito.Visible = true;
            btnefectivo.Visible = false;

        }

        private void btncredito_Click(object sender, EventArgs e)
        {
            FacturarCredito();
            btncredito.Visible = false;
            btnefectivo.Visible = true;
        }

        private void btnefectivo_Click(object sender, EventArgs e)
        {
            FacturarCreditoOFF();
            btncredito.Visible = true;
            btnefectivo.Visible = false;
        }

        SqlConnection conn = new SqlConnection("Data source = DESKTOP-NDDA7LS; Initial Catalog = Practica_Grupal; Integrated Security = True");

        private Pantalones ObtenerProducto(Int64 idProducto)
        {
            Pantalones producto = null;

            // Cadena de conexión a la base de datos
            string connectionString = "Data source = DESKTOP-NDDA7LS; Initial Catalog=Proyecto_Grupal; Integrated Security=True";

            // Consulta SQL para obtener el producto según su ID
            string query = "SELECT Codigo, Nombre_Producto, Size, Precio FROM InvPantalones WHERE Codigo = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", idProducto);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener los valores del producto desde el lector de datos
                            Int32 id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string size = reader.GetString(2);
                            decimal precio = reader.GetDecimal(3);

                            // Crear un objeto Producto con los valores obtenidos
                            producto = new Pantalones
                            {
                                Id = id,
                                Nombre_Producto = nombre,
                                Size = size,
                                Precio = precio
                            };
                        }
                    }
                }
                conn.Close();
            }

            return producto;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text))
            {
                MessageBox.Show("Debe colocar el ID del producto");
                return;
            }

            Int64 idProducto = Convert.ToInt64(txtcodigo.Text);

            // Llamar a un método para obtener el producto completo según su ID
            Pantalones producto = ObtenerProducto(idProducto);

            // Verificar si se encontró un producto con el ID especificado
            if (producto != null)
            {
                // Agregar una nueva fila al DataTable con los datos del producto
                dataGridView1.Rows.Add(producto.Id, producto.Nombre_Producto, producto.Size, producto.Precio, producto.Cantidad);
            }
            else
            {
                // No se encontró un producto con el ID especificado, mostrar un mensaje de error o realizar alguna otra acción apropiada
                MessageBox.Show("No se encontró ningún producto con el ID especificado.");
            }

            txtcodigo.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No se ha agregado ningun produto para ser facturado.");
                return; // Salir del método sin ejecutar el código restante
            }

            SqlCommand agregar = new SqlCommand("INSERT INTO Factura VALUES (@Codigo, @Nombre_Producto, @Size, @Precio, @Stock)", conn);
            string verificarQuery = "SELECT Stock FROM InvPantalones WHERE Nombre_Producto = @Producto";
            string actualizarQuery = "UPDATE InvPantalones SET Stock = Stock - @Stock WHERE Nombre_Producto = @d|Producto";

            conn.Open();

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Obtener los valores de la fila actual del DataGridView
                    int id_producto = Convert.ToInt32(row.Cells["codigos"].Value);
                    string producto = Convert.ToString(row.Cells["productos"].Value);
                    string size = Convert.ToString(row.Cells["size"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["precios"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                    decimal total = Convert.ToDecimal(row.Cells["Total"].Value);

                    // Verificar si el Stock es menor que la Cantidad
                    using (SqlCommand verificarCmd = new SqlCommand(verificarQuery, conn))
                    {
                        verificarCmd.Parameters.AddWithValue("@Nombre_Producto", producto);
                        int stock = Convert.ToInt32(verificarCmd.ExecuteScalar());

                        if (stock < cantidad)
                        {
                            MessageBox.Show("No hay suficiente stock para el producto " + producto);
                            return; // Salta a la siguiente iteración del bucle sin ejecutar el código restante
                        }
                    }

                    // Agregar los parámetros al comando
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@Codigo", id_producto);
                    agregar.Parameters.AddWithValue("@Nombre_Producto", producto);
                    agregar.Parameters.AddWithValue("@Size", size);
                    agregar.Parameters.AddWithValue("@Precio", precio);
                    agregar.Parameters.AddWithValue("@Cantidad", cantidad);
                    agregar.Parameters.AddWithValue("@Total", total);

                    // Ejecutar el comando para agregar la factura
                    agregar.ExecuteNonQuery();

                    // Actualizar los datos de la tabla productos
                    using (SqlCommand actualizarCmd = new SqlCommand(actualizarQuery, conn))
                    {
                        actualizarCmd.Parameters.AddWithValue("@Nombre_Producto", producto);
                        actualizarCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        actualizarCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Facturado con exito");
                dataGridView1.Rows.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Obtener los valores de las columnas "Columna1" y "Columna2"
                double valor1 = Convert.ToDouble(row.Cells["precios"].Value);
                int valor2 = Convert.ToInt32(row.Cells["cantidad"].Value);
                // Realizar la multiplicación
                double resultado = valor1 * valor2;

                // Asignar el resultado a la columna "Resultado" de la fila actual
                row.Cells["Total"].Value = resultado;
                SumarColumna();
            }
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            txtdinero.Text = txttotal.Text;
        }
    }
}
