namespace Trabajo_grupal
{
    partial class FormPermisos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chagregarmercancia = new System.Windows.Forms.CheckBox();
            this.checonsultar = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cheliminarfactura = new System.Windows.Forms.CheckBox();
            this.cheliminarmercancia = new System.Windows.Forms.CheckBox();
            this.modificaruser = new System.Windows.Forms.CheckBox();
            this.chconsultarclientes = new System.Windows.Forms.CheckBox();
            this.chCajero = new System.Windows.Forms.CheckBox();
            this.chCustom = new System.Windows.Forms.CheckBox();
            this.chAdmin = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.eliminaruser = new System.Windows.Forms.CheckBox();
            this.agregaruser = new System.Windows.Forms.CheckBox();
            this.consultaruser = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chmodificarfacttura = new System.Windows.Forms.CheckBox();
            this.chagregarfactura = new System.Windows.Forms.CheckBox();
            this.chconsultarfactura = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chagregarclientes = new System.Windows.Forms.CheckBox();
            this.chmodificarclientes = new System.Windows.Forms.CheckBox();
            this.cheliminarclientes = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chagregarmercancia
            // 
            this.chagregarmercancia.AutoSize = true;
            this.chagregarmercancia.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chagregarmercancia.Location = new System.Drawing.Point(38, 105);
            this.chagregarmercancia.Name = "chagregarmercancia";
            this.chagregarmercancia.Size = new System.Drawing.Size(162, 23);
            this.chagregarmercancia.TabIndex = 0;
            this.chagregarmercancia.Text = "Agregar mercancia";
            this.chagregarmercancia.UseVisualStyleBackColor = true;
            this.chagregarmercancia.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // checonsultar
            // 
            this.checonsultar.AutoSize = true;
            this.checonsultar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checonsultar.Location = new System.Drawing.Point(39, 147);
            this.checonsultar.Name = "checonsultar";
            this.checonsultar.Size = new System.Drawing.Size(205, 23);
            this.checonsultar.TabIndex = 1;
            this.checonsultar.Text = "Ver reportes de existencia";
            this.checonsultar.UseVisualStyleBackColor = true;
            this.checonsultar.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox3.Location = new System.Drawing.Point(42, 193);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(166, 23);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Modificar inventario";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cheliminarfactura);
            this.groupBox1.Controls.Add(this.cheliminarmercancia);
            this.groupBox1.Controls.Add(this.modificaruser);
            this.groupBox1.Controls.Add(this.chconsultarclientes);
            this.groupBox1.Controls.Add(this.chCajero);
            this.groupBox1.Controls.Add(this.chCustom);
            this.groupBox1.Controls.Add(this.chAdmin);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.eliminaruser);
            this.groupBox1.Controls.Add(this.agregaruser);
            this.groupBox1.Controls.Add(this.consultaruser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chmodificarfacttura);
            this.groupBox1.Controls.Add(this.chagregarfactura);
            this.groupBox1.Controls.Add(this.chconsultarfactura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chagregarclientes);
            this.groupBox1.Controls.Add(this.chmodificarclientes);
            this.groupBox1.Controls.Add(this.cheliminarclientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.chagregarmercancia);
            this.groupBox1.Controls.Add(this.checonsultar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(33, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 425);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // cheliminarfactura
            // 
            this.cheliminarfactura.AutoSize = true;
            this.cheliminarfactura.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cheliminarfactura.Location = new System.Drawing.Point(454, 232);
            this.cheliminarfactura.Name = "cheliminarfactura";
            this.cheliminarfactura.Size = new System.Drawing.Size(140, 23);
            this.cheliminarfactura.TabIndex = 24;
            this.cheliminarfactura.Text = "Eliminar factura ";
            this.cheliminarfactura.UseVisualStyleBackColor = true;
            // 
            // cheliminarmercancia
            // 
            this.cheliminarmercancia.AutoSize = true;
            this.cheliminarmercancia.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cheliminarmercancia.Location = new System.Drawing.Point(43, 229);
            this.cheliminarmercancia.Name = "cheliminarmercancia";
            this.cheliminarmercancia.Size = new System.Drawing.Size(161, 23);
            this.cheliminarmercancia.TabIndex = 23;
            this.cheliminarmercancia.Text = "Eliminar mercancia";
            this.cheliminarmercancia.UseVisualStyleBackColor = true;
            // 
            // modificaruser
            // 
            this.modificaruser.AutoSize = true;
            this.modificaruser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.modificaruser.Location = new System.Drawing.Point(667, 232);
            this.modificaruser.Name = "modificaruser";
            this.modificaruser.Size = new System.Drawing.Size(93, 23);
            this.modificaruser.TabIndex = 22;
            this.modificaruser.Text = "Modificar";
            this.modificaruser.UseVisualStyleBackColor = true;
            // 
            // chconsultarclientes
            // 
            this.chconsultarclientes.AutoSize = true;
            this.chconsultarclientes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chconsultarclientes.Location = new System.Drawing.Point(277, 232);
            this.chconsultarclientes.Name = "chconsultarclientes";
            this.chconsultarclientes.Size = new System.Drawing.Size(93, 23);
            this.chconsultarclientes.TabIndex = 21;
            this.chconsultarclientes.Text = "Consultar";
            this.chconsultarclientes.UseVisualStyleBackColor = true;
            // 
            // chCajero
            // 
            this.chCajero.AutoSize = true;
            this.chCajero.Location = new System.Drawing.Point(584, 368);
            this.chCajero.Name = "chCajero";
            this.chCajero.Size = new System.Drawing.Size(81, 25);
            this.chCajero.TabIndex = 20;
            this.chCajero.Text = "Cajero";
            this.chCajero.UseVisualStyleBackColor = true;
            this.chCajero.CheckedChanged += new System.EventHandler(this.checkBoxCaja_CheckedChanged);
            // 
            // chCustom
            // 
            this.chCustom.AutoSize = true;
            this.chCustom.Location = new System.Drawing.Point(584, 327);
            this.chCustom.Name = "chCustom";
            this.chCustom.Size = new System.Drawing.Size(135, 25);
            this.chCustom.TabIndex = 19;
            this.chCustom.Text = "Personalizado";
            this.chCustom.UseVisualStyleBackColor = true;
            // 
            // chAdmin
            // 
            this.chAdmin.AutoSize = true;
            this.chAdmin.Location = new System.Drawing.Point(584, 285);
            this.chAdmin.Name = "chAdmin";
            this.chAdmin.Size = new System.Drawing.Size(81, 25);
            this.chAdmin.TabIndex = 18;
            this.chAdmin.Text = "Admin";
            this.chAdmin.UseVisualStyleBackColor = true;
            this.chAdmin.CheckedChanged += new System.EventHandler(this.checkBoxAdmin_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(360, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 51);
            this.button2.TabIndex = 17;
            this.button2.Text = "Deshacer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(168, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cuentas";
            // 
            // eliminaruser
            // 
            this.eliminaruser.AutoSize = true;
            this.eliminaruser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.eliminaruser.Location = new System.Drawing.Point(667, 193);
            this.eliminaruser.Name = "eliminaruser";
            this.eliminaruser.Size = new System.Drawing.Size(81, 23);
            this.eliminaruser.TabIndex = 14;
            this.eliminaruser.Text = "Eliminar";
            this.eliminaruser.UseVisualStyleBackColor = true;
            this.eliminaruser.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // agregaruser
            // 
            this.agregaruser.AutoSize = true;
            this.agregaruser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.agregaruser.Location = new System.Drawing.Point(667, 105);
            this.agregaruser.Name = "agregaruser";
            this.agregaruser.Size = new System.Drawing.Size(82, 23);
            this.agregaruser.TabIndex = 12;
            this.agregaruser.Text = "Agregar";
            this.agregaruser.UseVisualStyleBackColor = true;
            this.agregaruser.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // consultaruser
            // 
            this.consultaruser.AutoSize = true;
            this.consultaruser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.consultaruser.Location = new System.Drawing.Point(667, 147);
            this.consultaruser.Name = "consultaruser";
            this.consultaruser.Size = new System.Drawing.Size(93, 23);
            this.consultaruser.TabIndex = 13;
            this.consultaruser.Text = "Consultar";
            this.consultaruser.UseVisualStyleBackColor = true;
            this.consultaruser.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Facturas";
            // 
            // chmodificarfacttura
            // 
            this.chmodificarfacttura.AutoSize = true;
            this.chmodificarfacttura.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chmodificarfacttura.Location = new System.Drawing.Point(454, 193);
            this.chmodificarfacttura.Name = "chmodificarfacttura";
            this.chmodificarfacttura.Size = new System.Drawing.Size(152, 23);
            this.chmodificarfacttura.TabIndex = 10;
            this.chmodificarfacttura.Text = "Modificar factura ";
            this.chmodificarfacttura.UseVisualStyleBackColor = true;
            this.chmodificarfacttura.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // chagregarfactura
            // 
            this.chagregarfactura.AutoSize = true;
            this.chagregarfactura.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chagregarfactura.Location = new System.Drawing.Point(454, 105);
            this.chagregarfactura.Name = "chagregarfactura";
            this.chagregarfactura.Size = new System.Drawing.Size(86, 23);
            this.chagregarfactura.TabIndex = 8;
            this.chagregarfactura.Text = "Facturar";
            this.chagregarfactura.UseVisualStyleBackColor = true;
            this.chagregarfactura.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // chconsultarfactura
            // 
            this.chconsultarfactura.AutoSize = true;
            this.chconsultarfactura.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chconsultarfactura.Location = new System.Drawing.Point(454, 147);
            this.chconsultarfactura.Name = "chconsultarfactura";
            this.chconsultarfactura.Size = new System.Drawing.Size(152, 23);
            this.chconsultarfactura.TabIndex = 9;
            this.chconsultarfactura.Text = "Consultar factura ";
            this.chconsultarfactura.UseVisualStyleBackColor = true;
            this.chconsultarfactura.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clientes";
            // 
            // chagregarclientes
            // 
            this.chagregarclientes.AutoSize = true;
            this.chagregarclientes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chagregarclientes.Location = new System.Drawing.Point(276, 105);
            this.chagregarclientes.Name = "chagregarclientes";
            this.chagregarclientes.Size = new System.Drawing.Size(82, 23);
            this.chagregarclientes.TabIndex = 6;
            this.chagregarclientes.Text = "Agregar";
            this.chagregarclientes.UseVisualStyleBackColor = true;
            this.chagregarclientes.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // chmodificarclientes
            // 
            this.chmodificarclientes.AutoSize = true;
            this.chmodificarclientes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chmodificarclientes.Location = new System.Drawing.Point(276, 147);
            this.chmodificarclientes.Name = "chmodificarclientes";
            this.chmodificarclientes.Size = new System.Drawing.Size(93, 23);
            this.chmodificarclientes.TabIndex = 4;
            this.chmodificarclientes.Text = "Modificar";
            this.chmodificarclientes.UseVisualStyleBackColor = true;
            this.chmodificarclientes.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // cheliminarclientes
            // 
            this.cheliminarclientes.AutoSize = true;
            this.cheliminarclientes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cheliminarclientes.Location = new System.Drawing.Point(276, 193);
            this.cheliminarclientes.Name = "cheliminarclientes";
            this.cheliminarclientes.Size = new System.Drawing.Size(81, 23);
            this.cheliminarclientes.TabIndex = 5;
            this.cheliminarclientes.Text = "Eliminar";
            this.cheliminarclientes.UseVisualStyleBackColor = true;
            this.cheliminarclientes.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 26);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Trabajo_grupal.Properties.Resources.cerrar__3_;
            this.btnClose.Location = new System.Drawing.Point(847, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(893, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPermisos";
            this.Text = "FormPermisos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chagregarmercancia;
        private System.Windows.Forms.CheckBox checonsultar;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox eliminaruser;
        private System.Windows.Forms.CheckBox agregaruser;
        private System.Windows.Forms.CheckBox consultaruser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chmodificarfacttura;
        private System.Windows.Forms.CheckBox chagregarfactura;
        private System.Windows.Forms.CheckBox chconsultarfactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chagregarclientes;
        private System.Windows.Forms.CheckBox chmodificarclientes;
        private System.Windows.Forms.CheckBox cheliminarclientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chAdmin;
        private System.Windows.Forms.CheckBox chCustom;
        private System.Windows.Forms.CheckBox chCajero;
        private System.Windows.Forms.CheckBox modificaruser;
        private System.Windows.Forms.CheckBox chconsultarclientes;
        private System.Windows.Forms.CheckBox cheliminarfactura;
        private System.Windows.Forms.CheckBox cheliminarmercancia;
    }
}