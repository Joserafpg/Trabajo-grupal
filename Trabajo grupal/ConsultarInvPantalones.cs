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
    public partial class ConsultarInvPantalones : Form
    {
        public ConsultarInvPantalones()
        {
            InitializeComponent();
        }
        public DatosgetInv InvPantalonSeleccionado { get; set; }
        private void ConsultarInvPantalones_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            datagrieldv.DataSource = DatosbaseInvPantalones.BuscarInventarioPantalones(txtCodigo.Text , txtnomb.Text);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (datagrieldv.SelectedRows.Count == 1)
            {
                Int64 Codigo = Convert.ToInt64(datagrieldv.CurrentRow.Cells[0].Value);
                InvPantalonSeleccionado = DatosbaseInvPantalones.ObtenerInvPantalones(Codigo);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado nigun Alumno");
            }
        }

        private void ReporteInvPantalones1_InitReport(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
