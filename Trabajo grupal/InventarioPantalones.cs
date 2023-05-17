using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public DatosgetInv InvPantalonActual { get; set; }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatosgetInv datosgetinv = new DatosgetInv();


            datosgetinv.Codigo = txtboxcodigo.Text;
            datosgetinv.Nombre_Producto = txtNombreProducto.Text;
            datosgetinv.Descripcion = txtdescripcion.Text;
            datosgetinv.Size = cbSize.Text;
            datosgetinv.Cantidad = txtcantidad.Text;
            datosgetinv.Inv_Minimo = txtinvminimo.Text;
            datosgetinv.Mercancia_Utilizada = txtMercanciaUtilizada.Text;
            datosgetinv.Precio_Venta = txtprecioventa.Text;
            datosgetinv.Precio_PorMayor = txtpreciopormayor.Text;

            int resultado = DatosbaseInvPantalones.agregar(datosgetinv);


            if (resultado > 0)
            {

                MessageBox.Show("Datos del Pantalon Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show(" No se Pudieron Guardar Datos del Pantalon ", "Error al Guardar ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ConsultarInvPantalones pBuscar = new ConsultarInvPantalones();
            pBuscar.ShowDialog();

            if (pBuscar.InvPantalonSeleccionado != null)
            {
                InvPantalonActual = pBuscar.InvPantalonSeleccionado;
                txtNombreProducto.Text = pBuscar.InvPantalonSeleccionado.Nombre_Producto;
                txtdescripcion.Text = pBuscar.InvPantalonSeleccionado.Descripcion;
                cbSize.Text = pBuscar.InvPantalonSeleccionado.Size;
                txtcantidad.Text = pBuscar.InvPantalonSeleccionado.Cantidad;
                txtinvminimo.Text = pBuscar.InvPantalonSeleccionado.Inv_Minimo;
                txtMercanciaUtilizada.Text = pBuscar.InvPantalonSeleccionado.Mercancia_Utilizada;
                txtprecioventa.Text = pBuscar.InvPantalonSeleccionado.Precio_Venta;
                txtpreciopormayor.Text = pBuscar.InvPantalonSeleccionado.Precio_PorMayor;


                btnguardar.Enabled = false;
                btnModificar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DatosgetInv pInventarioPantalon = new DatosgetInv();


            pInventarioPantalon.Codigo = InvPantalonActual.Codigo;
            pInventarioPantalon.Nombre_Producto = txtNombreProducto.Text;
            pInventarioPantalon.Descripcion = txtdescripcion.Text;
            pInventarioPantalon. Size = cbSize.Text;
            pInventarioPantalon.Cantidad = txtcantidad.Text;
            pInventarioPantalon.Inv_Minimo  = txtinvminimo.Text;
            pInventarioPantalon.Mercancia_Utilizada = txtMercanciaUtilizada.Text;
            pInventarioPantalon.Precio_Venta = txtprecioventa.Text;
            pInventarioPantalon.Precio_PorMayor = txtpreciopormayor.Text;
            
        

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

        }
    }
}
