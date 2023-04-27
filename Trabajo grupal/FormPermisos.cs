using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_grupal
{
    public partial class FormPermisos : Form
    {
        public FormPermisos()
        {
            InitializeComponent();
        }

        /*Metodo ReleaseCapture*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private int _counter = 0;
        private bool _execute = true;

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (_execute)
            {
                if (chAdmin.Checked)
                {
                    chagregarmercancia.Checked = true;
                    checonsultar.Checked = true;
                    checkBox3.Checked = true;
                    chagregarclientes.Checked = true;
                    chmodificarclientes.Checked = true;
                    cheliminarclientes.Checked = true;
                    chagregarfactura.Checked = true;
                    chconsultarfactura.Checked = true;
                    chmodificarfacttura.Checked = true;
                    agregaruser.Checked = true;
                    consultaruser.Checked = true;
                    eliminaruser.Checked = true;
                    modificaruser.Checked = true;
                }
                else
                {
                    chagregarmercancia.Checked = false;
                    checonsultar.Checked = false;
                    checkBox3.Checked = false;
                    chagregarclientes.Checked = false;
                    chmodificarclientes.Checked = false;
                    cheliminarclientes.Checked = false;
                    chagregarfactura.Checked = false;
                    chconsultarfactura.Checked = false;
                    chmodificarfacttura.Checked = false;
                    agregaruser.Checked = false;
                    consultaruser.Checked = false;
                    eliminaruser.Checked = false;
                    modificaruser.Checked = false;
                }
            }
        }

        private void chkPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            _counter = 0;
            if (!chagregarmercancia.Checked)
            {
                _counter++;
            }
            if (!checonsultar.Checked)
            {
                _counter++;
            }
            if (!checkBox3.Checked)
            {
                _counter++;
            }
            if (!chagregarclientes.Checked)
            {
                _counter++;
            }
            if (!chmodificarclientes.Checked)
            {
                _counter++;
            }
            if (!cheliminarclientes.Checked)
            {
                _counter++;
            }
            if (!chagregarfactura.Checked)
            {
                _counter++;
            }
            if (!chconsultarfactura.Checked)
            {
                _counter++;
            }
            if (!chmodificarfacttura.Checked)
            {
                _counter++;
            }
            if (!agregaruser.Checked)
            {
                _counter++;
            }
            if (!consultaruser.Checked)
            {
                _counter++;
            }
            if (!eliminaruser.Checked)
            {
                _counter++;
            }

            if (_counter >= 0)
            {
                _execute = false;
                chAdmin.Checked = false;
                _execute = true;
                chCustom.Checked = true;
            }
            else
            {
                chCustom.Checked = false;
            }

            if (_counter <= 0)
            {
                _execute = false;
                chAdmin.Checked = true;
                _execute = true;
                chCustom.Checked = false;
            }
            else
            {
                chCustom.Checked = true;
            }
        }

        private int _counter2 = 0;
        private bool _execute2 = true;

        private void checkBoxCaja_CheckedChanged(object sender, EventArgs e)
        {
            if (_execute2)
            {
                if (chCajero.Checked)
                {
                    checonsultar.Checked = true;
                    chmodificarclientes.Checked = true;
                    chagregarfactura.Checked = true;
                }
                else
                {
                    checonsultar.Checked = false;
                    chmodificarclientes.Checked = false;
                    chagregarfactura.Checked = false;
                }
            }
        }
        private void chkCaja_CheckedChanged(object sender, EventArgs e)
        {
            _counter2 = 0;
            if (!checonsultar.Checked)
            {
                _counter2++;
            }
            if (!chmodificarclientes.Checked)
            {
                _counter2++;
            }
            if (!chagregarfactura.Checked)
            {
                _counter2++;
            }

            if (_counter2 >= 0)
            {
                _execute2 = false;
                chAdmin.Checked = false;
                _execute2 = false;
                chCustom.Checked = false;
                _execute2 = true;
                chCajero.Checked = true;
            }
            else
            {
                chCajero.Checked = false;
            }

            if (_counter2 <= 0)
            {
                _execute2 = false;
                chAdmin.Checked = true;
                _execute2 = true;
                chCustom.Checked = false;
            }
            else
            {
                chCustom.Checked = true;
            }
        }
    }
}
