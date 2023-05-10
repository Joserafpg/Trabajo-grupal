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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxcodigo.Clear();
            txtNombreProducto.Clear();
            txtdescripcion.Clear();
            txtcantidad.Clear();
            txtinvminimo.Clear();
            txtMercanciaUtilizada.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            datosget.Codigo = txtboxcodigo.Text;
            datosget.Nombre_Producto = txtNombreProducto.Text;
            datosget.Descripcion = txtdescripcion.Text; 
            datosget.Cantidad = txtcantidad.Text;
            datosget.Inv_Minimo = txtInvMinimo.Text;
            Datosget.
            datosget.Color_Producto = CBcolor.Text;
            datosget.Precio_Compra = txtpreciocompra.Text;

            int resultado = Datosbasedt.agregar(datosget);


            if (resultado > 0)
            {

                MessageBox.Show("Datos de Materia Prima Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show(" No se Pudieron Guardar Datos de Materia Prima ", "Error al Guardar ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
