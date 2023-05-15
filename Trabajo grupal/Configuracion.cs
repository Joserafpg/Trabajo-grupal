using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_grupal;

namespace proveedores
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }
        public static bool IsOpen { get; set; }

        private void OpenForm()
        {
            if (!IsOpen)
            {
                IsOpen = true;
                Configuracion config = new Configuracion();
                config.FormClosed += (s, args) => IsOpen = false;
                config.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoUsuario frm = new NuevoUsuario();
            frm.ShowDialog();
        }
    }
}
