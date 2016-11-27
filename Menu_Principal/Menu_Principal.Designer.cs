namespace Menu_Principal
{
    partial class Menu_Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.BPrestamos = new System.Windows.Forms.Button();
            this.BVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Image = global::Menu_Principal.Properties.Resources.fondo1;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Prestamos y Ventas";
            // 
            // BPrestamos
            // 
            this.BPrestamos.BackgroundImage = global::Menu_Principal.Properties.Resources.fondo1;
            this.BPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPrestamos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BPrestamos.Location = new System.Drawing.Point(28, 93);
            this.BPrestamos.Name = "BPrestamos";
            this.BPrestamos.Size = new System.Drawing.Size(167, 74);
            this.BPrestamos.TabIndex = 1;
            this.BPrestamos.Text = "Prestamos";
            this.BPrestamos.UseVisualStyleBackColor = true;
            this.BPrestamos.Click += new System.EventHandler(this.BPrestamos_Click);
            // 
            // BVentas
            // 
            this.BVentas.BackgroundImage = global::Menu_Principal.Properties.Resources.fondo1;
            this.BVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVentas.ForeColor = System.Drawing.SystemColors.Control;
            this.BVentas.Location = new System.Drawing.Point(226, 93);
            this.BVentas.Name = "BVentas";
            this.BVentas.Size = new System.Drawing.Size(167, 74);
            this.BVentas.TabIndex = 2;
            this.BVentas.Text = "Ventas";
            this.BVentas.UseVisualStyleBackColor = true;
            this.BVentas.Click += new System.EventHandler(this.BVentas_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu_Principal.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(434, 212);
            this.Controls.Add(this.BVentas);
            this.Controls.Add(this.BPrestamos);
            this.Controls.Add(this.label1);
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BPrestamos;
        private System.Windows.Forms.Button BVentas;

    }
}