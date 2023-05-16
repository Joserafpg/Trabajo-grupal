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

        public DatosgetEmpleados EmpleadoActual { get; set; }

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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ConsultarEmpleados pBuscar = new ConsultarEmpleados();
            pBuscar.ShowDialog();
            if (pBuscar.EmpleadoSeleccionado != null)
            {
                EmpleadoActual = pBuscar.EmpleadoSeleccionado;
                txtnombre.Text = pBuscar.EmpleadoSeleccionado.Nombre;
                txtcedula.Text = pBuscar.EmpleadoSeleccionado.Cedula;
                txtdireccion.Text = pBuscar.EmpleadoSeleccionado.Direccion;
                txTelefono.Text = pBuscar.EmpleadoSeleccionado.Telefono;
                txtCorreo.Text = pBuscar.EmpleadoSeleccionado.Correo;
                txtfech.Value = pBuscar.EmpleadoSeleccionado.Fecha_Nac;
                dtpingreso.Value = pBuscar.EmpleadoSeleccionado.Fecha_Ingreso;
                txtsueldo.Text = pBuscar.EmpleadoSeleccionado.Sueldo;
                txtsfs.Text = pBuscar.EmpleadoSeleccionado.SFS;
                txtafp.Text = pBuscar.EmpleadoSeleccionado.AFP;
                cPuesto.Text = pBuscar.EmpleadoSeleccionado.Puesto;

                btnagregar.Enabled = false;
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            DatosgetEmpleados pModificar = new DatosgetEmpleados();
            pModificar.Nombre = txtnombre.Text;
            pModificar.Cedula = txtcedula.Text;
            pModificar.Direccion = txtdireccion.Text;
            pModificar.Telefono = txTelefono.Text;
            pModificar.Correo = txtCorreo.Text;
            pModificar.Fecha_Nac = txtfech.Value;
            pModificar.Fecha_Ingreso = dtpingreso.Value;
            pModificar.Sueldo = txtsueldo.Text;
            pModificar.SFS = txtsfs.Text;
            pModificar.AFP = txtafp.Text;
            pModificar.Puesto = cPuesto.Text;
            pModificar.Codigo = EmpleadoActual.Codigo;

            int Resultado = DatosbaseEmpleados.Modificar(pModificar);

            if (Resultado > 0)
            {
                MessageBox.Show("Alumno Modificado con exito", "Alumno modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                btneliminar.Enabled = false;
                btnmodificar.Enabled = false;
                btnagregar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se pudo modificar el alumno", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}