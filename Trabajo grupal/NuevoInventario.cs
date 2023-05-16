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
        public Datosget MateriaPrimaActual { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Datosget datosget = new Datosget();


            datosget.Codigo = Convert.ToInt64(txtcodigo.Text);
            datosget.Nombre_Mercancia = CBNom.Text;
            datosget.Descripcion = txtDescripcion.Text;
            datosget.Tipo_Producto = CBtipodep.Text;
            datosget.Docenas = chDocenas.Checked;
            datosget.Unidad = chUnidad.Checked;
            datosget.Lotes = chlotes.Checked;
            datosget.Cantidad = Convert.ToInt64(txtcantidad.Text);
            datosget.Inv_Minimo = Convert.ToInt64(txtInvMinimo.Text);
            datosget.Color_Producto = CBcolor.Text;
            datosget.Precio_Compra = txtpreciocompra.Text;

            int resultado = Datosbasedt.agregar(datosget);


            if (resultado > 0)
            {

                MessageBox.Show("Datos de Materia Prima Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show(" No se Pudieron Guardar Datos de Materia Prima  ", "Error al Guardar ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ConsultarMateriaPrima pBuscar = new ConsultarMateriaPrima();
            pBuscar.ShowDialog();

            if (pBuscar.MateriaPrimaSeleccionada != null)
            {
                MateriaPrimaActual = pBuscar.MateriaPrimaSeleccionada;
                CBNom.Text = pBuscar.MateriaPrimaSeleccionada.Nombre_Mercancia;
                txtDescripcion.Text = pBuscar.MateriaPrimaSeleccionada.Descripcion;
                CBtipodep.Text = pBuscar.MateriaPrimaSeleccionada.Tipo_Producto;
                chDocenas.Checked = pBuscar.MateriaPrimaSeleccionada.Docenas;
                chUnidad.Checked = pBuscar.MateriaPrimaSeleccionada.Unidad;
                chlotes.Checked = pBuscar.MateriaPrimaSeleccionada.Lotes;
             
                CBcolor.Text = pBuscar.MateriaPrimaSeleccionada.Color_Producto;
                txtpreciocompra.Text = pBuscar.MateriaPrimaSeleccionada.Precio_Compra;


                btnguardar.Enabled = false;
                btnmodificar.Enabled = true;
                btndeshacer.Enabled = true;
            }


        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Datosget pNuevaMercancia = new Datosget();


            pNuevaMercancia.Codigo = Convert.ToInt64(txtcodigo.Text);
            pNuevaMercancia.Nombre_Mercancia = CBNom.Text;
            pNuevaMercancia.Descripcion = txtDescripcion.Text;
            pNuevaMercancia.Tipo_Producto = CBtipodep.Text;
            pNuevaMercancia.Docenas = chDocenas.Checked;
            pNuevaMercancia.Unidad = chUnidad.Checked;
            pNuevaMercancia.Lotes = chlotes.Checked;
            pNuevaMercancia.Cantidad = Convert.ToInt64(txtcantidad.Text);
            pNuevaMercancia.Inv_Minimo = Convert.ToInt64(txtInvMinimo.Text);
            pNuevaMercancia.Color_Producto = CBcolor.Text;
            pNuevaMercancia.Precio_Compra = txtpreciocompra.Text;

            int Resultado = Datosbasedt.Modificar(pNuevaMercancia);

            if (Resultado > 0)
            {
                MessageBox.Show("Materia Prima Modificada Con Exito","Materia Prima Modificada" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                btndeshacer.Enabled = false;
                btnmodificar.Enabled = false;
                btnguardar.Enabled = true;
                btnClose.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se pudo Modificadar la Materia Prima", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
