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
                if (checkBoxAdmin.Checked)
                {
                    checkBox1.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox4.Checked = true;
                    checkBox5.Checked = true;
                    checkBox6.Checked = true;
                    checkBox7.Checked = true;
                    checkBox8.Checked = true;
                    checkBox9.Checked = true;
                    checkBox10.Checked = true;
                    checkBox11.Checked = true;
                    checkBox12.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    checkBox6.Checked = false;
                    checkBox7.Checked = false;
                    checkBox8.Checked = false;
                    checkBox9.Checked = false;
                    checkBox10.Checked = false;
                    checkBox11.Checked = false;
                    checkBox12.Checked = false;
                }
            }
        }

        private void chkPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            _counter = 0;
            if (!checkBox1.Checked)
            {
                _counter++;
            }
            if (!checkBox2.Checked)
            {
                _counter++;
            }
            if (!checkBox3.Checked)
            {
                _counter++;
            }
            if (!checkBox4.Checked)
            {
                _counter++;
            }
            if (!checkBox5.Checked)
            {
                _counter++;
            }
            if (!checkBox6.Checked)
            {
                _counter++;
            }
            if (!checkBox7.Checked)
            {
                _counter++;
            }
            if (!checkBox8.Checked)
            {
                _counter++;
            }
            if (!checkBox9.Checked)
            {
                _counter++;
            }
            if (!checkBox10.Checked)
            {
                _counter++;
            }
            if (!checkBox11.Checked)
            {
                _counter++;
            }
            if (!checkBox12.Checked)
            {
                _counter++;
            }

            if (_counter >= 0)
            {
                _execute = false;
                checkBoxAdmin.Checked = false;
                _execute = true;
                checkBoxCustom.Checked = true;
            }
            else
            {
                checkBoxCustom.Checked = false;
            }

            if (_counter <= 0)
            {
                _execute = false;
                checkBoxAdmin.Checked = true;
                _execute = true;
                checkBoxCustom.Checked = false;
            }
            else
            {
                checkBoxCustom.Checked = true;
            }
        }
    }
}
