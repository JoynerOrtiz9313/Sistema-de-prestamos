namespace Menu_Principal
{
    partial class Sistema_de_Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema_de_Prestamos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GridPagosP = new System.Windows.Forms.DataGridView();
            this.Aplicar_Pago = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPrestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tazasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPagosP)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.cierreToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.tazasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 75);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GridPagosP
            // 
            this.GridPagosP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPagosP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPagosP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aplicar_Pago});
            this.GridPagosP.Location = new System.Drawing.Point(12, 238);
            this.GridPagosP.Name = "GridPagosP";
            this.GridPagosP.Size = new System.Drawing.Size(652, 150);
            this.GridPagosP.TabIndex = 1;
            this.GridPagosP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Aplicar_Pago
            // 
            this.Aplicar_Pago.HeaderText = "Aplicar_Pago";
            this.Aplicar_Pago.Name = "Aplicar_Pago";
            this.Aplicar_Pago.Text = "Aplicar";
            this.Aplicar_Pago.ToolTipText = "Aplicar";
            // 
            // button1
            // 
            this.button1.Image = global::Menu_Principal.Properties.Resources.charIcon_billings;
            this.button1.Location = new System.Drawing.Point(12, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 154);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.clientesToolStripMenuItem.Image = global::Menu_Principal.Properties.Resources.abonado;
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(118, 71);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPrestaToolStripMenuItem,
            this.mToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.prestamosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.prestamosToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.prestamosToolStripMenuItem.Image = global::Menu_Principal.Properties.Resources.boleta;
            this.prestamosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(136, 71);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            this.prestamosToolStripMenuItem.Click += new System.EventHandler(this.prestamosToolStripMenuItem_Click);
            // 
            // nuevoPrestaToolStripMenuItem
            // 
            this.nuevoPrestaToolStripMenuItem.Name = "nuevoPrestaToolStripMenuItem";
            this.nuevoPrestaToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.nuevoPrestaToolStripMenuItem.Text = "Nuevo Prestamos";
            this.nuevoPrestaToolStripMenuItem.Click += new System.EventHandler(this.nuevoPrestaToolStripMenuItem_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.mToolStripMenuItem.Text = "Prestamos a Cobrar";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // cierreToolStripMenuItem
            // 
            this.cierreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cierreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cierreToolStripMenuItem.Image = global::Menu_Principal.Properties.Resources.lugar;
            this.cierreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cierreToolStripMenuItem.Name = "cierreToolStripMenuItem";
            this.cierreToolStripMenuItem.Size = new System.Drawing.Size(107, 71);
            this.cierreToolStripMenuItem.Text = "Gastos";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vToolStripMenuItem,
            this.prestamosToolStripMenuItem1,
            this.gananciasToolStripMenuItem,
            this.dataCreditoToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.consultasToolStripMenuItem.Image = global::Menu_Principal.Properties.Resources.reportes;
            this.consultasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(121, 71);
            this.consultasToolStripMenuItem.Text = "Reportes";
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.vToolStripMenuItem.Text = "Clientes";
            this.vToolStripMenuItem.Click += new System.EventHandler(this.vToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem1
            // 
            this.prestamosToolStripMenuItem1.Name = "prestamosToolStripMenuItem1";
            this.prestamosToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.prestamosToolStripMenuItem1.Text = "Prestamos";
            // 
            // gananciasToolStripMenuItem
            // 
            this.gananciasToolStripMenuItem.Name = "gananciasToolStripMenuItem";
            this.gananciasToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.gananciasToolStripMenuItem.Text = "Ganancias";
            this.gananciasToolStripMenuItem.Click += new System.EventHandler(this.gananciasToolStripMenuItem_Click);
            // 
            // dataCreditoToolStripMenuItem
            // 
            this.dataCreditoToolStripMenuItem.Name = "dataCreditoToolStripMenuItem";
            this.dataCreditoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.dataCreditoToolStripMenuItem.Text = "Data Credito";
            // 
            // tazasToolStripMenuItem
            // 
            this.tazasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tazasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tazasToolStripMenuItem.Image = global::Menu_Principal.Properties.Resources.Icon;
            this.tazasToolStripMenuItem.Name = "tazasToolStripMenuItem";
            this.tazasToolStripMenuItem.Size = new System.Drawing.Size(80, 71);
            this.tazasToolStripMenuItem.Text = "Tazas";
            this.tazasToolStripMenuItem.Click += new System.EventHandler(this.tazasToolStripMenuItem_Click);
            // 
            // Sistema_de_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridPagosP);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sistema_de_Prestamos";
            this.Text = "Prestamos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sistema_de_Prestamos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPagosP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPrestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cierreToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tazasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasToolStripMenuItem;
        private System.Windows.Forms.DataGridView GridPagosP;
        private System.Windows.Forms.ToolStripMenuItem dataCreditoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Aplicar_Pago;

    }
}

