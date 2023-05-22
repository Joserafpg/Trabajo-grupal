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
    public partial class BuscarClientes : Form
    {
        public BuscarClientes()
        {
            InitializeComponent();
        }

        public DatosgetClientes ClienteSeleccionado { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Int64 Codigo = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = DatosbaseCliente.ObtenerClientes(Codigo);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado ningun Cliente");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Int64 Codigo = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = DatosbaseCliente.ObtenerClientes(Codigo);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado nigun Alumno");
            }
        }
    }
}
