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
    public partial class InventarioPantalones : Form
    {
        public InventarioPantalones()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxcodigo.Clear();
            txtbox2.Clear();
            txtbox3.Clear();
            txtbox4.Clear();
            txtBox5.Clear();
            txtBox6.Clear();
        }
    }
}
