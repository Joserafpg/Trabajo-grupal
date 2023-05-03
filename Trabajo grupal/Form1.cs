using angel22mg;
using proveedores;
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
            ms7.SetToolTip(btnfacturacion, "Ventas");

            var ms8 = new ToolTip();
            ms8.SetToolTip(btnpagos, "Cuentas");

            var ms9 = new ToolTip();
            ms9.SetToolTip(button1, "Configuracion");
        }

        Facturacion form2 = new Facturacion();

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
       
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Permisos para el inventario//
            btninventario.Enabled = Permisos.AgregarINVENTARIO;
            btninventario.Enabled = Permisos.ModificarINVENTARIO;
            btninventario.Enabled = Permisos.ConsultarINVENTARIO;
            btninventario.Enabled = Permisos.EliminarFACTURA;

            //Permisos para el clientes//
            btnclientes.Enabled = Permisos.AgregarCLIENTE;
            btnclientes.Enabled = Permisos.ModificSarCLIENTES;
            btnclientes.Enabled = Permisos.ConsultarCLIENTES;
            btnclientes.Enabled = Permisos.EliminarCLIENTES;

            //Permisos para el factura//
            btnfacturacion.Enabled = Permisos.AgregarFACTURA;
            btnfacturacion.Enabled = Permisos.ModificarFACTURA;
            btnfacturacion.Enabled = Permisos.ConsultarFACTURA;
            btnfacturacion.Enabled = Permisos.EliminarFACTURA;

            //Permisos para las cuentas x cobrar/pagar //
            btnpagos.Enabled = Permisos.AgregarCuentasPagar;
            btnpagos.Enabled = Permisos.ModificarCuentasPagar;
            btnpagos.Enabled = Permisos.ConsultarCuentasPagar;
            btnpagos.Enabled = Permisos.EliminarCuentasPagar;

            btnpagos.Enabled = Permisos.AgregarCuentasCobrar;
            btnpagos.Enabled = Permisos.ModificarCuentasCobrar;
            btnpagos.Enabled = Permisos.ConsultarCuentasCobrar;
            btnpagos.Enabled = Permisos.EliminarCuentasCobrar;

            cuentasPorPagarToolStripMenuItem.Enabled = Permisos.AgregarCuentasPagar;
            cuentasPorPagarToolStripMenuItem.Enabled = Permisos.ModificarCuentasPagar;
            cuentasPorPagarToolStripMenuItem.Enabled = Permisos.ConsultarCuentasPagar;
            cuentasPorPagarToolStripMenuItem.Enabled = Permisos.EliminarCuentasPagar;

            cuentasPorCobrarToolStripMenuItem.Enabled = Permisos.AgregarCuentasCobrar;
            cuentasPorCobrarToolStripMenuItem.Enabled = Permisos.ModificarCuentasCobrar;
            cuentasPorCobrarToolStripMenuItem.Enabled = Permisos.ConsultarCuentasCobrar;
            cuentasPorCobrarToolStripMenuItem.Enabled = Permisos.EliminarCuentasCobrar;

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

        /*Metodo CollapseMenuOpen*/
        private void CollapseMenuOpen()
        {
            if (this.panelMenu.Width > 99)
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

            //Metodo Abrir Formulario en el panel//
            public void AbrirFormEnPanel(object Formhijo)
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
            AbrirFormEnPanel(new Configuracion());
        }

        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            label1.Text = "Ventas";
            CollapseMenuClose();
            AbrirFormEnPanel(new Facturacion());
        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            CollapseMenuOpen();
            dropDownMenu1.Show(btnpagos,btnpagos.Width, 0);
        }

        private void panelDesktop_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            label1.Text = "DASHBOARD";
            CollapseMenu();
            AbrirFormEnPanel(new Menu_inicio());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login_Form frm = new Login_Form();
            frm.Show();
            this.Close();
        }

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new cuentasporpagar());
            CollapseMenuClose();
            label1.Text = "Cuentas por pagar";
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Cuentasporcobrar());
            CollapseMenuClose();
            label1.Text = "Cuentas por cobrar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Configuracion";
            CollapseMenuClose();
            AbrirFormEnPanel(new Configuracion());
        }
    }
}