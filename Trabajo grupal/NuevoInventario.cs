using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Trabajo_grupal.Clases;

namespace Trabajo_grupal
{
    public partial class NuevoInventario : Form
    {
        public NuevoInventario()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NuevoInventario_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpreciocompra.Clear();
            txtcantidad.Clear();
            txtcodigo.Clear();
            CBNom.Refresh();
            CBcolor.Refresh();
            CBtipodep.Refresh();
            txtDescripcion.Refresh();
            txtInvMinimo.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datosget datosget = new Datosget();


   

            datosget.Codigo = txtcodigo.Text;
            datosget.Nombre_Mercancia = CBNom.Text;
            datosget.Descripcion = txtDescripcion.Text;
            datosget.Tipo_Producto = CBtipodep.Text;
            datosget.Docenas = chDocenas.Text;
            datosget.Unidad = chUnidad.Text;
            datosget.Lotes = chlotes.Text;
            datosget.Cantidad = txtcantidad.Text;
            datosget.Inv_Minimo = txtInvMinimo.Text;  
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
