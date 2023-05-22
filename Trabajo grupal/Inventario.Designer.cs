namespace Trabajo_grupal
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.button4 = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnconsultaPantal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnconsultamateria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(228, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 52);
            this.button4.TabIndex = 10;
            this.button4.Text = "Agregar Nuevo Pantalon";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.LightGreen;
            this.agregar.FlatAppearance.BorderSize = 0;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agregar.Location = new System.Drawing.Point(228, 153);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(164, 52);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "Agregar Materia Prima";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnconsultaPantal);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnconsultamateria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.agregar);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(190, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 501);
            this.panel1.TabIndex = 11;
            // 
            // btnconsultaPantal
            // 
            this.btnconsultaPantal.BackColor = System.Drawing.Color.MistyRose;
            this.btnconsultaPantal.FlatAppearance.BorderSize = 0;
            this.btnconsultaPantal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultaPantal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultaPantal.ForeColor = System.Drawing.Color.Black;
            this.btnconsultaPantal.Location = new System.Drawing.Point(228, 399);
            this.btnconsultaPantal.Name = "btnconsultaPantal";
            this.btnconsultaPantal.Size = new System.Drawing.Size(164, 52);
            this.btnconsultaPantal.TabIndex = 15;
            this.btnconsultaPantal.Text = "Consulta de Pantalones";
            this.btnconsultaPantal.UseVisualStyleBackColor = false;
            this.btnconsultaPantal.Click += new System.EventHandler(this.btnconsultaPantal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnconsultamateria
            // 
            this.btnconsultamateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnconsultamateria.FlatAppearance.BorderSize = 0;
            this.btnconsultamateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultamateria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultamateria.ForeColor = System.Drawing.Color.Black;
            this.btnconsultamateria.Location = new System.Drawing.Point(228, 316);
            this.btnconsultamateria.Name = "btnconsultamateria";
            this.btnconsultamateria.Size = new System.Drawing.Size(164, 52);
            this.btnconsultamateria.TabIndex = 14;
            this.btnconsultamateria.Text = "Consulta Materia Prima";
            this.btnconsultamateria.UseVisualStyleBackColor = false;
            this.btnconsultamateria.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "INVENTARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 56);
            this.label1.TabIndex = 12;
            this.label1.Text = "PONEN JEANS";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(846, 501);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnconsultaPantal;
        private System.Windows.Forms.Button btnconsultamateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}