﻿using System;
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
    public partial class ConsultarMateriaPrima : Form
    {
        public ConsultarMateriaPrima()
        {
            InitializeComponent();
        }
        public Datosget MateriaPrimaSeleccionada { get; set; }
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
        }

        private void ConsultarMateriaPrima_Load(object sender, EventArgs e)
        {

        }
    }
}
