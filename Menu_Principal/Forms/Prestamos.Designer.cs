namespace Menu_Principal.Forms
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCedulaCliente = new System.Windows.Forms.TextBox();
            this.LblnombreCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.TxtCantCuotas = new System.Windows.Forms.TextBox();
            this.TxtGarantia = new System.Windows.Forms.TextBox();
            this.CmbTaza = new System.Windows.Forms.ComboBox();
            this.CmbFrecuencia = new System.Windows.Forms.ComboBox();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.CmbCobrador = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtmontoCuotas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.DtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ChkPorFrecuencia = new System.Windows.Forms.CheckBox();
            this.Chk_Amortizar = new System.Windows.Forms.CheckBox();
            this.ChkLineaDeCredito = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtDiaCobro = new System.Windows.Forms.NumericUpDown();
            this.TxtDiaCobro2 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiaCobro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiaCobro2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula Cliente";
            // 
            // TxtCedulaCliente
            // 
            this.TxtCedulaCliente.Location = new System.Drawing.Point(93, 34);
            this.TxtCedulaCliente.Name = "TxtCedulaCliente";
            this.TxtCedulaCliente.Size = new System.Drawing.Size(122, 20);
            this.TxtCedulaCliente.TabIndex = 0;
            this.TxtCedulaCliente.TextChanged += new System.EventHandler(this.TxtCedulaCliente_TextChanged);
            this.TxtCedulaCliente.Leave += new System.EventHandler(this.TxtCedulaCliente_Leave);
            // 
            // LblnombreCliente
            // 
            this.LblnombreCliente.AutoSize = true;
            this.LblnombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblnombreCliente.Location = new System.Drawing.Point(12, 66);
            this.LblnombreCliente.Name = "LblnombreCliente";
            this.LblnombreCliente.Size = new System.Drawing.Size(14, 17);
            this.LblnombreCliente.TabIndex = 3;
            this.LblnombreCliente.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto Prestamo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Taza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Frecuencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad de Cuotas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Garantia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(338, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cobrador";
            this.label8.Visible = false;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(22, 151);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(100, 20);
            this.TxtMonto.TabIndex = 1;
            this.TxtMonto.TextChanged += new System.EventHandler(this.TxtMonto_TextChanged);
            this.TxtMonto.Leave += new System.EventHandler(this.TxtMonto_Leave);
            // 
            // TxtCantCuotas
            // 
            this.TxtCantCuotas.Location = new System.Drawing.Point(194, 151);
            this.TxtCantCuotas.Name = "TxtCantCuotas";
            this.TxtCantCuotas.Size = new System.Drawing.Size(121, 20);
            this.TxtCantCuotas.TabIndex = 2;
            this.TxtCantCuotas.TextChanged += new System.EventHandler(this.TxtCantCuotas_TextChanged);
            this.TxtCantCuotas.Leave += new System.EventHandler(this.TxtCantCuotas_Leave);
            // 
            // TxtGarantia
            // 
            this.TxtGarantia.Location = new System.Drawing.Point(530, 203);
            this.TxtGarantia.Multiline = true;
            this.TxtGarantia.Name = "TxtGarantia";
            this.TxtGarantia.Size = new System.Drawing.Size(188, 89);
            this.TxtGarantia.TabIndex = 8;
            // 
            // CmbTaza
            // 
            this.CmbTaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTaza.FormattingEnabled = true;
            this.CmbTaza.Location = new System.Drawing.Point(22, 208);
            this.CmbTaza.Name = "CmbTaza";
            this.CmbTaza.Size = new System.Drawing.Size(121, 21);
            this.CmbTaza.TabIndex = 12;
            this.CmbTaza.SelectedIndexChanged += new System.EventHandler(this.CmbTaza_SelectedIndexChanged);
            // 
            // CmbFrecuencia
            // 
            this.CmbFrecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFrecuencia.FormattingEnabled = true;
            this.CmbFrecuencia.Location = new System.Drawing.Point(22, 268);
            this.CmbFrecuencia.Name = "CmbFrecuencia";
            this.CmbFrecuencia.Size = new System.Drawing.Size(121, 21);
            this.CmbFrecuencia.TabIndex = 12;
            this.CmbFrecuencia.SelectedIndexChanged += new System.EventHandler(this.CmbFrecuencia_SelectedIndexChanged);
            this.CmbFrecuencia.SelectedValueChanged += new System.EventHandler(this.CmbFrecuencia_SelectedValueChanged);
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(194, 208);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(121, 21);
            this.CmbTipo.TabIndex = 12;
            // 
            // CmbCobrador
            // 
            this.CmbCobrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCobrador.Enabled = false;
            this.CmbCobrador.FormattingEnabled = true;
            this.CmbCobrador.Location = new System.Drawing.Point(341, 151);
            this.CmbCobrador.Name = "CmbCobrador";
            this.CmbCobrador.Size = new System.Drawing.Size(121, 21);
            this.CmbCobrador.TabIndex = 12;
            this.CmbCobrador.Visible = false;
            this.CmbCobrador.SelectedIndexChanged += new System.EventHandler(this.CmbCobrador_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.mantenimientoToolStripMenuItem.Text = "Nuevo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Monto Cuotas";
            // 
            // TxtmontoCuotas
            // 
            this.TxtmontoCuotas.Enabled = false;
            this.TxtmontoCuotas.Location = new System.Drawing.Point(533, 154);
            this.TxtmontoCuotas.Name = "TxtmontoCuotas";
            this.TxtmontoCuotas.Size = new System.Drawing.Size(158, 20);
            this.TxtmontoCuotas.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Monto Total";
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.Enabled = false;
            this.TxtMontoTotal.Location = new System.Drawing.Point(533, 112);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.Size = new System.Drawing.Size(158, 20);
            this.TxtMontoTotal.TabIndex = 3;
            // 
            // DtFechaInicio
            // 
            this.DtFechaInicio.Location = new System.Drawing.Point(518, 34);
            this.DtFechaInicio.Name = "DtFechaInicio";
            this.DtFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.DtFechaInicio.TabIndex = 14;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(518, 58);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFin.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fecha Inicio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Fecha Fin";
            // 
            // ChkPorFrecuencia
            // 
            this.ChkPorFrecuencia.AutoSize = true;
            this.ChkPorFrecuencia.Location = new System.Drawing.Point(48, 188);
            this.ChkPorFrecuencia.Name = "ChkPorFrecuencia";
            this.ChkPorFrecuencia.Size = new System.Drawing.Size(95, 17);
            this.ChkPorFrecuencia.TabIndex = 15;
            this.ChkPorFrecuencia.Text = "Por frecuencia";
            this.ChkPorFrecuencia.UseVisualStyleBackColor = true;
            this.ChkPorFrecuencia.Visible = false;
            this.ChkPorFrecuencia.CheckedChanged += new System.EventHandler(this.ChkPorFrecuencia_CheckedChanged);
            // 
            // Chk_Amortizar
            // 
            this.Chk_Amortizar.AutoSize = true;
            this.Chk_Amortizar.Location = new System.Drawing.Point(15, 109);
            this.Chk_Amortizar.Name = "Chk_Amortizar";
            this.Chk_Amortizar.Size = new System.Drawing.Size(69, 17);
            this.Chk_Amortizar.TabIndex = 15;
            this.Chk_Amortizar.Text = "Amortizar";
            this.Chk_Amortizar.UseVisualStyleBackColor = true;
            this.Chk_Amortizar.CheckedChanged += new System.EventHandler(this.Chk_Amortizar_CheckedChanged);
            // 
            // ChkLineaDeCredito
            // 
            this.ChkLineaDeCredito.AutoSize = true;
            this.ChkLineaDeCredito.Location = new System.Drawing.Point(194, 109);
            this.ChkLineaDeCredito.Name = "ChkLineaDeCredito";
            this.ChkLineaDeCredito.Size = new System.Drawing.Size(103, 17);
            this.ChkLineaDeCredito.TabIndex = 16;
            this.ChkLineaDeCredito.Text = "Linea de Credito";
            this.ChkLineaDeCredito.UseVisualStyleBackColor = true;
            this.ChkLineaDeCredito.CheckedChanged += new System.EventHandler(this.ChkLineaDeCredito_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Cobrar los dias:";
            // 
            // TxtDiaCobro
            // 
            this.TxtDiaCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiaCobro.Location = new System.Drawing.Point(266, 248);
            this.TxtDiaCobro.Name = "TxtDiaCobro";
            this.TxtDiaCobro.Size = new System.Drawing.Size(47, 23);
            this.TxtDiaCobro.TabIndex = 18;
            this.TxtDiaCobro.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.TxtDiaCobro.ValueChanged += new System.EventHandler(this.TxtDiaCobro_ValueChanged);
            // 
            // TxtDiaCobro2
            // 
            this.TxtDiaCobro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDiaCobro2.Location = new System.Drawing.Point(266, 275);
            this.TxtDiaCobro2.Name = "TxtDiaCobro2";
            this.TxtDiaCobro2.Size = new System.Drawing.Size(47, 23);
            this.TxtDiaCobro2.TabIndex = 20;
            this.TxtDiaCobro2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.TxtDiaCobro2.Visible = false;
            this.TxtDiaCobro2.ValueChanged += new System.EventHandler(this.TxtDiaCobro2_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(182, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Y los";
            this.label14.Visible = false;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 318);
            this.Controls.Add(this.TxtDiaCobro2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtDiaCobro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ChkLineaDeCredito);
            this.Controls.Add(this.Chk_Amortizar);
            this.Controls.Add(this.ChkPorFrecuencia);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.DtFechaInicio);
            this.Controls.Add(this.CmbCobrador);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.CmbFrecuencia);
            this.Controls.Add(this.CmbTaza);
            this.Controls.Add(this.TxtGarantia);
            this.Controls.Add(this.TxtCantCuotas);
            this.Controls.Add(this.TxtMontoTotal);
            this.Controls.Add(this.TxtmontoCuotas);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblnombreCliente);
            this.Controls.Add(this.TxtCedulaCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiaCobro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDiaCobro2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCedulaCliente;
        private System.Windows.Forms.Label LblnombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.TextBox TxtCantCuotas;
        private System.Windows.Forms.TextBox TxtGarantia;
        private System.Windows.Forms.ComboBox CmbTaza;
        private System.Windows.Forms.ComboBox CmbFrecuencia;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.ComboBox CmbCobrador;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtmontoCuotas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtMontoTotal;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.CheckBox ChkPorFrecuencia;
        private System.Windows.Forms.CheckBox Chk_Amortizar;
        private System.Windows.Forms.CheckBox ChkLineaDeCredito;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown TxtDiaCobro;
        private System.Windows.Forms.NumericUpDown TxtDiaCobro2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DtFechaInicio;
    }
}