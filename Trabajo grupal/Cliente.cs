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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            Datosget Cliente = new Datosget();
            Cliente.Cedula = txtcedula.Text;
            Alumno.Nombre = txtNombre.Text;
            Alumno.Telefono = txtTelefono.Text;
            Alumno.Direccion = txtDireccion.Text;
            Alumno.Fecha_Nac = txtFech.Value;

            int resultado = Datosbasedt.Agregar(Alumno);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No se pudieron guardar los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    }
}
