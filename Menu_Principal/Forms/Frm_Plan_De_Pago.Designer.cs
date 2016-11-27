namespace Menu_Principal.Forms
{
    partial class Frm_Plan_De_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Plan_De_Pago));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblMoraAcumulada = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblMontoPendiente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_ID_Prestamo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblInteres = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblMonto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LstPagos = new System.Windows.Forms.ListView();
            this.Cuota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Interes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiasAtraso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.TxtTotal_Mora = new System.Windows.Forms.TextBox();
            this.TxtTotal_Cuotas = new System.Windows.Forms.TextBox();
            this.Txt_Total_Pagos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdQuitar = new System.Windows.Forms.Button();
            this.ChkMora = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtTotal_A_Pagar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTotalMora = new System.Windows.Forms.TextBox();
            this.TxtCantCuotas = new System.Windows.Forms.TextBox();
            this.TxtTotalCuotas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblMoraAcumulada);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.LblMontoPendiente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Lbl_ID_Prestamo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblInteres);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LblMonto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LblNombreCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del prestamo";
            // 
            // LblMoraAcumulada
            // 
            this.LblMoraAcumulada.AutoSize = true;
            this.LblMoraAcumulada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoraAcumulada.Location = new System.Drawing.Point(437, 70);
            this.LblMoraAcumulada.Name = "LblMoraAcumulada";
            this.LblMoraAcumulada.Size = new System.Drawing.Size(15, 15);
            this.LblMoraAcumulada.TabIndex = 0;
            this.LblMoraAcumulada.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mora acumulada";
            // 
            // LblMontoPendiente
            // 
            this.LblMontoPendiente.AutoSize = true;
            this.LblMontoPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMontoPendiente.Location = new System.Drawing.Point(238, 70);
            this.LblMontoPendiente.Name = "LblMontoPendiente";
            this.LblMontoPendiente.Size = new System.Drawing.Size(15, 15);
            this.LblMontoPendiente.TabIndex = 0;
            this.LblMontoPendiente.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pendiente";
            // 
            // Lbl_ID_Prestamo
            // 
            this.Lbl_ID_Prestamo.AutoSize = true;
            this.Lbl_ID_Prestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID_Prestamo.Location = new System.Drawing.Point(97, 70);
            this.Lbl_ID_Prestamo.Name = "Lbl_ID_Prestamo";
            this.Lbl_ID_Prestamo.Size = new System.Drawing.Size(15, 15);
            this.Lbl_ID_Prestamo.TabIndex = 0;
            this.Lbl_ID_Prestamo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID_Prestamo";
            // 
            // LblInteres
            // 
            this.LblInteres.AutoSize = true;
            this.LblInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInteres.Location = new System.Drawing.Point(437, 26);
            this.LblInteres.Name = "LblInteres";
            this.LblInteres.Size = new System.Drawing.Size(15, 15);
            this.LblInteres.TabIndex = 0;
            this.LblInteres.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Interes";
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.Location = new System.Drawing.Point(238, 26);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(15, 15);
            this.LblMonto.TabIndex = 0;
            this.LblMonto.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto";
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCliente.Location = new System.Drawing.Point(66, 26);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(12, 15);
            this.LblNombreCliente.TabIndex = 0;
            this.LblNombreCliente.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LstPagos);
            this.groupBox2.Location = new System.Drawing.Point(9, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plan de pago";
            // 
            // LstPagos
            // 
            this.LstPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstPagos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cuota,
            this.Mora,
            this.Interes,
            this.TotalPago,
            this.Fecha,
            this.DiasAtraso});
            this.LstPagos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstPagos.Location = new System.Drawing.Point(6, 19);
            this.LstPagos.Name = "LstPagos";
            this.LstPagos.Size = new System.Drawing.Size(674, 169);
            this.LstPagos.TabIndex = 0;
            this.LstPagos.UseCompatibleStateImageBehavior = false;
            this.LstPagos.View = System.Windows.Forms.View.Details;
            // 
            // Cuota
            // 
            this.Cuota.Text = "Cuota";
            this.Cuota.Width = 100;
            // 
            // Mora
            // 
            this.Mora.Text = "Mora";
            this.Mora.Width = 120;
            // 
            // Interes
            // 
            this.Interes.Text = "Interes";
            this.Interes.Width = 120;
            // 
            // TotalPago
            // 
            this.TotalPago.Text = "Total  a pagar";
            this.TotalPago.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.Text = "A la fecha";
            this.Fecha.Width = 120;
            // 
            // DiasAtraso
            // 
            this.DiasAtraso.Text = "Dias atraso";
            this.DiasAtraso.Width = 80;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.TxtTotal);
            this.groupBox3.Controls.Add(this.Lbl_Total);
            this.groupBox3.Controls.Add(this.TxtTotal_Mora);
            this.groupBox3.Controls.Add(this.TxtTotal_Cuotas);
            this.groupBox3.Controls.Add(this.Txt_Total_Pagos);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(495, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informe Pagos";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotal.Location = new System.Drawing.Point(94, 98);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 7;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Location = new System.Drawing.Point(6, 101);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(31, 13);
            this.Lbl_Total.TabIndex = 6;
            this.Lbl_Total.Text = "Total";
            // 
            // TxtTotal_Mora
            // 
            this.TxtTotal_Mora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotal_Mora.Location = new System.Drawing.Point(94, 67);
            this.TxtTotal_Mora.Name = "TxtTotal_Mora";
            this.TxtTotal_Mora.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal_Mora.TabIndex = 5;
            // 
            // TxtTotal_Cuotas
            // 
            this.TxtTotal_Cuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotal_Cuotas.Location = new System.Drawing.Point(94, 41);
            this.TxtTotal_Cuotas.Name = "TxtTotal_Cuotas";
            this.TxtTotal_Cuotas.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal_Cuotas.TabIndex = 5;
            // 
            // Txt_Total_Pagos
            // 
            this.Txt_Total_Pagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Total_Pagos.Location = new System.Drawing.Point(94, 13);
            this.Txt_Total_Pagos.Name = "Txt_Total_Pagos";
            this.Txt_Total_Pagos.Size = new System.Drawing.Size(100, 20);
            this.Txt_Total_Pagos.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total Mora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Cuota(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad Cuotas";
            // 
            // CmdAdd
            // 
            this.CmdAdd.Location = new System.Drawing.Point(15, 110);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(75, 23);
            this.CmdAdd.TabIndex = 1;
            this.CmdAdd.Text = "Añadir";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // CmdQuitar
            // 
            this.CmdQuitar.Location = new System.Drawing.Point(96, 110);
            this.CmdQuitar.Name = "CmdQuitar";
            this.CmdQuitar.Size = new System.Drawing.Size(75, 23);
            this.CmdQuitar.TabIndex = 1;
            this.CmdQuitar.Text = "Quitar";
            this.CmdQuitar.UseVisualStyleBackColor = true;
            this.CmdQuitar.Click += new System.EventHandler(this.CmdQuitar_Click);
            // 
            // ChkMora
            // 
            this.ChkMora.AutoSize = true;
            this.ChkMora.Location = new System.Drawing.Point(187, 114);
            this.ChkMora.Name = "ChkMora";
            this.ChkMora.Size = new System.Drawing.Size(99, 17);
            this.ChkMora.TabIndex = 3;
            this.ChkMora.Text = "Descartar Mora";
            this.ChkMora.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.TxtTotal_A_Pagar);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.TxtTotalMora);
            this.groupBox4.Controls.Add(this.TxtCantCuotas);
            this.groupBox4.Controls.Add(this.TxtTotalCuotas);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(495, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 144);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informe Pagos";
            // 
            // TxtTotal_A_Pagar
            // 
            this.TxtTotal_A_Pagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotal_A_Pagar.Enabled = false;
            this.TxtTotal_A_Pagar.Location = new System.Drawing.Point(94, 98);
            this.TxtTotal_A_Pagar.Name = "TxtTotal_A_Pagar";
            this.TxtTotal_A_Pagar.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal_A_Pagar.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total";
            // 
            // TxtTotalMora
            // 
            this.TxtTotalMora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotalMora.Enabled = false;
            this.TxtTotalMora.Location = new System.Drawing.Point(94, 67);
            this.TxtTotalMora.Name = "TxtTotalMora";
            this.TxtTotalMora.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalMora.TabIndex = 5;
            // 
            // TxtCantCuotas
            // 
            this.TxtCantCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCantCuotas.Enabled = false;
            this.TxtCantCuotas.Location = new System.Drawing.Point(94, 12);
            this.TxtCantCuotas.Name = "TxtCantCuotas";
            this.TxtCantCuotas.Size = new System.Drawing.Size(100, 20);
            this.TxtCantCuotas.TabIndex = 5;
            // 
            // TxtTotalCuotas
            // 
            this.TxtTotalCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotalCuotas.Enabled = false;
            this.TxtTotalCuotas.Location = new System.Drawing.Point(94, 39);
            this.TxtTotalCuotas.Name = "TxtTotalCuotas";
            this.TxtTotalCuotas.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalCuotas.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Total Mora";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Total Cuota(s)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Cantidad Cuotas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Efectuar Pagos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_Plan_De_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(707, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChkMora);
            this.Controls.Add(this.CmdQuitar);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Plan_De_Pago";
            this.Text = "Planificación de pago";
            this.Load += new System.EventHandler(this.Frm_Plan_De_Pago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblMoraAcumulada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblMontoPendiente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_ID_Prestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblInteres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView LstPagos;
        private System.Windows.Forms.ColumnHeader Cuota;
        private System.Windows.Forms.ColumnHeader Mora;
        private System.Windows.Forms.ColumnHeader Interes;
        private System.Windows.Forms.ColumnHeader TotalPago;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.Button CmdQuitar;
        private System.Windows.Forms.ColumnHeader DiasAtraso;
        private System.Windows.Forms.CheckBox ChkMora;
        private System.Windows.Forms.TextBox TxtTotal_Mora;
        private System.Windows.Forms.TextBox TxtTotal_Cuotas;
        private System.Windows.Forms.TextBox Txt_Total_Pagos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtTotal_A_Pagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTotalMora;
        private System.Windows.Forms.TextBox TxtCantCuotas;
        private System.Windows.Forms.TextBox TxtTotalCuotas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}