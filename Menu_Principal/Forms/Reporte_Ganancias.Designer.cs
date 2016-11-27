namespace Menu_Principal.Forms
{
    partial class Reporte_Ganancias
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
            this.CmbSocios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridGanancias = new System.Windows.Forms.DataGridView();
            this.CmbMes = new System.Windows.Forms.ComboBox();
            this.BExportar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.CmdCargarGrid = new System.Windows.Forms.Button();
            this.CmdLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridGanancias)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbSocios
            // 
            this.CmbSocios.FormattingEnabled = true;
            this.CmbSocios.Location = new System.Drawing.Point(275, 273);
            this.CmbSocios.Name = "CmbSocios";
            this.CmbSocios.Size = new System.Drawing.Size(121, 21);
            this.CmbSocios.TabIndex = 0;
            this.CmbSocios.Visible = false;
            this.CmbSocios.Click += new System.EventHandler(this.CmbSocios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Socio:";
            this.label1.Visible = false;
            // 
            // GridGanancias
            // 
            this.GridGanancias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridGanancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGanancias.Location = new System.Drawing.Point(12, 78);
            this.GridGanancias.Name = "GridGanancias";
            this.GridGanancias.Size = new System.Drawing.Size(592, 178);
            this.GridGanancias.TabIndex = 2;
            // 
            // CmbMes
            // 
            this.CmbMes.FormattingEnabled = true;
            this.CmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Nobiembre",
            "Dieciembre"});
            this.CmbMes.Location = new System.Drawing.Point(58, 12);
            this.CmbMes.Name = "CmbMes";
            this.CmbMes.Size = new System.Drawing.Size(121, 21);
            this.CmbMes.TabIndex = 3;
            // 
            // BExportar
            // 
            this.BExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BExportar.Location = new System.Drawing.Point(12, 262);
            this.BExportar.Name = "BExportar";
            this.BExportar.Size = new System.Drawing.Size(75, 23);
            this.BExportar.TabIndex = 4;
            this.BExportar.Text = "Exportar";
            this.BExportar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo";
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Detalle",
            "Global"});
            this.CmbTipo.Location = new System.Drawing.Point(255, 12);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(121, 21);
            this.CmbTipo.TabIndex = 7;
            // 
            // CmdCargarGrid
            // 
            this.CmdCargarGrid.Location = new System.Drawing.Point(12, 49);
            this.CmdCargarGrid.Name = "CmdCargarGrid";
            this.CmdCargarGrid.Size = new System.Drawing.Size(75, 23);
            this.CmdCargarGrid.TabIndex = 8;
            this.CmdCargarGrid.Text = "Actualizar";
            this.CmdCargarGrid.UseVisualStyleBackColor = true;
            this.CmdCargarGrid.Click += new System.EventHandler(this.CmdCargarGrid_Click);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdLimpiar.Location = new System.Drawing.Point(104, 262);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.CmdLimpiar.TabIndex = 8;
            this.CmdLimpiar.Text = "Limpiar";
            this.CmdLimpiar.UseVisualStyleBackColor = true;
            this.CmdLimpiar.Click += new System.EventHandler(this.CmdLimpiar_Click);
            // 
            // Reporte_Ganancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 297);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdCargarGrid);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BExportar);
            this.Controls.Add(this.CmbMes);
            this.Controls.Add(this.GridGanancias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSocios);
            this.Name = "Reporte_Ganancias";
            this.Text = "Reporte_Ganancias";
            this.Load += new System.EventHandler(this.Reporte_Ganancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridGanancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbSocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridGanancias;
        private System.Windows.Forms.ComboBox CmbMes;
        private System.Windows.Forms.Button BExportar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Button CmdCargarGrid;
        private System.Windows.Forms.Button CmdLimpiar;
    }
}