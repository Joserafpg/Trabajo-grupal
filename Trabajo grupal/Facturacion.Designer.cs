namespace Trabajo_grupal
{
    partial class Facturacion
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregarmanual = new System.Windows.Forms.Button();
            this.btndeshacer = new System.Windows.Forms.Button();
            this.btnfacturar = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1034, 501);
            this.panel5.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(791, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 50);
            this.button4.TabIndex = 22;
            this.button4.Text = "Todas las facturas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(438, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "Ponen Jeans";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnagregarmanual);
            this.panel1.Controls.Add(this.btndeshacer);
            this.panel1.Controls.Add(this.btnfacturar);
            this.panel1.Location = new System.Drawing.Point(270, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 485);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "......";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Codigo del producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreProducto,
            this.Precio,
            this.CantidadProducto,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(31, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 148);
            this.dataGridView1.TabIndex = 16;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 68;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 80;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.HeaderText = "Cantidad";
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.Width = 60;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 73;
            // 
            // btnagregarmanual
            // 
            this.btnagregarmanual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnagregarmanual.Location = new System.Drawing.Point(31, 315);
            this.btnagregarmanual.Name = "btnagregarmanual";
            this.btnagregarmanual.Size = new System.Drawing.Size(100, 25);
            this.btnagregarmanual.TabIndex = 18;
            this.btnagregarmanual.Text = "Agregar";
            this.btnagregarmanual.UseVisualStyleBackColor = true;
            this.btnagregarmanual.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndeshacer
            // 
            this.btndeshacer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndeshacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndeshacer.FlatAppearance.BorderSize = 0;
            this.btndeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeshacer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndeshacer.Location = new System.Drawing.Point(61, 373);
            this.btndeshacer.Name = "btndeshacer";
            this.btndeshacer.Size = new System.Drawing.Size(175, 50);
            this.btndeshacer.TabIndex = 19;
            this.btndeshacer.Text = "Eliminar";
            this.btndeshacer.UseVisualStyleBackColor = false;
            // 
            // btnfacturar
            // 
            this.btnfacturar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfacturar.BackColor = System.Drawing.Color.LightGreen;
            this.btnfacturar.FlatAppearance.BorderSize = 0;
            this.btnfacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacturar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnfacturar.Location = new System.Drawing.Point(242, 373);
            this.btnfacturar.Name = "btnfacturar";
            this.btnfacturar.Size = new System.Drawing.Size(175, 50);
            this.btnfacturar.TabIndex = 20;
            this.btnfacturar.Text = "Facturar";
            this.btnfacturar.UseVisualStyleBackColor = false;
            this.btnfacturar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 501);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndeshacer;
        private System.Windows.Forms.Button btnagregarmanual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnfacturar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label1;
    }
}