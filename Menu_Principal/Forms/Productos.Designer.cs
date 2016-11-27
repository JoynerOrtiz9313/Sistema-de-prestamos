namespace Menu_Principal.Forms
{
    partial class Productos
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
            this.lbcodigo = new System.Windows.Forms.Label();
            this.lbdescripcion = new System.Windows.Forms.Label();
            this.lbcosto = new System.Windows.Forms.Label();
            this.lbpreciov = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.TBDesc = new System.Windows.Forms.TextBox();
            this.TBCosto = new System.Windows.Forms.TextBox();
            this.TBPreciov = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBGanancia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigo.Location = new System.Drawing.Point(18, 19);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(49, 15);
            this.lbcodigo.TabIndex = 0;
            this.lbcodigo.Text = "Codigo:";
            // 
            // lbdescripcion
            // 
            this.lbdescripcion.AutoSize = true;
            this.lbdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdescripcion.Location = new System.Drawing.Point(112, 19);
            this.lbdescripcion.Name = "lbdescripcion";
            this.lbdescripcion.Size = new System.Drawing.Size(75, 15);
            this.lbdescripcion.TabIndex = 1;
            this.lbdescripcion.Text = "Descripcion:";
            // 
            // lbcosto
            // 
            this.lbcosto.AutoSize = true;
            this.lbcosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcosto.Location = new System.Drawing.Point(18, 61);
            this.lbcosto.Name = "lbcosto";
            this.lbcosto.Size = new System.Drawing.Size(41, 15);
            this.lbcosto.TabIndex = 2;
            this.lbcosto.Text = "Costo:";
            // 
            // lbpreciov
            // 
            this.lbpreciov.AutoSize = true;
            this.lbpreciov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpreciov.Location = new System.Drawing.Point(140, 61);
            this.lbpreciov.Name = "lbpreciov";
            this.lbpreciov.Size = new System.Drawing.Size(96, 15);
            this.lbpreciov.TabIndex = 3;
            this.lbpreciov.Text = "Precio de Venta:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(349, 137);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(69, 15);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "yyyy/mm/dd";
            // 
            // TBCodigo
            // 
            this.TBCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigo.Location = new System.Drawing.Point(21, 37);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(52, 21);
            this.TBCodigo.TabIndex = 5;
            this.TBCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigo_KeyPress);
            // 
            // TBDesc
            // 
            this.TBDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDesc.Location = new System.Drawing.Point(115, 37);
            this.TBDesc.Name = "TBDesc";
            this.TBDesc.Size = new System.Drawing.Size(209, 21);
            this.TBDesc.TabIndex = 6;
            // 
            // TBCosto
            // 
            this.TBCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCosto.Location = new System.Drawing.Point(21, 79);
            this.TBCosto.Name = "TBCosto";
            this.TBCosto.Size = new System.Drawing.Size(100, 21);
            this.TBCosto.TabIndex = 7;
            // 
            // TBPreciov
            // 
            this.TBPreciov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPreciov.Location = new System.Drawing.Point(143, 79);
            this.TBPreciov.Name = "TBPreciov";
            this.TBPreciov.Size = new System.Drawing.Size(100, 21);
            this.TBPreciov.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBGanancia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbFecha);
            this.groupBox1.Controls.Add(this.lbcodigo);
            this.groupBox1.Controls.Add(this.TBCodigo);
            this.groupBox1.Controls.Add(this.lbdescripcion);
            this.groupBox1.Controls.Add(this.TBPreciov);
            this.groupBox1.Controls.Add(this.TBDesc);
            this.groupBox1.Controls.Add(this.TBCosto);
            this.groupBox1.Controls.Add(this.lbpreciov);
            this.groupBox1.Controls.Add(this.lbcosto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 163);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles Del Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "% De Ganancia";
            // 
            // TBGanancia
            // 
            this.TBGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBGanancia.Location = new System.Drawing.Point(21, 131);
            this.TBGanancia.Name = "TBGanancia";
            this.TBGanancia.Size = new System.Drawing.Size(100, 21);
            this.TBGanancia.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha de Creacion:";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.Label lbdescripcion;
        private System.Windows.Forms.Label lbcosto;
        private System.Windows.Forms.Label lbpreciov;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.TextBox TBDesc;
        private System.Windows.Forms.TextBox TBCosto;
        private System.Windows.Forms.TextBox TBPreciov;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBGanancia;
        private System.Windows.Forms.Label label1;
    }
}