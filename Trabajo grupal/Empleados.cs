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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            txtnombre.Clear();
            txtdireccion.Clear();
        }

        void RejuegoON()
        {
            panelsueldo.Visible = true;
            btnsiguiente.Visible = false;
            btnagregar.Visible = true;
        }
        void RejuegoOFF()
        {
            panelsueldo.Visible = false;
            btnsiguiente.Visible = true;
            btnagregar.Visible = false;
            Limpiar();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            btnagregar.Visible = false;
            panelsueldo.Visible = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtcedula.Text) || string.IsNullOrEmpty(txtdireccion.Text) || string.IsNullOrEmpty(txTelefono.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtsueldo.Text) || string.IsNullOrEmpty(txtsfs.Text) || string.IsNullOrEmpty(txtafp.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos antes de guardar los datos", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DatosgetEmpleados pEmpleados = new DatosgetEmpleados();
                pEmpleados.Nombre = txtnombre.Text;
                pEmpleados.Cedula = txtcedula.Text;
                pEmpleados.Telefono = txTelefono.Text;
                pEmpleados.Direccion = txtdireccion.Text;
                pEmpleados.Correo = txtCorreo.Text;
                pEmpleados.Fecha_Nac = txtfech.Value;
                pEmpleados.Fecha_Ingreso = dtpingreso.Value;
                pEmpleados.Sueldo = txtsueldo.Text;
                pEmpleados.SFS = txtsfs.Text;
                pEmpleados.AFP = txtafp.Text;
                pEmpleados.Puesto = cPuesto.Text;

                int resultado = DatosbaseEmpleados.Agregar(pEmpleados);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("No se pudieron guardar los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Limpiar();
                RejuegoOFF();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtsueldo.Text, out double numero))
            {
                double resultado = numero * 0.0287;

                txtafp.Text = resultado.ToString();
            }

            if (double.TryParse(txtsueldo.Text, out double numero2))
            {
                double resultado2 = numero2 * 0.0304;

                txtsfs.Text = resultado2.ToString();
            }
            else
            {
                txtsfs.Clear();
                txtafp.Clear();
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtcedula.Text) || string.IsNullOrEmpty(txtdireccion.Text) || string.IsNullOrEmpty(txTelefono.Text) || string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos antes del siguiente paso", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RejuegoON();
            }
        }
    }
}
