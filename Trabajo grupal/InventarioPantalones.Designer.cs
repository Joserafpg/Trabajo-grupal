namespace Trabajo_grupal
{
    partial class InventarioPantalones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMateriaUtilizada = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.agregaraldtg = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.agregarmateriaprimamanual = new System.Windows.Forms.Button();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtinvminimo = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panelMateriaUtilizada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.panelMateriaUtilizada);
            this.groupBox1.Controls.Add(this.cbSize);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.txtinvminimo);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(40, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventario Pantalones";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(651, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 64);
            this.button2.TabIndex = 25;
            this.button2.Text = "Guardar mercancia";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(651, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 64);
            this.button1.TabIndex = 24;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelMateriaUtilizada
            // 
            this.panelMateriaUtilizada.Controls.Add(this.label1);
            this.panelMateriaUtilizada.Controls.Add(this.dtgDatos);
            this.panelMateriaUtilizada.Controls.Add(this.label4);
            this.panelMateriaUtilizada.Controls.Add(this.agregarmateriaprimamanual);
            this.panelMateriaUtilizada.Controls.Add(this.txtcodigo);
            this.panelMateriaUtilizada.Controls.Add(this.txtprecio);
            this.panelMateriaUtilizada.Controls.Add(this.agregaraldtg);
            this.panelMateriaUtilizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelMateriaUtilizada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMateriaUtilizada.Location = new System.Drawing.Point(3, 23);
            this.panelMateriaUtilizada.Name = "panelMateriaUtilizada";
            this.panelMateriaUtilizada.Size = new System.Drawing.Size(642, 479);
            this.panelMateriaUtilizada.TabIndex = 23;
            this.panelMateriaUtilizada.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(132, 80);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(201, 20);
            this.txtcodigo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio";
            // 
            // agregaraldtg
            // 
            this.agregaraldtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.agregaraldtg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.agregaraldtg.Location = new System.Drawing.Point(365, 80);
            this.agregaraldtg.Name = "agregaraldtg";
            this.agregaraldtg.Size = new System.Drawing.Size(85, 23);
            this.agregaraldtg.TabIndex = 1;
            this.agregaraldtg.Text = "Agregar";
            this.agregaraldtg.UseVisualStyleBackColor = true;
            this.agregaraldtg.Click += new System.EventHandler(this.agregaraldtg_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(512, 379);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(81, 20);
            this.txtprecio.TabIndex = 12;
            // 
            // agregarmateriaprimamanual
            // 
            this.agregarmateriaprimamanual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.agregarmateriaprimamanual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.agregarmateriaprimamanual.Location = new System.Drawing.Point(69, 369);
            this.agregarmateriaprimamanual.Name = "agregarmateriaprimamanual";
            this.agregarmateriaprimamanual.Size = new System.Drawing.Size(85, 23);
            this.agregarmateriaprimamanual.TabIndex = 0;
            this.agregarmateriaprimamanual.Text = "Agregar";
            this.agregarmateriaprimamanual.UseVisualStyleBackColor = true;
            this.agregarmateriaprimamanual.Click += new System.EventHandler(this.agregarmateriaprimamanual_Click);
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.descripcion,
            this.medida,
            this.precio,
            this.cantidad,
            this.subtotal});
            this.dtgDatos.Location = new System.Drawing.Point(69, 127);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(542, 219);
            this.dtgDatos.TabIndex = 0;
            this.dtgDatos.CurrentCellChanged += new System.EventHandler(this.dtgDatos_CurrentCellChanged);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Xsmall",
            "Small",
            "Medium",
            "Large",
            "XLarge",
            "XXLarge"});
            this.cbSize.Location = new System.Drawing.Point(255, 172);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(249, 29);
            this.cbSize.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Size";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.LightGreen;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnbuscar.Location = new System.Drawing.Point(651, 104);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(186, 64);
            this.btnbuscar.TabIndex = 20;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(651, 181);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(186, 64);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.White;
            this.btneliminar.FlatAppearance.BorderSize = 0;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btneliminar.Location = new System.Drawing.Point(651, 352);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(186, 64);
            this.btneliminar.TabIndex = 18;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnguardar.Location = new System.Drawing.Point(651, 264);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(186, 64);
            this.btnguardar.TabIndex = 12;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtinvminimo
            // 
            this.txtinvminimo.Location = new System.Drawing.Point(255, 258);
            this.txtinvminimo.Name = "txtinvminimo";
            this.txtinvminimo.Size = new System.Drawing.Size(249, 27);
            this.txtinvminimo.TabIndex = 10;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(255, 212);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(249, 27);
            this.txtstock.TabIndex = 9;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(255, 123);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(249, 27);
            this.txtNombreProducto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Inv.Minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "NombreProducto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 31);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Trabajo_grupal.Properties.Resources.cerrar__3_;
            this.btnClose.Location = new System.Drawing.Point(890, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Id Material";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // medida
            // 
            this.medida.HeaderText = "Medida";
            this.medida.Name = "medida";
            this.medida.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Sub Total";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // InventarioPantalones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(938, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioPantalones";
            this.Text = "InventarioPantalones";
            this.Load += new System.EventHandler(this.InventarioPantalones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelMateriaUtilizada.ResumeLayout(false);
            this.panelMateriaUtilizada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtinvminimo;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelMateriaUtilizada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Button agregarmateriaprimamanual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button agregaraldtg;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}