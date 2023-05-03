using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_grupal
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sub_Menú_Facturacion frm = new Sub_Menú_Facturacion();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMetodo frm = new FormMetodo();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoFacturaNew frm = new ProductoFacturaNew();
            frm.ShowDialog();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            btnfacturar.Enabled = Permisos.AgregarFACTURA;
            btndeshacer.Enabled = Permisos.AgregarFACTURA;
            btnagregarmanual.Enabled = Permisos.AgregarFACTURA;
        }
    }
}
