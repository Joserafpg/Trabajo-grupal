using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            using (SqlConnection connection = new SqlConnection("Data source = DESKTOP-NDDA7LS; Initial Catalog = Proyecto_Grupal; Integrated Security = True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("VALORDEINVENTARIOPANTS", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            string resultado = dataTable.Rows[0][0].ToString();
                            txtvalor.Text = resultado;
                        }

                        else
                        {
                            // No se obtuvieron resultados
                            txtvalor.Text = "No se encontró resultado.";
                        }
                    }
                }
            }

            btnbuscar.PerformClick();
            datagrieldv.ReadOnly = true;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlantillaEmpleado form = new PlantillaEmpleado();
            ReportDocument oRep = new ReportDocument();
            oRep.Load(@"C:\Users\Jose\source\repos\Trabajo-grupal\Trabajo grupal\Reportes\CrystalReport1.rpt");
            form.crystalReportViewer1.ReportSource = oRep;
            form.Show();
        }
    }
}
