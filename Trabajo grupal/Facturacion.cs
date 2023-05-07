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
            
        }
        
        void FacturarEfectivo()
        {
            PPago.Visible = true;
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
            frm.ShowDialog();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            PPago.Visible = false;

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
    }
}
