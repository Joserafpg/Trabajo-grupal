namespace Trabajo_grupal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnpagos = new System.Windows.Forms.Button();
            this.btnfacturacion = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btninventario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.panelTittleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.dropDownMenu1 = new Trabajo_grupal.ClasesDropDown.DropDownMenu(this.components);
            this.cuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            this.panelTittleBar.SuspendLayout();
            this.dropDownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(90)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button10);
            this.panelMenu.Controls.Add(this.btnpagos);
            this.panelMenu.Controls.Add(this.btnfacturacion);
            this.panelMenu.Controls.Add(this.btnclientes);
            this.panelMenu.Controls.Add(this.btninventario);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Trabajo_grupal.Properties.Resources.configuracion;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 370);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(230, 46);
            this.button2.TabIndex = 3;
            this.button2.Tag = "Configuracion";
            this.button2.Text = "Configuracion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Trabajo_grupal.Properties.Resources.metodo_de_pago__3_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 324);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(230, 46);
            this.button1.TabIndex = 8;
            this.button1.Tag = "Cuentas";
            this.button1.Text = "Cuentas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = global::Trabajo_grupal.Properties.Resources.cerrar_sesion__1_;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 515);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(230, 46);
            this.button10.TabIndex = 7;
            this.button10.Tag = "Salir";
            this.button10.Text = "Salir";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnpagos
            // 
            this.btnpagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpagos.FlatAppearance.BorderSize = 0;
            this.btnpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpagos.ForeColor = System.Drawing.Color.White;
            this.btnpagos.Image = global::Trabajo_grupal.Properties.Resources.factura__1_;
            this.btnpagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpagos.Location = new System.Drawing.Point(0, 278);
            this.btnpagos.Name = "btnpagos";
            this.btnpagos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnpagos.Size = new System.Drawing.Size(230, 46);
            this.btnpagos.TabIndex = 4;
            this.btnpagos.Tag = "Ventas";
            this.btnpagos.Text = "Ventas";
            this.btnpagos.UseVisualStyleBackColor = true;
            this.btnpagos.Click += new System.EventHandler(this.btnpagos_Click);
            // 
            // btnfacturacion
            // 
            this.btnfacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnfacturacion.FlatAppearance.BorderSize = 0;
            this.btnfacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacturacion.ForeColor = System.Drawing.Color.White;
            this.btnfacturacion.Image = global::Trabajo_grupal.Properties.Resources.empleados__1_;
            this.btnfacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfacturacion.Location = new System.Drawing.Point(0, 232);
            this.btnfacturacion.Name = "btnfacturacion";
            this.btnfacturacion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnfacturacion.Size = new System.Drawing.Size(230, 46);
            this.btnfacturacion.TabIndex = 3;
            this.btnfacturacion.Tag = "Empleados";
            this.btnfacturacion.Text = "Empleados";
            this.btnfacturacion.UseVisualStyleBackColor = true;
            this.btnfacturacion.Click += new System.EventHandler(this.btnfacturacion_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.Image = global::Trabajo_grupal.Properties.Resources.cliente;
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(0, 186);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnclientes.Size = new System.Drawing.Size(230, 46);
            this.btnclientes.TabIndex = 2;
            this.btnclientes.Tag = "Clientes";
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btninventario
            // 
            this.btninventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninventario.FlatAppearance.BorderSize = 0;
            this.btninventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventario.ForeColor = System.Drawing.Color.White;
            this.btninventario.Image = global::Trabajo_grupal.Properties.Resources.inventario_disponible;
            this.btninventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninventario.Location = new System.Drawing.Point(0, 140);
            this.btninventario.Name = "btninventario";
            this.btninventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btninventario.Size = new System.Drawing.Size(230, 46);
            this.btninventario.TabIndex = 1;
            this.btninventario.Tag = "Inventario";
            this.btninventario.Text = "Inventario";
            this.btninventario.UseVisualStyleBackColor = true;
            this.btninventario.Click += new System.EventHandler(this.btninventario_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnlogoInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = global::Trabajo_grupal.Properties.Resources.image__3_;
            this.btnMenu.Location = new System.Drawing.Point(182, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(48, 54);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Image = global::Trabajo_grupal.Properties.Resources.image__1_;
            this.btnlogoInicio.Location = new System.Drawing.Point(0, 0);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(230, 122);
            this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlogoInicio.TabIndex = 0;
            this.btnlogoInicio.TabStop = false;
            this.btnlogoInicio.Click += new System.EventHandler(this.btnlogoInicio_Click);
            // 
            // panelTittleBar
            // 
            this.panelTittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(90)))), ((int)(((byte)(244)))));
            this.panelTittleBar.Controls.Add(this.label1);
            this.panelTittleBar.Controls.Add(this.btnMinimize);
            this.panelTittleBar.Controls.Add(this.btnMaximize);
            this.panelTittleBar.Controls.Add(this.btnClose);
            this.panelTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTittleBar.Name = "panelTittleBar";
            this.panelTittleBar.Size = new System.Drawing.Size(904, 60);
            this.panelTittleBar.TabIndex = 1;
            this.panelTittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTittleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 5;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Trabajo_grupal.Properties.Resources.menos;
            this.btnMinimize.Location = new System.Drawing.Point(769, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 25);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::Trabajo_grupal.Properties.Resources.expandir__3_;
            this.btnMaximize.Location = new System.Drawing.Point(814, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 25);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Trabajo_grupal.Properties.Resources.cerrar__3_;
            this.btnClose.Location = new System.Drawing.Point(859, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(904, 501);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelDesktop_MouseClick);
            // 
            // dropDownMenu1
            // 
            this.dropDownMenu1.IsMainMenu = false;
            this.dropDownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasPorPagarToolStripMenuItem,
            this.cuentasPorCobrarToolStripMenuItem});
            this.dropDownMenu1.MenuItemHeight = 25;
            this.dropDownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.dropDownMenu1.Name = "dropDownMenu1";
            this.dropDownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.dropDownMenu1.Size = new System.Drawing.Size(176, 48);
            // 
            // cuentasPorPagarToolStripMenuItem
            // 
            this.cuentasPorPagarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cuentasPorPagarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cuentasPorPagarToolStripMenuItem.Name = "cuentasPorPagarToolStripMenuItem";
            this.cuentasPorPagarToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cuentasPorPagarToolStripMenuItem.Text = "Cuentas por pagar";
            this.cuentasPorPagarToolStripMenuItem.Click += new System.EventHandler(this.cuentasPorPagarToolStripMenuItem_Click);
            // 
            // cuentasPorCobrarToolStripMenuItem
            // 
            this.cuentasPorCobrarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.cuentasPorCobrarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
            this.cuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cuentasPorCobrarToolStripMenuItem.Text = "Cuentas por cobrar";
            this.cuentasPorCobrarToolStripMenuItem.Click += new System.EventHandler(this.cuentasPorCobrarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTittleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "GESTJEANS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            this.panelTittleBar.ResumeLayout(false);
            this.panelTittleBar.PerformLayout();
            this.dropDownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTittleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox btnlogoInicio;
        private System.Windows.Forms.Button btnpagos;
        private System.Windows.Forms.Button btnfacturacion;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btninventario;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private ClasesDropDown.DropDownMenu dropDownMenu1;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

