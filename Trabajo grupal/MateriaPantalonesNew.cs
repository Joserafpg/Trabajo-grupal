﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_grupal
{
    public partial class MateriaPantalonesNew : Form
    {
        public MateriaPantalonesNew()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarMateriaPrima()
        {
            String query = "SELECT Codigo, Nombre_Mercancia, Descripcion, Unidad_Medida, Precio_Compra, Stock FROM NuevoInventario where ";

            if (btnbuscar.Text != "")
            {
                query = query + "  ( Nombre_Mercancia like '%" + txtnombre.Text + "%')";
            }

            Conexion.opoencon();
            SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtproductos.DataSource = ds.Tables[0];
            Conexion.cerrarcon();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            MostrarMateriaPrima();
        }

        private void dtproductos_DoubleClick(object sender, EventArgs e)
        {
            InventarioPantalones frm = Owner as InventarioPantalones;

            string codigo = dtproductos.CurrentRow.Cells[0].Value.ToString();
            string nombre = dtproductos.CurrentRow.Cells[1].Value.ToString();
            string size = dtproductos.CurrentRow.Cells[2].Value.ToString();
            string precio = dtproductos.CurrentRow.Cells[3].Value.ToString();
            int nuevoValor = 1;

            // Verifica si ya existe un registro con los mismos valores en las primeras cuatro columnas
            bool existeRegistro = false;
            foreach (DataGridViewRow row in frm.DTPantalones.Rows)
            {
                string codigoExistente = row.Cells[0].Value.ToString();
                string nombreExistente = row.Cells[1].Value.ToString();
                string sizeExistente = row.Cells[2].Value.ToString();
                string precioExistente = row.Cells[3].Value.ToString();

                if (codigo == codigoExistente && nombre == nombreExistente && size == sizeExistente && precio == precioExistente)
                {
                    // El registro ya existe, suma el quinto valor existente con el nuevo valor
                    int valorExistente = Convert.ToInt32(row.Cells[4].Value);
                    int valorSumado = valorExistente + nuevoValor;
                    row.Cells[4].Value = valorSumado;
                    existeRegistro = true;
                    break;
                }
            }

            if (!existeRegistro)
            {
                // El registro no existe, agrega una nueva fila con los valores
                frm.DTPantalones.Rows.Add(codigo, nombre, size, precio, nuevoValor);
            }

            this.Close();
        }

        private void MateriaPantalonesNew_Load(object sender, EventArgs e)
        {
            btnbuscar.PerformClick();
        }
    }
}