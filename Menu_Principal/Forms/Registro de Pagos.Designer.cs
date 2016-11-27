namespace Menu_Principal.Forms
{
    partial class Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtFechaPagoAdelantado = new System.Windows.Forms.DateTimePicker();
            this.ChkSaltarMora = new System.Windows.Forms.CheckBox();
            this.ChkPagoAdelantado = new System.Windows.Forms.CheckBox();
            this.TBBalancePendiente = new System.Windows.Forms.TextBox();
            this.TBCuota = new System.Windows.Forms.TextBox();
            this.TBFechafin = new System.Windows.Forms.TextBox();
            this.TBFechaPrestamo = new System.Windows.Forms.TextBox();
            this.TBIDPrestamo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblnombreCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBCliente = new System.Windows.Forms.TextBox();
            this.GridPagos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmdRegistrarPago = new System.Windows.Forms.Button();
            this.TBTotalPago = new System.Windows.Forms.TextBox();
            this.TBMontoInteres = new System.Windows.Forms.TextBox();
            this.TBMora = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPagos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtFechaPagoAdelantado);
            this.groupBox2.Controls.Add(this.ChkSaltarMora);
            this.groupBox2.Controls.Add(this.ChkPagoAdelantado);
            this.groupBox2.Controls.Add(this.TBBalancePendiente);
            this.groupBox2.Controls.Add(this.TBCuota);
            this.groupBox2.Controls.Add(this.TBFechafin);
            this.groupBox2.Controls.Add(this.TBFechaPrestamo);
            this.groupBox2.Controls.Add(this.TBIDPrestamo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 164);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prestamo";
            // 
            // DtFechaPagoAdelantado
            // 
            this.DtFechaPagoAdelantado.Enabled = false;
            this.DtFechaPagoAdelantado.Location = new System.Drawing.Point(138, 120);
            this.DtFechaPagoAdelantado.Name = "DtFechaPagoAdelantado";
            this.DtFechaPagoAdelantado.Size = new System.Drawing.Size(200, 20);
            this.DtFechaPagoAdelantado.TabIndex = 9;
            // 
            // ChkSaltarMora
            // 
            this.ChkSaltarMora.AutoSize = true;
            this.ChkSaltarMora.Location = new System.Drawing.Point(251, 90);
            this.ChkSaltarMora.Name = "ChkSaltarMora";
            this.ChkSaltarMora.Size = new System.Drawing.Size(80, 17);
            this.ChkSaltarMora.TabIndex = 8;
            this.ChkSaltarMora.Text = "Saltar Mora";
            this.ChkSaltarMora.UseVisualStyleBackColor = true;
            this.ChkSaltarMora.CheckedChanged += new System.EventHandler(this.ChkSaltarMora_CheckedChanged);
            // 
            // ChkPagoAdelantado
            // 
            this.ChkPagoAdelantado.AutoSize = true;
            this.ChkPagoAdelantado.Location = new System.Drawing.Point(138, 91);
            this.ChkPagoAdelantado.Name = "ChkPagoAdelantado";
            this.ChkPagoAdelantado.Size = new System.Drawing.Size(107, 17);
            this.ChkPagoAdelantado.TabIndex = 8;
            this.ChkPagoAdelantado.Text = "Pago adelantado";
            this.ChkPagoAdelantado.UseVisualStyleBackColor = true;
            this.ChkPagoAdelantado.CheckedChanged += new System.EventHandler(this.ChkPagoAdelantado_CheckedChanged);
            // 
            // TBBalancePendiente
            // 
            this.TBBalancePendiente.Enabled = false;
            this.TBBalancePendiente.Location = new System.Drawing.Point(10, 120);
            this.TBBalancePendiente.Name = "TBBalancePendiente";
            this.TBBalancePendiente.Size = new System.Drawing.Size(100, 20);
            this.TBBalancePendiente.TabIndex = 7;
            // 
            // TBCuota
            // 
            this.TBCuota.Location = new System.Drawing.Point(361, 120);
            this.TBCuota.Name = "TBCuota";
            this.TBCuota.Size = new System.Drawing.Size(124, 20);
            this.TBCuota.TabIndex = 1;
            this.TBCuota.TextChanged += new System.EventHandler(this.TBCuota_TextChanged);
            // 
            // TBFechafin
            // 
            this.TBFechafin.Enabled = false;
            this.TBFechafin.Location = new System.Drawing.Point(329, 49);
            this.TBFechafin.Name = "TBFechafin";
            this.TBFechafin.Size = new System.Drawing.Size(178, 20);
            this.TBFechafin.TabIndex = 6;
            this.TBFechafin.TextChanged += new System.EventHandler(this.TBFechafin_TextChanged);
            // 
            // TBFechaPrestamo
            // 
            this.TBFechaPrestamo.Enabled = false;
            this.TBFechaPrestamo.Location = new System.Drawing.Point(129, 49);
            this.TBFechaPrestamo.Name = "TBFechaPrestamo";
            this.TBFechaPrestamo.Size = new System.Drawing.Size(166, 20);
            this.TBFechaPrestamo.TabIndex = 5;
            // 
            // TBIDPrestamo
            // 
            this.TBIDPrestamo.Enabled = false;
            this.TBIDPrestamo.Location = new System.Drawing.Point(9, 49);
            this.TBIDPrestamo.Name = "TBIDPrestamo";
            this.TBIDPrestamo.Size = new System.Drawing.Size(66, 20);
            this.TBIDPrestamo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance Pendiente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto Cuota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha De Vencimiento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Del Prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No.Prestamo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblnombreCliente);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TBCliente);
            this.groupBox3.Location = new System.Drawing.Point(9, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 69);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Del Cliente";
            // 
            // LblnombreCliente
            // 
            this.LblnombreCliente.AutoSize = true;
            this.LblnombreCliente.Location = new System.Drawing.Point(208, 25);
            this.LblnombreCliente.Name = "LblnombreCliente";
            this.LblnombreCliente.Size = new System.Drawing.Size(10, 13);
            this.LblnombreCliente.TabIndex = 8;
            this.LblnombreCliente.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo Cliente";
            // 
            // TBCliente
            // 
            this.TBCliente.Location = new System.Drawing.Point(87, 25);
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.Size = new System.Drawing.Size(61, 20);
            this.TBCliente.TabIndex = 11;
            this.TBCliente.TextChanged += new System.EventHandler(this.TBCliente_TextChanged);
            this.TBCliente.Leave += new System.EventHandler(this.TBCliente_Leave);
            // 
            // GridPagos
            // 
            this.GridPagos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPagos.Location = new System.Drawing.Point(0, 286);
            this.GridPagos.Name = "GridPagos";
            this.GridPagos.Size = new System.Drawing.Size(678, 128);
            this.GridPagos.TabIndex = 31;
            this.GridPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPagos_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.guardarToolStripMenuItem.Text = "Limpiar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.modificarToolStripMenuItem.Text = "Plan de pago";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmdRegistrarPago);
            this.groupBox1.Controls.Add(this.TBTotalPago);
            this.groupBox1.Controls.Add(this.TBMontoInteres);
            this.groupBox1.Controls.Add(this.TBMora);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(528, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 253);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de pago";
            // 
            // CmdRegistrarPago
            // 
            this.CmdRegistrarPago.Location = new System.Drawing.Point(9, 210);
            this.CmdRegistrarPago.Name = "CmdRegistrarPago";
            this.CmdRegistrarPago.Size = new System.Drawing.Size(141, 37);
            this.CmdRegistrarPago.TabIndex = 2;
            this.CmdRegistrarPago.Text = "Registrar Pago";
            this.CmdRegistrarPago.UseVisualStyleBackColor = true;
            this.CmdRegistrarPago.Click += new System.EventHandler(this.CmdRegistrarPago_Click);
            // 
            // TBTotalPago
            // 
            this.TBTotalPago.Enabled = false;
            this.TBTotalPago.Location = new System.Drawing.Point(9, 173);
            this.TBTotalPago.Name = "TBTotalPago";
            this.TBTotalPago.Size = new System.Drawing.Size(124, 20);
            this.TBTotalPago.TabIndex = 1;
            // 
            // TBMontoInteres
            // 
            this.TBMontoInteres.Enabled = false;
            this.TBMontoInteres.Location = new System.Drawing.Point(9, 44);
            this.TBMontoInteres.Name = "TBMontoInteres";
            this.TBMontoInteres.Size = new System.Drawing.Size(124, 20);
            this.TBMontoInteres.TabIndex = 1;
            this.TBMontoInteres.TextChanged += new System.EventHandler(this.TBMontoInteres_TextChanged);
            // 
            // TBMora
            // 
            this.TBMora.Enabled = false;
            this.TBMora.Location = new System.Drawing.Point(9, 105);
            this.TBMora.Name = "TBMora";
            this.TBMora.Size = new System.Drawing.Size(124, 20);
            this.TBMora.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Monto a pagar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Monto Interes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Atraso Pendiente";
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridPagos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPagos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBBalancePendiente;
        private System.Windows.Forms.TextBox TBFechafin;
        private System.Windows.Forms.TextBox TBFechaPrestamo;
        private System.Windows.Forms.TextBox TBIDPrestamo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBCliente;
        private System.Windows.Forms.DataGridView GridPagos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBTotalPago;
        private System.Windows.Forms.TextBox TBMora;
        private System.Windows.Forms.TextBox TBCuota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CmdRegistrarPago;
        private System.Windows.Forms.TextBox TBMontoInteres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblnombreCliente;
        private System.Windows.Forms.DateTimePicker DtFechaPagoAdelantado;
        private System.Windows.Forms.CheckBox ChkPagoAdelantado;
        private System.Windows.Forms.CheckBox ChkSaltarMora;

    }
}