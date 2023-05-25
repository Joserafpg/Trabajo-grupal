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
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Trabajo_grupal
{
    public partial class ConsultarMateriaPrima : Form
    {
        public ConsultarMateriaPrima()
        {
            InitializeComponent();
        }
        public DatosgetMateriaPrima MateriaPrimaSeleccionada { get; set; }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (datagrieldv.SelectedRows.Count == 1)
            {
                Int64 Codigo = Convert.ToInt64(datagrieldv.CurrentRow.Cells[0].Value);
                MateriaPrimaSeleccionada = Datosbasedt.ObtenerNuevoInventario(Codigo);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado ninguna Materia Prima");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            datagrieldv.DataSource = Datosbasedt.BuscarNuevoInventario(txtNombre.Text, txtcodigo.Text);
        }

        private void ConsultarMateriaPrima_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data source = DESKTOP-NDDA7LS; Initial Catalog = Proyecto_Grupal; Integrated Security = True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("VALORDEMATERIAPRIMA", connection))
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
            datagrieldv.AllowUserToAddRows = false;
            datagrieldv.ReadOnly = true;
        }


        private void btnimprimir_Click(object sender, EventArgs e)
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
            oRep.Load(@"C:\Users\Jose\source\repos\Trabajo-grupal\Trabajo grupal\Reportes\MateriaPrima.rpt");
            form.crystalReportViewer1.ReportSource = oRep;
            form.Show();
        }
    }
}
