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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            NuevoInventario frm = new NuevoInventario();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ModificarInventario frm = new ModificarInventario();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductosBajoInventario frm = new ProductosBajoInventario();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarInventario frm = new EliminarInventario();
            frm.Show();
        }

        private void Ajustes_Click(object sender, EventArgs e)
        {
            
        }
    }
}
