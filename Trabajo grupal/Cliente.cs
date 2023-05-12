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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        public DatosgetClientes AlumnoActual { get; set; }

        void Limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtdireccion.Clear();
            txTelefono.Clear();
            txtCorreo.Clear();
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            DatosgetClientes Clientes = new DatosgetClientes();

            Clientes.Nombre = txtnombre.Text;
            Clientes.Apellido = txtapellido.Text;
            Clientes.Direccion = txtdireccion.Text;
            Clientes.Telefono= txTelefono.Text;
            Clientes.Correo = txtCorreo.Text;
            Clientes.Fecha_Ingreso = txtfech.Value;

            int resultado = DatosbaseCliente.Agregar(Clientes);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No se pudieron guardar los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            DatosgetClientes pClientes = new DatosgetClientes();
            pClientes.Nombre = txtnombre.Text;
            pClientes.Apellido = txtapellido.Text;
            pClientes.Direccion = txtdireccion.Text;
            pClientes.Telefono = txTelefono.Text;
            pClientes.Correo = txtCorreo.Text;
            pClientes.Fecha_Ingreso = txtfech.Value;
            pClientes.Codigo = AlumnoActual.Codigo;

            int Resultado = DatosbaseCliente.Modificar(pClientes);

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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar estudiante actual??", "Esta Seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Int64 resultado = Datosbasedt.Eliminar((int)AlumnoActual.Codigo);
                if (resultado > 0)
                {
                    MessageBox.Show("Estudiantes eliminados", "Estudiante Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    btneliminar.Enabled = false;
                    btnmodificar.Enabled = false;
                    btnagregar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("No se pudo eliminar al estudiantes", "Estudiantes eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
        }
    }
}


        
    
    

