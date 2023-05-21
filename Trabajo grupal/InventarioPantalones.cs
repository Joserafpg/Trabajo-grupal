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


            datosgetinv.Nombre_Producto = txtNombreProducto.Text;
            datosgetinv.Size = cbSize.Text;
            datosgetinv.Stock = Convert.ToInt32(txtstock.Text);
            datosgetinv.Inv_Minimo = txtinvminimo.Text;
            datosgetinv.Mercancia_Utilizada = txtMercanciaUtilizada.Text;
            datosgetinv.Precio = Convert.ToDecimal(txtprecio.Text);
            

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
                cbSize.Text = pBuscar.InvPantalonSeleccionado.Size;
                txtstock.Text = pBuscar.InvPantalonSeleccionado.Stock.ToString();
                txtinvminimo.Text = pBuscar.InvPantalonSeleccionado.Inv_Minimo;
                txtMercanciaUtilizada.Text = pBuscar.InvPantalonSeleccionado.Mercancia_Utilizada;
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
            pInventarioPantalon.Mercancia_Utilizada = txtMercanciaUtilizada.Text;
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
    }
}
