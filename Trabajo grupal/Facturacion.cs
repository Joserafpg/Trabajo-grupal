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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Trabajo_grupal
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
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
            txttotal.ResetText();
            dataGridView1.Rows.Clear();
            dtpFecha.ResetText();
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

        private DataGridView _DTPantalones;
        public DataGridView DTPantalones { get => _DTPantalones; set => _DTPantalones = value; }
        
        public void DT_PANTALON()
        {
            _DTPantalones = dataGridView1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductoFacturaNew frm = new ProductoFacturaNew();
            AddOwnedForm(frm);
            frm.ShowDialog();
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
            DT_PANTALON();

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

        SqlConnection conn = new SqlConnection("Data source = DESKTOP-NDDA7LS; Initial Catalog = Proyecto_Grupal; Integrated Security = True");
       
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

        private void VerificarAgregarModificarProducto(Pantalones producto)
        {
            bool encontrado = false;

            // Recorrer las filas del DataGridView para buscar el producto
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Obtener el ID del producto en la fila actual
                Int64 id = Convert.ToInt64(row.Cells["codigos"].Value);

                if (id == producto.Id)
                {
                    // El producto ya está en el DataGridView, modificar la cantidad
                    int cantidadExistente = Convert.ToInt32(row.Cells["cantidad"].Value);
                    int cantidadNueva = cantidadExistente + producto.Cantidad;
                    row.Cells["cantidad"].Value = cantidadNueva;

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                // El producto no está en el DataGridView, agregar una nueva fila
                dataGridView1.Rows.Add(producto.Id, producto.Nombre_Producto, producto.Size, producto.Precio, producto.Cantidad);
            }
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

            if (producto != null)
            {
                // Verificar si el producto ya está en el DataGridView y realizar la acción correspondiente
                VerificarAgregarModificarProducto(producto);

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
            else
            {
                // No se encontró un producto con el ID especificado, mostrar un mensaje de error o realizar alguna otra acción apropiada
                MessageBox.Show("No se encontró ningún producto con el ID especificado.");
            }


            txtcodigo.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand agregar = new SqlCommand("INSERT INTO Factura VALUES (@No_Factura , @Codigo, @Producto, @Size, @Precio, @Cantidad, @Total)", conn);
            string verificarQuery = "SELECT Stock FROM InvPantalones WHERE Nombre_Producto = @Producto";
            string actualizarQuery = "UPDATE InvPantalones SET Stock = Stock - @Cantidad WHERE Nombre_Producto = @Producto";

            conn.Open();

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Obtener los valores de la fila actual del DataGridView
                    Int64 idfactura = Convert.ToInt64(txtidfactura.Text);
                    int id_producto = Convert.ToInt32(row.Cells["codigos"].Value);
                    string producto = Convert.ToString(row.Cells["producto"].Value);
                    string size = Convert.ToString(row.Cells["size"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["precios"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                    decimal total = Convert.ToDecimal(row.Cells["Total"].Value);

                    // Verificar si el Stock es menor que la Cantidad
                    using (SqlCommand verificarCmd = new SqlCommand(verificarQuery, conn))
                    {
                        verificarCmd.Parameters.AddWithValue("@Producto", producto);
                        int stock = Convert.ToInt32(verificarCmd.ExecuteScalar());

                        if (stock < cantidad)
                        {
                            MessageBox.Show("No hay suficiente stock para el producto " + producto);
                            FacturarEfectivoOFF();
                            FacturarCreditoOFF();
                            return; // Salta a la siguiente iteración del bucle sin ejecutar el código restante
                        }
                    }

                    // Agregar los parámetros al comando
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@No_Factura", idfactura);
                    agregar.Parameters.AddWithValue("@Codigo", id_producto);
                    agregar.Parameters.AddWithValue("@Producto", producto);
                    agregar.Parameters.AddWithValue("@Size", size);
                    agregar.Parameters.AddWithValue("@Precio", precio);
                    agregar.Parameters.AddWithValue("@Cantidad", cantidad);
                    agregar.Parameters.AddWithValue("@Total", total);

                    // Ejecutar el comando para agregar la factura
                    agregar.ExecuteNonQuery();

                    // Actualizar los datos de la tabla productos
                    using (SqlCommand actualizarCmd = new SqlCommand(actualizarQuery, conn))
                    {
                        actualizarCmd.Parameters.AddWithValue("@Producto", producto);
                        actualizarCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        actualizarCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Facturado con exito");
                dataGridView1.Rows.Clear();
                Limpiar();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

            finally
            {
                conn.Close();
            }

            PlantillaFactura form = new PlantillaFactura();
            ReportDocument oRep = new ReportDocument();
            ParameterField pf = new ParameterField();
            ParameterFields pfs = new ParameterFields();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pf.Name = "@numFact";
            txtidfactura.Visible = true;
            pdv.Value = txtidfactura.Text;
            txtidfactura.Visible = false;
            pf.CurrentValues.Add(pdv);
            pfs.Add(pf);
            form.crystalReportViewer1.ParameterFieldInfo = pfs;
            oRep.Load(@"C:\Users\Jose\source\repos\Trabajo-grupal\Trabajo grupal\Reportes\Factura.rpt");
            form.crystalReportViewer1.ReportSource = oRep;
            form.Show();
            oRep.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\Jose\source\repos\Trabajo-grupal\Trabajo grupal\Reportes PDF\Factura.pdf");
        }

        

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            txtdinero.Text = txttotal.Text;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            Datosgetfactura pFactura = new Datosgetfactura();
            pFactura.Empleado = cempleado.Text;
            pFactura.Cliente = ccliente.Text;
            pFactura.Fecha = dtpFecha.Value;
            pFactura.Total = Convert.ToDecimal(txttotal.Text);

            DatosbaseFactura.Agregar(pFactura);

            txtidfactura.Visible = true;
            conn.Open();

            // Consultar el último registro de Id_Factura en FacturaTittle
            string query = "SELECT TOP 1 Id_Factura FROM FacturaTittle ORDER BY Id_Factura DESC";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                // Obtener el resultado de la consulta
                object result = command.ExecuteScalar();

                // Verificar si se obtuvo un resultado válido
                if (result != null && result != DBNull.Value)
                {
                    // Convertir el resultado en un entero
                    int ultimoIdFactura = Convert.ToInt32(result);

                    // Mostrar el último Id_Factura en un TextBox
                    txtidfactura.Text = ultimoIdFactura.ToString();
                }

                else
                {
                    // No se encontraron registros en la tabla FacturaTittle
                    // Puedes mostrar un valor predeterminado o dejar el TextBox vacío
                    txtidfactura.Text = "No hay registros";
                }
            }

            conn.Close();
            button1.Visible = true;
            button4.Visible = false;
            button1.PerformClick();
            button1.Visible = false;
            button4.Visible = true;
            txtidfactura.Visible = false;
        }

        private void btndeshacer_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}