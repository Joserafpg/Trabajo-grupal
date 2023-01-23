namespace Trabajo_grupal
{
    partial class Sub_Menú_Facturacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MET_PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREC_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITIBIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Factura,
            this.ID_CLIENTE,
            this.Nom_Cliente,
            this.MET_PAGO,
            this.Prod_Nombre,
            this.PREC_PRODUCTO,
            this.SubTotal,
            this.ITIBIS});
            this.dataGridView1.Location = new System.Drawing.Point(31, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(935, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de factura";
            // 
            // ID_Factura
            // 
            this.ID_Factura.HeaderText = "ID Factura";
            this.ID_Factura.Name = "ID_Factura";
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.HeaderText = "ID Cliente";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            // 
            // Nom_Cliente
            // 
            this.Nom_Cliente.HeaderText = "Nombre ";
            this.Nom_Cliente.Name = "Nom_Cliente";
            // 
            // MET_PAGO
            // 
            this.MET_PAGO.HeaderText = "Metodo de pago";
            this.MET_PAGO.Name = "MET_PAGO";
            // 
            // Prod_Nombre
            // 
            this.Prod_Nombre.HeaderText = "Producto";
            this.Prod_Nombre.Name = "Prod_Nombre";
            // 
            // PREC_PRODUCTO
            // 
            this.PREC_PRODUCTO.HeaderText = "Precio Producto";
            this.PREC_PRODUCTO.Name = "PREC_PRODUCTO";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // ITIBIS
            // 
            this.ITIBIS.HeaderText = "ITIBIS";
            this.ITIBIS.Name = "ITIBIS";
            // 
            // Sub_Menú_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sub_Menú_Facturacion";
            this.Text = "Sub_Menú_Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MET_PAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREC_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITIBIS;
    }
}