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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
           
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("El valor ingresado no es válido.");
            }
        }
    }
}
