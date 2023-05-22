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

namespace Trabajo_grupal
{
    public partial class InventarioPantalones : Form
    {
        public InventarioPantalones()
        {
            InitializeComponent();
        }

        void Next()
        {
            panelMateriaUtilizada.Visible = true;
        }

        private DataGridView _DTPantalones;
        public DataGridView DTPantalones { get => _DTPantalones; set => _DTPantalones = value; }
        
        public void DT_PANTALON()
        {
            _DTPantalones = dtgDatos;
        }

        public DatosgetInv InvPantalonActual { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosgetInv datosgetinv = new DatosgetInv();


            datosgetinv.Nombre_Producto = txtNombreProducto.Text;
            datosgetinv.Size = cbSize.Text;
            datosgetinv.Stock = Convert.ToInt32(txtstock.Text);
            datosgetinv.Inv_Minimo = txtinvminimo.Text;
            datosgetinv.Precio = Convert.ToDecimal(txtprecio.Text);
            

            DatosbaseInvPantalones.agregar(datosgetinv);

            txtidmateria.Visible = true;
            conn.Open();

            // Consultar el último registro de Id_Factura en FacturaTittle
            string query = "SELECT TOP 1 Codigo FROM InvPantalones ORDER BY Codigo DESC";
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
                    txtidmateria.Text = ultimoIdFactura.ToString();
                }

                else
                {
                    // No se encontraron registros en la tabla FacturaTittle
                    // Puedes mostrar un valor predeterminado o dejar el TextBox vacío
                    txtidmateria.Text = "No hay registros";
                }
            }

            conn.Close();
            button2.Visible = true;
            btnguardar.Visible = false;
            button2.PerformClick();
            button2.Visible = false;
            btnguardar.Visible = true;
            txtidmateria.Visible = false;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ConsultarInvPantalones pBuscar = new ConsultarInvPantalones();
            pBuscar.ShowDialog();

            if (pBuscar.InvPantalonSeleccionado != null)
            {
                InvPantalonActual = pBuscar.InvPantalonSeleccionado;
                txtNombreProducto.Text = pBuscar.InvPantalonSeleccionado.Nombre_Producto;
                cbSize.Text = pBuscar.InvPantalonSeleccionado.Size;
                txtstock.Text = pBuscar.InvPantalonSeleccionado.Stock.ToString();
                txtinvminimo.Text = pBuscar.InvPantalonSeleccionado.Inv_Minimo;
                txtprecio.Text = pBuscar.InvPantalonSeleccionado.Precio.ToString();
                


                btnguardar.Enabled = false;
                btnModificar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DatosgetInv pInventarioPantalon = new DatosgetInv();
          
            pInventarioPantalon.Nombre_Producto = txtNombreProducto.Text;
            pInventarioPantalon.Size = cbSize.Text;
            pInventarioPantalon.Stock = Convert.ToInt32(txtstock.Text);
            pInventarioPantalon.Inv_Minimo  = txtinvminimo.Text;
            pInventarioPantalon.Precio = Convert.ToDecimal(txtprecio.Text);
            pInventarioPantalon.Codigo = InvPantalonActual.Codigo;
            
        

            int Resultado = DatosbaseInvPantalones.Modificar(pInventarioPantalon);

            if (Resultado > 0)
            {
                MessageBox.Show("Pantalon Modificado Con Exito", "Pantalon Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btneliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnguardar.Enabled = true;
                btnClose.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se pudo Modificar el Pantalon", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void InventarioPantalones_Load(object sender, EventArgs e)
        {
            dtgDatos.AllowUserToAddRows = false;
            DT_PANTALON();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el pantalon??", "Esta Seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Int64 resultado = DatosbaseInvPantalones.Eliminar((int)InvPantalonActual.Codigo);
                if (resultado > 0)
                {
                    MessageBox.Show("Pantalon eliminado", "Pantalon Eliminado ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                    btneliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnguardar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("No se pudo eliminar el pantalon", "Pantalon eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }

        private void agregarmateriaprimamanual_Click(object sender, EventArgs e)
        {
            MateriaPantalonesNew frm = new MateriaPantalonesNew();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        SqlConnection conn = new SqlConnection("Data source = DESKTOP-NDDA7LS; Initial Catalog = Proyecto_Grupal; Integrated Security = True");

        private MateriaPrima ObtenerProducto(Int64 idMateria)
        {
            MateriaPrima materia = null;

            // Cadena de conexión a la base de datos
            string connectionString = "Data source = DESKTOP-NDDA7LS; Initial Catalog=Proyecto_Grupal; Integrated Security=True";

            // Consulta SQL para obtener el producto según su ID
            string query = "SELECT Codigo, Nombre_Mercancia, Descripcion, Unidad_Medida, Precio_Compra, Stock FROM NuevoInventario WHERE Codigo = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", idMateria);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener los valores del producto desde el lector de datos
                            Int32 id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string descripcion = reader.GetString(2);
                            string medida = reader.GetString(3);
                            decimal precio = reader.GetDecimal(4);

                            // Crear un objeto Producto con los valores obtenidos
                            materia = new MateriaPrima
                            {
                                Id = id,
                                Nombre = nombre,
                                Descripcion = descripcion,
                                Medida = medida,
                                Precio = precio
                            };
                        }
                    }
                }
                conn.Close();
            }

            return materia;

        }

        private void VerificarAgregarModificarProducto(MateriaPrima materia)
        {
            bool encontrado = false;

            // Recorrer las filas del DataGridView para buscar el producto
            foreach (DataGridViewRow row in dtgDatos.Rows)
            {
                // Obtener el ID del producto en la fila actual
                Int64 id = Convert.ToInt64(row.Cells["id"].Value);

                if (id == materia.Id)
                {
                    // El producto ya está en el DataGridView, modificar la cantidad
                    int cantidadExistente = Convert.ToInt32(row.Cells["cantidad"].Value);
                    int cantidadNueva = cantidadExistente + materia.Cantidad;
                    row.Cells["cantidad"].Value = cantidadNueva;

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                // El producto no está en el DataGridView, agregar una nueva fila
                dtgDatos.Rows.Add(materia.Id, materia.Nombre, materia.Descripcion, materia.Medida, materia.Precio, materia.Cantidad);
            }
        }

        public void SumarColumna()
        {
            double totalconsuma, Total = 0;

            foreach (DataGridViewRow row in dtgDatos.Rows)
            {
                Total += Convert.ToDouble(row.Cells["subtotal"].Value);
            }

            totalconsuma = Total + (Total * 0.20);

            txtprecio.Text = totalconsuma.ToString();

        }

        private void agregaraldtg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text))
            {
                MessageBox.Show("Debe colocar el ID del producto");
                return;
            }

            Int64 idProducto = Convert.ToInt64(txtcodigo.Text);

            // Llamar a un método para obtener el producto completo según su ID
            MateriaPrima materia = ObtenerProducto(idProducto);

            if (materia != null)
            {
                // Verificar si el producto ya está en el DataGridView y realizar la acción correspondiente
                VerificarAgregarModificarProducto(materia);

                foreach (DataGridViewRow row in dtgDatos.Rows)
                {
                    // Obtener los valores de las columnas "Columna1" y "Columna2"
                    double valor1 = Convert.ToDouble(row.Cells["precio"].Value);
                    int valor2 = Convert.ToInt32(row.Cells["cantidad"].Value);
                    // Realizar la multiplicación
                    double resultado = valor1 * valor2;

                    // Asignar el resultado a la columna "Resultado" de la fila actual
                    row.Cells["subtotal"].Value = resultado;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Next();
            btnguardar.Visible = true;
        }

        private void dtgDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgDatos.Rows)
            {
                // Obtener los valores de las columnas "Columna1" y "Columna2"
                double valor1 = Convert.ToDouble(row.Cells["precio"].Value);
                int valor2 = Convert.ToInt32(row.Cells["cantidad"].Value);
                // Realizar la multiplicación
                double resultado = valor1 * valor2;

                // Asignar el resultado a la columna "Resultado" de la fila actual
                row.Cells["subtotal"].Value = resultado;
                SumarColumna();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand agregar = new SqlCommand("INSERT INTO MercanciaUtilizada VALUES (@Id_Pantalon, @Id_Materiales, @Nombre, @Descripcion, @Medida, @Precio, @Cantidad, @SubTotal)", conn);
            string verificarQuery = "SELECT Stock FROM NuevoInventario WHERE Nombre_Mercancia = @Nombre";
            string actualizarQuery = "UPDATE NuevoInventario SET Stock = Stock - @Cantidad WHERE Nombre_Mercancia = @Nombre";

            conn.Open();

            try
            {
                foreach (DataGridViewRow row in dtgDatos.Rows)
                {
                    // Obtener los valores de la fila actual del DataGridView
                    Int64 idpantalon = Convert.ToInt64(txtidmateria.Text);
                    int id_materia = Convert.ToInt32(row.Cells["id"].Value);
                    string materia = Convert.ToString(row.Cells["nombre"].Value);
                    string descripcion = Convert.ToString(row.Cells["descripcion"].Value);
                    string medida = Convert.ToString(row.Cells["medida"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["subtotal"].Value);

                    // Verificar si el Stock es menor que la Cantidad
                    using (SqlCommand verificarCmd = new SqlCommand(verificarQuery, conn))
                    {
                        verificarCmd.Parameters.AddWithValue("@Nombre", materia);
                        int stock = Convert.ToInt32(verificarCmd.ExecuteScalar());

                        if (stock < cantidad)
                        {
                            MessageBox.Show("No hay suficiente stock para el producto " + materia);
                            return; // Salta a la siguiente iteración del bucle sin ejecutar el código restante
                        }
                    }

                    // Agregar los parámetros al comando
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@Id_Pantalon", idpantalon);
                    agregar.Parameters.AddWithValue("@Id_Materiales", id_materia);
                    agregar.Parameters.AddWithValue("@Nombre", materia);
                    agregar.Parameters.AddWithValue("@Descripcion", descripcion);
                    agregar.Parameters.AddWithValue("@Medida", medida);
                    agregar.Parameters.AddWithValue("@Precio", precio);
                    agregar.Parameters.AddWithValue("@Cantidad", cantidad);
                    agregar.Parameters.AddWithValue("@SubTotal", subtotal);

                    // Ejecutar el comando para agregar la factura
                    agregar.ExecuteNonQuery();

                    // Actualizar los datos de la tabla productos
                    using (SqlCommand actualizarCmd = new SqlCommand(actualizarQuery, conn))
                    {
                        actualizarCmd.Parameters.AddWithValue("@Nombre", materia);
                        actualizarCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        actualizarCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Facturado con exito");
                dtgDatos.Rows.Clear();
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
    }
}