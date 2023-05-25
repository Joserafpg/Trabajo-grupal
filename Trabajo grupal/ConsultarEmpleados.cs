using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ConsultarEmpleados : Form
    {
        public ConsultarEmpleados()
        {
            InitializeComponent();
        }

        public DatosgetEmpleados EmpleadoSeleccionado { get; set; }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DatosbaseEmpleados.BuscarEmpleados(txtnombre.Text, txtcedula.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Int64 codigo = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                string codigoComoTexto = codigo.ToString();
                EmpleadoSeleccionado = DatosbaseEmpleados.ObtenerEmpleados(codigoComoTexto);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun on ha seleccionado nungun Alumno");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlantillaEmpleado form = new PlantillaEmpleado();
            ReportDocument oRep = new ReportDocument();
            oRep.Load(@"C:\Users\Jose\source\repos\Trabajo-grupal\Trabajo grupal\Reportes\Empleados.rpt");
            form.crystalReportViewer1.ReportSource = oRep;
            form.Show();

        }
    }
}
