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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modificaruser = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBoxCaja = new System.Windows.Forms.CheckBox();
            this.checkBoxCustom = new System.Windows.Forms.CheckBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.eliminaruser = new System.Windows.Forms.CheckBox();
            this.agregaruser = new System.Windows.Forms.CheckBox();
            this.consultaruser = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox1.Location = new System.Drawing.Point(42, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 23);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Agregar mercancia";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox2.Location = new System.Drawing.Point(39, 147);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(205, 23);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ver reportes de existencia";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
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
            this.groupBox1.Controls.Add(this.checkBox11);
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.modificaruser);
            this.groupBox1.Controls.Add(this.checkBox13);
            this.groupBox1.Controls.Add(this.checkBoxCaja);
            this.groupBox1.Controls.Add(this.checkBoxCustom);
            this.groupBox1.Controls.Add(this.checkBoxAdmin);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.eliminaruser);
            this.groupBox1.Controls.Add(this.agregaruser);
            this.groupBox1.Controls.Add(this.consultaruser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(33, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 425);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
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
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox13.Location = new System.Drawing.Point(277, 232);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(93, 23);
            this.checkBox13.TabIndex = 21;
            this.checkBox13.Text = "Consultar";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaja
            // 
            this.checkBoxCaja.AutoSize = true;
            this.checkBoxCaja.Location = new System.Drawing.Point(584, 368);
            this.checkBoxCaja.Name = "checkBoxCaja";
            this.checkBoxCaja.Size = new System.Drawing.Size(81, 25);
            this.checkBoxCaja.TabIndex = 20;
            this.checkBoxCaja.Text = "Cajero";
            this.checkBoxCaja.UseVisualStyleBackColor = true;
            this.checkBoxCaja.CheckedChanged += new System.EventHandler(this.checkBoxCaja_CheckedChanged);
            // 
            // checkBoxCustom
            // 
            this.checkBoxCustom.AutoSize = true;
            this.checkBoxCustom.Location = new System.Drawing.Point(584, 327);
            this.checkBoxCustom.Name = "checkBoxCustom";
            this.checkBoxCustom.Size = new System.Drawing.Size(135, 25);
            this.checkBoxCustom.TabIndex = 19;
            this.checkBoxCustom.Text = "Personalizado";
            this.checkBoxCustom.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(584, 285);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(81, 25);
            this.checkBoxAdmin.TabIndex = 18;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            this.checkBoxAdmin.CheckedChanged += new System.EventHandler(this.checkBoxAdmin_CheckedChanged);
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
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox9.Location = new System.Drawing.Point(454, 193);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 10;
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox7.Location = new System.Drawing.Point(454, 105);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(86, 23);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Facturar";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox8.Location = new System.Drawing.Point(454, 147);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(196, 23);
            this.checkBox8.TabIndex = 9;
            this.checkBox8.Text = "Reportes de facturación";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
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
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox4.Location = new System.Drawing.Point(276, 105);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(82, 23);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Agregar";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox5.Location = new System.Drawing.Point(276, 147);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(93, 23);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Modificar";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox6.Location = new System.Drawing.Point(276, 193);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(81, 23);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Eliminar";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.chkPrincipal_CheckedChanged);
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
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox10.Location = new System.Drawing.Point(43, 229);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(161, 23);
            this.checkBox10.TabIndex = 23;
            this.checkBox10.Text = "Eliminar mercancia";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.checkBox11.Location = new System.Drawing.Point(454, 232);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(111, 23);
            this.checkBox11.TabIndex = 24;
            this.checkBox11.Text = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
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

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox eliminaruser;
        private System.Windows.Forms.CheckBox agregaruser;
        private System.Windows.Forms.CheckBox consultaruser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.CheckBox checkBoxCustom;
        private System.Windows.Forms.CheckBox checkBoxCaja;
        private System.Windows.Forms.CheckBox modificaruser;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
    }
}