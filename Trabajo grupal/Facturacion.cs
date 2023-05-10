using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabajo_grupal
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
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
    }
}
