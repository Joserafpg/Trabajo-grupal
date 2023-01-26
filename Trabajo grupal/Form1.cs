using angel22mg;
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
using WindowsFormsApp2;

namespace Trabajo_grupal
{
    public partial class Form1 : Form
    {

        private int borderSize = 2;
        public Form1()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);


            var ms1 = new ToolTip();
            ms1.SetToolTip(btnClose, "Cerrar");

            var ms2 = new ToolTip();
            ms2.SetToolTip(btnMaximize, "Maximizar");

            var ms3 = new ToolTip();
            ms3.SetToolTip(btnMinimize, "Minimizar");

            var ms4 = new ToolTip();
            ms4.SetToolTip(btnMenu, "Menú Vertical");

            var ms5 = new ToolTip();
            ms5.SetToolTip(btninventario, "Inventario");

            var ms6 = new ToolTip();
            ms6.SetToolTip(btnclientes, "Clientes");

            var ms7 = new ToolTip();
            ms7.SetToolTip(btnproveedores, "Proveedores");

            var ms8 = new ToolTip();
            ms8.SetToolTip(btnfacturacion, "Facturación");

            var ms9 = new ToolTip();
            ms9.SetToolTip(btnpagos, "Cuentas por pagar");

            var ms10 = new ToolTip();
            ms10.SetToolTip(btnCobrar, "Cuentas por cobrar");
        }

        /*Metodo ReleaseCapture*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        /*Metodo CollapseMenu*/
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) 
            {
                panelMenu.Width = 100;
                btnlogoInicio.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }

            else
            {
                panelMenu.Width = 230;
                btnlogoInicio.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        //Metodo para cerrar el menu desplegable//
        private void CollapseMenuClose()
        {
            if (this.panelMenu.Width > 200) 
            {
                panelMenu.Width = 100;
                btnlogoInicio.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
        }

        //Metodo Abrir Formulario en el panel//
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelDesktop.Controls.Count > 0)
                this.panelDesktop.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(fh);
            this.panelDesktop.Tag = fh;
            fh.Show();
        }
        private void btninventario_Click(object sender, EventArgs e)
        {
            label1.Text = "Inventario";
            CollapseMenuClose();
            AbrirFormEnPanel(new Inventario());
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            label1.Text = "Clientes";
            CollapseMenuClose();
            AbrirFormEnPanel(new Cliente());
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            label1.Text = "Proveedores";
            CollapseMenuClose();
            AbrirFormEnPanel(new Form2());
        }

        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            label1.Text = "Facturacion";
            CollapseMenuClose();
            AbrirFormEnPanel(new Facturacion());
        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            CollapseMenuClose();
            AbrirFormEnPanel(new cuentasporpagar ());
        }

        private void panelDesktop_MouseClick(object sender, MouseEventArgs e)
        {
            CollapseMenuClose();
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            label1.Text = "DASHBOARD";
            CollapseMenu();
            AbrirFormEnPanel(new Menu_inicio());
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            CollapseMenuClose();
            AbrirFormEnPanel(new Cuentasporcobrar());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login_Form frm = new Login_Form();
            frm.Show();
        }
    }
}
