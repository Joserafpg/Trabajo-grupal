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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            DatosgetClientes Clientes = new DatosgetClientes();
            Clientes.Nombre = txtnombre.Text;
            Clientes.Apellido = txtapellido.Text;
            Clientes.Direccion = txtdireccion.Text;
            Clientes.Telefono = txTelefono.Text;
            Clientes.Correo = txtCorreo.Text;
            Clientes.Fecha_Ingreso = txtfech.Value;

            int resultado = Datosbasedt.Agregar(Clientes);

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
