namespace WindowsFormsApp3
{
    partial class Pagar_Inversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagar_Inversion));
            this.pnl_pagobancario = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_tipocuenta = new System.Windows.Forms.ComboBox();
            this.txb_banco = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txb_numerocuenta = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txb_codigotransaccionpagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_buscarpagar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_pagar = new System.Windows.Forms.Panel();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_comprobante = new System.Windows.Forms.Label();
            this.lbl_modalidad = new System.Windows.Forms.Label();
            this.lbl_fchplaneada = new System.Windows.Forms.Label();
            this.lbl_fchefectiva = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_tasa = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_cuota = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_comprobante = new System.Windows.Forms.TextBox();
            this.cbx_modalidad = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_pagartransaccion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_pagobancario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_pagar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_pagobancario
            // 
            this.pnl_pagobancario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_pagobancario.Controls.Add(this.label12);
            this.pnl_pagobancario.Controls.Add(this.cbx_tipocuenta);
            this.pnl_pagobancario.Controls.Add(this.txb_banco);
            this.pnl_pagobancario.Controls.Add(this.label17);
            this.pnl_pagobancario.Controls.Add(this.label18);
            this.pnl_pagobancario.Controls.Add(this.txb_numerocuenta);
            this.pnl_pagobancario.Controls.Add(this.label19);
            this.pnl_pagobancario.Enabled = false;
            this.pnl_pagobancario.Location = new System.Drawing.Point(134, 83);
            this.pnl_pagobancario.Name = "pnl_pagobancario";
            this.pnl_pagobancario.Size = new System.Drawing.Size(258, 111);
            this.pnl_pagobancario.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "TRANSACCIÓN INVERSION";
            // 
            // cbx_tipocuenta
            // 
            this.cbx_tipocuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipocuenta.FormattingEnabled = true;
            this.cbx_tipocuenta.Items.AddRange(new object[] {
            "CORRIENTE",
            "AHORROS"});
            this.cbx_tipocuenta.Location = new System.Drawing.Point(113, 78);
            this.cbx_tipocuenta.MaxLength = 20;
            this.cbx_tipocuenta.Name = "cbx_tipocuenta";
            this.cbx_tipocuenta.Size = new System.Drawing.Size(135, 21);
            this.cbx_tipocuenta.TabIndex = 26;
            this.cbx_tipocuenta.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txb_banco
            // 
            this.txb_banco.FormattingEnabled = true;
            this.txb_banco.Location = new System.Drawing.Point(113, 51);
            this.txb_banco.MaxLength = 50;
            this.txb_banco.Name = "txb_banco";
            this.txb_banco.Size = new System.Drawing.Size(135, 21);
            this.txb_banco.TabIndex = 25;
            this.txb_banco.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "TIPO DE CUENTA";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "BANCO";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txb_numerocuenta
            // 
            this.txb_numerocuenta.Location = new System.Drawing.Point(113, 24);
            this.txb_numerocuenta.MaxLength = 20;
            this.txb_numerocuenta.Name = "txb_numerocuenta";
            this.txb_numerocuenta.Size = new System.Drawing.Size(135, 20);
            this.txb_numerocuenta.TabIndex = 13;
            this.txb_numerocuenta.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            this.txb_numerocuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numerocuenta_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "# CUENTA";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // txb_codigotransaccionpagar
            // 
            this.txb_codigotransaccionpagar.Location = new System.Drawing.Point(142, 46);
            this.txb_codigotransaccionpagar.MaxLength = 8;
            this.txb_codigotransaccionpagar.Name = "txb_codigotransaccionpagar";
            this.txb_codigotransaccionpagar.Size = new System.Drawing.Size(135, 20);
            this.txb_codigotransaccionpagar.TabIndex = 30;
            this.txb_codigotransaccionpagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_codigotransaccionpagar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "COD.  TRANSACCIÓN";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(102, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "PAGAR TRANSACCIÓN";
            // 
            // btn_buscarpagar
            // 
            this.btn_buscarpagar.Location = new System.Drawing.Point(200, 72);
            this.btn_buscarpagar.Name = "btn_buscarpagar";
            this.btn_buscarpagar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarpagar.TabIndex = 31;
            this.btn_buscarpagar.Text = "BUSCAR";
            this.btn_buscarpagar.UseVisualStyleBackColor = true;
            this.btn_buscarpagar.Click += new System.EventHandler(this.btn_buscarpagar_cLICK);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_buscarpagar);
            this.panel1.Controls.Add(this.txb_codigotransaccionpagar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(100, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 111);
            this.panel1.TabIndex = 32;
            // 
            // pnl_pagar
            // 
            this.pnl_pagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_pagar.Controls.Add(this.lbl_direccion);
            this.pnl_pagar.Controls.Add(this.lbl_nombre);
            this.pnl_pagar.Controls.Add(this.label8);
            this.pnl_pagar.Controls.Add(this.label123);
            this.pnl_pagar.Controls.Add(this.label2);
            this.pnl_pagar.Controls.Add(this.lbl_comprobante);
            this.pnl_pagar.Controls.Add(this.lbl_modalidad);
            this.pnl_pagar.Controls.Add(this.lbl_fchplaneada);
            this.pnl_pagar.Controls.Add(this.lbl_fchefectiva);
            this.pnl_pagar.Controls.Add(this.lbl_estado);
            this.pnl_pagar.Controls.Add(this.lbl_tasa);
            this.pnl_pagar.Controls.Add(this.lbl_valor);
            this.pnl_pagar.Controls.Add(this.lbl_cuota);
            this.pnl_pagar.Controls.Add(this.panel3);
            this.pnl_pagar.Controls.Add(this.label10);
            this.pnl_pagar.Controls.Add(this.label9);
            this.pnl_pagar.Controls.Add(this.label7);
            this.pnl_pagar.Controls.Add(this.label6);
            this.pnl_pagar.Controls.Add(this.label5);
            this.pnl_pagar.Controls.Add(this.btn_pagartransaccion);
            this.pnl_pagar.Controls.Add(this.label4);
            this.pnl_pagar.Controls.Add(this.label3);
            this.pnl_pagar.Location = new System.Drawing.Point(8, 126);
            this.pnl_pagar.Name = "pnl_pagar";
            this.pnl_pagar.Size = new System.Drawing.Size(536, 380);
            this.pnl_pagar.TabIndex = 33;
            this.pnl_pagar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(412, 13);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(10, 13);
            this.lbl_direccion.TabIndex = 44;
            this.lbl_direccion.Text = ".";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(79, 13);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(10, 13);
            this.lbl_nombre.TabIndex = 43;
            this.lbl_nombre.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "DIRECCION";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(6, 13);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(54, 13);
            this.label123.TabIndex = 41;
            this.label123.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "FECHA EFECTIVA";
            // 
            // lbl_comprobante
            // 
            this.lbl_comprobante.AutoSize = true;
            this.lbl_comprobante.Location = new System.Drawing.Point(412, 108);
            this.lbl_comprobante.Name = "lbl_comprobante";
            this.lbl_comprobante.Size = new System.Drawing.Size(10, 13);
            this.lbl_comprobante.TabIndex = 39;
            this.lbl_comprobante.Text = ".";
            // 
            // lbl_modalidad
            // 
            this.lbl_modalidad.AutoSize = true;
            this.lbl_modalidad.Location = new System.Drawing.Point(412, 85);
            this.lbl_modalidad.Name = "lbl_modalidad";
            this.lbl_modalidad.Size = new System.Drawing.Size(10, 13);
            this.lbl_modalidad.TabIndex = 38;
            this.lbl_modalidad.Text = ".";
            // 
            // lbl_fchplaneada
            // 
            this.lbl_fchplaneada.AutoSize = true;
            this.lbl_fchplaneada.Location = new System.Drawing.Point(412, 60);
            this.lbl_fchplaneada.Name = "lbl_fchplaneada";
            this.lbl_fchplaneada.Size = new System.Drawing.Size(10, 13);
            this.lbl_fchplaneada.TabIndex = 36;
            this.lbl_fchplaneada.Text = ".";
            // 
            // lbl_fchefectiva
            // 
            this.lbl_fchefectiva.AutoSize = true;
            this.lbl_fchefectiva.Location = new System.Drawing.Point(412, 34);
            this.lbl_fchefectiva.Name = "lbl_fchefectiva";
            this.lbl_fchefectiva.Size = new System.Drawing.Size(10, 13);
            this.lbl_fchefectiva.TabIndex = 35;
            this.lbl_fchefectiva.Text = ".";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(79, 108);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(10, 13);
            this.lbl_estado.TabIndex = 34;
            this.lbl_estado.Text = ".";
            // 
            // lbl_tasa
            // 
            this.lbl_tasa.AutoSize = true;
            this.lbl_tasa.Location = new System.Drawing.Point(79, 84);
            this.lbl_tasa.Name = "lbl_tasa";
            this.lbl_tasa.Size = new System.Drawing.Size(10, 13);
            this.lbl_tasa.TabIndex = 33;
            this.lbl_tasa.Text = ".";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(79, 61);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(10, 13);
            this.lbl_valor.TabIndex = 32;
            this.lbl_valor.Text = ".";
            // 
            // lbl_cuota
            // 
            this.lbl_cuota.AutoSize = true;
            this.lbl_cuota.Location = new System.Drawing.Point(79, 39);
            this.lbl_cuota.Name = "lbl_cuota";
            this.lbl_cuota.Size = new System.Drawing.Size(10, 13);
            this.lbl_cuota.TabIndex = 31;
            this.lbl_cuota.Text = ".";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txb_comprobante);
            this.panel3.Controls.Add(this.cbx_modalidad);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.pnl_pagobancario);
            this.panel3.Location = new System.Drawing.Point(3, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 206);
            this.panel3.TabIndex = 29;
            // 
            // txb_comprobante
            // 
            this.txb_comprobante.Location = new System.Drawing.Point(233, 55);
            this.txb_comprobante.MaxLength = 20;
            this.txb_comprobante.Name = "txb_comprobante";
            this.txb_comprobante.Size = new System.Drawing.Size(144, 20);
            this.txb_comprobante.TabIndex = 30;
            // 
            // cbx_modalidad
            // 
            this.cbx_modalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_modalidad.FormattingEnabled = true;
            this.cbx_modalidad.Items.AddRange(new object[] {
            "BANCARIA",
            "EFECTIVO",
            "CHEQUE"});
            this.cbx_modalidad.Location = new System.Drawing.Point(233, 23);
            this.cbx_modalidad.MaxLength = 20;
            this.cbx_modalidad.Name = "cbx_modalidad";
            this.cbx_modalidad.Size = new System.Drawing.Size(144, 21);
            this.cbx_modalidad.TabIndex = 29;
            this.cbx_modalidad.SelectedIndexChanged += new System.EventHandler(this.cbx_modalidad_SelectedIndexChanged);
            this.cbx_modalidad.SelectionChangeCommitted += new System.EventHandler(this.cbx_modalidad_SelectedIndexChanged);
            this.cbx_modalidad.SelectedValueChanged += new System.EventHandler(this.cbx_modalidad_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(60, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "CODIGO DEL COMPOROBANTE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(105, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "MODALIDAD DE PAGO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(216, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "MODALIDAD DE PAGO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "COMPROBANTE";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "MODALIDAD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ESTADO: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TASA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "VALOR";
            // 
            // btn_pagartransaccion
            // 
            this.btn_pagartransaccion.Location = new System.Drawing.Point(3, 350);
            this.btn_pagartransaccion.Name = "btn_pagartransaccion";
            this.btn_pagartransaccion.Size = new System.Drawing.Size(522, 23);
            this.btn_pagartransaccion.TabIndex = 3;
            this.btn_pagartransaccion.Text = "CONSIGNAR / REGISTRAR MOVIMIENTO";
            this.btn_pagartransaccion.UseVisualStyleBackColor = true;
            this.btn_pagartransaccion.Click += new System.EventHandler(this.btn_pagartransaccion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "FECHA PLANEADA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CUOTA:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pagar_Inversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 531);
            this.Controls.Add(this.pnl_pagar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(570, 570);
            this.MinimumSize = new System.Drawing.Size(570, 570);
            this.Name = "Pagar_Inversion";
            this.Text = "PAGAR INVERSIÓN";
            this.Load += new System.EventHandler(this.Pagar_Inversion_Load);
            this.pnl_pagobancario.ResumeLayout(false);
            this.pnl_pagobancario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_pagar.ResumeLayout(false);
            this.pnl_pagar.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_pagobancario;
        private System.Windows.Forms.ComboBox cbx_tipocuenta;
        private System.Windows.Forms.ComboBox txb_banco;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txb_numerocuenta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txb_codigotransaccionpagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_buscarpagar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_pagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_pagartransaccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_comprobante;
        private System.Windows.Forms.ComboBox cbx_modalidad;
        private System.Windows.Forms.Label lbl_comprobante;
        private System.Windows.Forms.Label lbl_modalidad;
        private System.Windows.Forms.Label lbl_fchplaneada;
        private System.Windows.Forms.Label lbl_fchefectiva;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_tasa;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_cuota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Button button1;
    }
}