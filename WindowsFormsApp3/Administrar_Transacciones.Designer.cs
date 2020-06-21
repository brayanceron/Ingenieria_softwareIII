namespace WindowsFormsApp3
{
    partial class Administrar_Transaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrar_Transaciones));
            this.Administrar_Transacciones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_tiempopres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbx_gar = new System.Windows.Forms.CheckBox();
            this.chbx_fiador = new System.Windows.Forms.CheckBox();
            this.pnl_codfiador = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txb_codfiador = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnl_aprovado = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txb_fechatermino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_fechainicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_fechaprovacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_monto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_estadopres = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_codigoclienteprest = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_registrarprestamo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_tasa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_fechasolicitud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_tiempoinver = new System.Windows.Forms.ComboBox();
            this.txb_tasainver = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_fechasinver = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txb_fechaterminoinver = new System.Windows.Forms.TextBox();
            this.txb_fecharealizacioninver = new System.Windows.Forms.TextBox();
            this.txb_estadoinver = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txb_codclienteinver = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txb_fechasolicitudinver = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_registrarinver = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txb_montoinver = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Administrar_Transacciones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_codfiador.SuspendLayout();
            this.pnl_aprovado.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_fechasinver.SuspendLayout();
            this.SuspendLayout();
            // 
            // Administrar_Transacciones
            // 
            this.Administrar_Transacciones.Controls.Add(this.tabPage1);
            this.Administrar_Transacciones.Controls.Add(this.tabPage2);
            this.Administrar_Transacciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Administrar_Transacciones.Location = new System.Drawing.Point(0, 0);
            this.Administrar_Transacciones.Name = "Administrar_Transacciones";
            this.Administrar_Transacciones.SelectedIndex = 0;
            this.Administrar_Transacciones.Size = new System.Drawing.Size(732, 548);
            this.Administrar_Transacciones.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(724, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PRESTAMO";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txb_tiempopres);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chbx_gar);
            this.panel1.Controls.Add(this.chbx_fiador);
            this.panel1.Controls.Add(this.pnl_codfiador);
            this.panel1.Controls.Add(this.pnl_aprovado);
            this.panel1.Controls.Add(this.txb_monto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txb_estadopres);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txb_codigoclienteprest);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btn_registrarprestamo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txb_tasa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txb_fechasolicitud);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(136, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 472);
            this.panel1.TabIndex = 32;
            // 
            // txb_tiempopres
            // 
            this.txb_tiempopres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_tiempopres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txb_tiempopres.FormattingEnabled = true;
            this.txb_tiempopres.Items.AddRange(new object[] {
            "MENSUAL",
            "BIMESTRAL",
            "TRIMESTRAL",
            "SEMESTRAL",
            "ANUAL"});
            this.txb_tiempopres.Location = new System.Drawing.Point(268, 133);
            this.txb_tiempopres.MaxLength = 20;
            this.txb_tiempopres.Name = "txb_tiempopres";
            this.txb_tiempopres.Size = new System.Drawing.Size(140, 21);
            this.txb_tiempopres.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRAR PRESTAMO";
            // 
            // chbx_gar
            // 
            this.chbx_gar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbx_gar.AutoSize = true;
            this.chbx_gar.Location = new System.Drawing.Point(258, 163);
            this.chbx_gar.Name = "chbx_gar";
            this.chbx_gar.Size = new System.Drawing.Size(81, 17);
            this.chbx_gar.TabIndex = 30;
            this.chbx_gar.Text = "GARANTIA";
            this.chbx_gar.UseVisualStyleBackColor = true;
            this.chbx_gar.CheckedChanged += new System.EventHandler(this.chbx_gar_CheckedChanged);
            // 
            // chbx_fiador
            // 
            this.chbx_fiador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbx_fiador.AutoSize = true;
            this.chbx_fiador.Location = new System.Drawing.Point(137, 163);
            this.chbx_fiador.Name = "chbx_fiador";
            this.chbx_fiador.Size = new System.Drawing.Size(66, 17);
            this.chbx_fiador.TabIndex = 29;
            this.chbx_fiador.Text = "FIADOR";
            this.chbx_fiador.UseVisualStyleBackColor = true;
            this.chbx_fiador.CheckedChanged += new System.EventHandler(this.chbx_fiador_CheckedChanged);
            // 
            // pnl_codfiador
            // 
            this.pnl_codfiador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_codfiador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_codfiador.Controls.Add(this.label15);
            this.pnl_codfiador.Controls.Add(this.txb_codfiador);
            this.pnl_codfiador.Controls.Add(this.label14);
            this.pnl_codfiador.Enabled = false;
            this.pnl_codfiador.Location = new System.Drawing.Point(48, 187);
            this.pnl_codfiador.Name = "pnl_codfiador";
            this.pnl_codfiador.Size = new System.Drawing.Size(377, 43);
            this.pnl_codfiador.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Turquoise;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 12);
            this.label15.TabIndex = 31;
            this.label15.Text = "Restringido";
            // 
            // txb_codfiador
            // 
            this.txb_codfiador.Location = new System.Drawing.Point(190, 13);
            this.txb_codfiador.MaxLength = 8;
            this.txb_codfiador.Name = "txb_codfiador";
            this.txb_codfiador.Size = new System.Drawing.Size(180, 20);
            this.txb_codfiador.TabIndex = 27;
            this.txb_codfiador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_codfiador_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "CÓDIGO FIADOR";
            // 
            // pnl_aprovado
            // 
            this.pnl_aprovado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_aprovado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_aprovado.Controls.Add(this.label17);
            this.pnl_aprovado.Controls.Add(this.txb_fechatermino);
            this.pnl_aprovado.Controls.Add(this.label5);
            this.pnl_aprovado.Controls.Add(this.txb_fechainicio);
            this.pnl_aprovado.Controls.Add(this.label4);
            this.pnl_aprovado.Controls.Add(this.txb_fechaprovacion);
            this.pnl_aprovado.Controls.Add(this.label3);
            this.pnl_aprovado.Location = new System.Drawing.Point(44, 278);
            this.pnl_aprovado.Name = "pnl_aprovado";
            this.pnl_aprovado.Size = new System.Drawing.Size(381, 130);
            this.pnl_aprovado.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(124, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "ESTADO TRANSACCIÓN";
            // 
            // txb_fechatermino
            // 
            this.txb_fechatermino.Location = new System.Drawing.Point(217, 68);
            this.txb_fechatermino.MaxLength = 10;
            this.txb_fechatermino.Name = "txb_fechatermino";
            this.txb_fechatermino.Size = new System.Drawing.Size(156, 20);
            this.txb_fechatermino.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "FECHA DE FINALIZACION DE PRESTAMO";
            // 
            // txb_fechainicio
            // 
            this.txb_fechainicio.Location = new System.Drawing.Point(217, 42);
            this.txb_fechainicio.MaxLength = 10;
            this.txb_fechainicio.Name = "txb_fechainicio";
            this.txb_fechainicio.Size = new System.Drawing.Size(156, 20);
            this.txb_fechainicio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FECHA DE INICIO PRESTAMO";
            // 
            // txb_fechaprovacion
            // 
            this.txb_fechaprovacion.Location = new System.Drawing.Point(217, 16);
            this.txb_fechaprovacion.MaxLength = 10;
            this.txb_fechaprovacion.Name = "txb_fechaprovacion";
            this.txb_fechaprovacion.Size = new System.Drawing.Size(156, 20);
            this.txb_fechaprovacion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA DE APROVACIÓN";
            // 
            // txb_monto
            // 
            this.txb_monto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_monto.Location = new System.Drawing.Point(229, 110);
            this.txb_monto.MaxLength = 12;
            this.txb_monto.Name = "txb_monto";
            this.txb_monto.Size = new System.Drawing.Size(180, 20);
            this.txb_monto.TabIndex = 22;
            this.txb_monto.TextChanged += new System.EventHandler(this.txb_monto_TextChanged);
            this.txb_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_monto_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "MONTO";
            // 
            // txb_estadopres
            // 
            this.txb_estadopres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_estadopres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txb_estadopres.FormattingEnabled = true;
            this.txb_estadopres.Items.AddRange(new object[] {
            "ESTUDIO",
            "APROBADO",
            "REPROBADO"});
            this.txb_estadopres.Location = new System.Drawing.Point(262, 240);
            this.txb_estadopres.MaxLength = 20;
            this.txb_estadopres.Name = "txb_estadopres";
            this.txb_estadopres.Size = new System.Drawing.Size(148, 21);
            this.txb_estadopres.TabIndex = 19;
            this.txb_estadopres.SelectedIndexChanged += new System.EventHandler(this.txb_estado_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "ESTADO DEL PRESTAMO";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txb_codigoclienteprest
            // 
            this.txb_codigoclienteprest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_codigoclienteprest.Location = new System.Drawing.Point(229, 59);
            this.txb_codigoclienteprest.MaxLength = 10;
            this.txb_codigoclienteprest.Name = "txb_codigoclienteprest";
            this.txb_codigoclienteprest.Size = new System.Drawing.Size(180, 20);
            this.txb_codigoclienteprest.TabIndex = 17;
            this.txb_codigoclienteprest.TextChanged += new System.EventHandler(this.txb_codigoclienteprest_TextChanged);
            this.txb_codigoclienteprest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_codigoclienteprest_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "CEDULA CLIENTE";
            // 
            // btn_registrarprestamo
            // 
            this.btn_registrarprestamo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_registrarprestamo.Location = new System.Drawing.Point(268, 424);
            this.btn_registrarprestamo.Name = "btn_registrarprestamo";
            this.btn_registrarprestamo.Size = new System.Drawing.Size(75, 23);
            this.btn_registrarprestamo.TabIndex = 15;
            this.btn_registrarprestamo.Text = "REGISTRAR";
            this.btn_registrarprestamo.UseVisualStyleBackColor = true;
            this.btn_registrarprestamo.Click += new System.EventHandler(this.btn_registrarprestamo_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(155, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_tasa
            // 
            this.txb_tasa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_tasa.Location = new System.Drawing.Point(229, 134);
            this.txb_tasa.MaxLength = 5;
            this.txb_tasa.Name = "txb_tasa";
            this.txb_tasa.Size = new System.Drawing.Size(33, 20);
            this.txb_tasa.TabIndex = 11;
            this.txb_tasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_tasa_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "TASA DE INTERÉS";
            // 
            // txb_fechasolicitud
            // 
            this.txb_fechasolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_fechasolicitud.Location = new System.Drawing.Point(229, 85);
            this.txb_fechasolicitud.MaxLength = 10;
            this.txb_fechasolicitud.Name = "txb_fechasolicitud";
            this.txb_fechasolicitud.Size = new System.Drawing.Size(180, 20);
            this.txb_fechasolicitud.TabIndex = 1;
            this.txb_fechasolicitud.TextChanged += new System.EventHandler(this.txb_fechasolicitud_TextChanged);
            this.txb_fechasolicitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_fechasolicitud_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "FECHA DE SOLICITUD";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(724, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INVERSIÓN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txb_tiempoinver);
            this.panel2.Controls.Add(this.txb_tasainver);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pnl_fechasinver);
            this.panel2.Controls.Add(this.txb_estadoinver);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txb_codclienteinver);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txb_fechasolicitudinver);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btn_registrarinver);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.txb_montoinver);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(104, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 488);
            this.panel2.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "REGISTRAR INVERSIÓN";
            // 
            // txb_tiempoinver
            // 
            this.txb_tiempoinver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txb_tiempoinver.FormattingEnabled = true;
            this.txb_tiempoinver.Items.AddRange(new object[] {
            "MENSUAL",
            "BIMESTRAL",
            "TRIMESTRAL",
            "SEMESTRAL",
            "ANUAL"});
            this.txb_tiempoinver.Location = new System.Drawing.Point(293, 168);
            this.txb_tiempoinver.MaxLength = 20;
            this.txb_tiempoinver.Name = "txb_tiempoinver";
            this.txb_tiempoinver.Size = new System.Drawing.Size(140, 21);
            this.txb_tiempoinver.TabIndex = 48;
            // 
            // txb_tasainver
            // 
            this.txb_tasainver.Location = new System.Drawing.Point(253, 169);
            this.txb_tasainver.MaxLength = 5;
            this.txb_tasainver.Name = "txb_tasainver";
            this.txb_tasainver.Size = new System.Drawing.Size(31, 20);
            this.txb_tasainver.TabIndex = 47;
            this.txb_tasainver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_tasainver_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "FECHA DE SOLICITUD";
            // 
            // pnl_fechasinver
            // 
            this.pnl_fechasinver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_fechasinver.Controls.Add(this.label20);
            this.pnl_fechasinver.Controls.Add(this.label21);
            this.pnl_fechasinver.Controls.Add(this.label18);
            this.pnl_fechasinver.Controls.Add(this.txb_fechaterminoinver);
            this.pnl_fechasinver.Controls.Add(this.txb_fecharealizacioninver);
            this.pnl_fechasinver.Location = new System.Drawing.Point(29, 258);
            this.pnl_fechasinver.Name = "pnl_fechasinver";
            this.pnl_fechasinver.Size = new System.Drawing.Size(436, 130);
            this.pnl_fechasinver.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(209, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "FECHA DE TERMINO DE LA INVERSIÓN";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(251, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "FECHA EN QUE FUE REALIZADA LA INVERSIÓN";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(180, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "ESTADO INVERSIÓN";
            // 
            // txb_fechaterminoinver
            // 
            this.txb_fechaterminoinver.Location = new System.Drawing.Point(259, 65);
            this.txb_fechaterminoinver.MaxLength = 10;
            this.txb_fechaterminoinver.Name = "txb_fechaterminoinver";
            this.txb_fechaterminoinver.Size = new System.Drawing.Size(156, 20);
            this.txb_fechaterminoinver.TabIndex = 5;
            // 
            // txb_fecharealizacioninver
            // 
            this.txb_fecharealizacioninver.Location = new System.Drawing.Point(259, 39);
            this.txb_fecharealizacioninver.MaxLength = 10;
            this.txb_fecharealizacioninver.Name = "txb_fecharealizacioninver";
            this.txb_fecharealizacioninver.Size = new System.Drawing.Size(156, 20);
            this.txb_fecharealizacioninver.TabIndex = 3;
            // 
            // txb_estadoinver
            // 
            this.txb_estadoinver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txb_estadoinver.FormattingEnabled = true;
            this.txb_estadoinver.Items.AddRange(new object[] {
            "ESTUDIO",
            "APROBADO",
            "REPROBADO"});
            this.txb_estadoinver.Location = new System.Drawing.Point(285, 209);
            this.txb_estadoinver.MaxLength = 20;
            this.txb_estadoinver.Name = "txb_estadoinver";
            this.txb_estadoinver.Size = new System.Drawing.Size(148, 21);
            this.txb_estadoinver.TabIndex = 44;
            this.txb_estadoinver.SelectedIndexChanged += new System.EventHandler(this.txb_estadoinver_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(95, 217);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "ESTADO DE LA INVERSIÓN";
            // 
            // txb_codclienteinver
            // 
            this.txb_codclienteinver.Location = new System.Drawing.Point(253, 83);
            this.txb_codclienteinver.MaxLength = 10;
            this.txb_codclienteinver.Name = "txb_codclienteinver";
            this.txb_codclienteinver.Size = new System.Drawing.Size(180, 20);
            this.txb_codclienteinver.TabIndex = 42;
            this.txb_codclienteinver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_codclienteinver_KeyPress_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(148, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "CEDULA CLIENTE";
            // 
            // txb_fechasolicitudinver
            // 
            this.txb_fechasolicitudinver.Location = new System.Drawing.Point(253, 139);
            this.txb_fechasolicitudinver.MaxLength = 10;
            this.txb_fechasolicitudinver.Name = "txb_fechasolicitudinver";
            this.txb_fechasolicitudinver.Size = new System.Drawing.Size(180, 20);
            this.txb_fechasolicitudinver.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "INTERÉS";
            // 
            // btn_registrarinver
            // 
            this.btn_registrarinver.Location = new System.Drawing.Point(248, 409);
            this.btn_registrarinver.Name = "btn_registrarinver";
            this.btn_registrarinver.Size = new System.Drawing.Size(75, 23);
            this.btn_registrarinver.TabIndex = 38;
            this.btn_registrarinver.Text = "REGISTRAR";
            this.btn_registrarinver.UseVisualStyleBackColor = true;
            this.btn_registrarinver.Click += new System.EventHandler(this.btn_registrarinver_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(138, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "CANCELAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txb_montoinver
            // 
            this.txb_montoinver.Location = new System.Drawing.Point(253, 111);
            this.txb_montoinver.MaxLength = 12;
            this.txb_montoinver.Name = "txb_montoinver";
            this.txb_montoinver.Size = new System.Drawing.Size(180, 20);
            this.txb_montoinver.TabIndex = 36;
            this.txb_montoinver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_montoinver_KeyPress_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "MONTO";
            // 
            // Administrar_Transaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 548);
            this.Controls.Add(this.Administrar_Transacciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrar_Transaciones";
            this.Text = "TRANSACCIONES";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Administrar_Transacciones.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_codfiador.ResumeLayout(false);
            this.pnl_codfiador.PerformLayout();
            this.pnl_aprovado.ResumeLayout(false);
            this.pnl_aprovado.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_fechasinver.ResumeLayout(false);
            this.pnl_fechasinver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Administrar_Transacciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_registrarprestamo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_tasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_fechasolicitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_codigoclienteprest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnl_aprovado;
        private System.Windows.Forms.TextBox txb_fechatermino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_fechainicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_fechaprovacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_monto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txb_estadopres;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chbx_gar;
        private System.Windows.Forms.CheckBox chbx_fiador;
        private System.Windows.Forms.Panel pnl_codfiador;
        private System.Windows.Forms.TextBox txb_codfiador;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox txb_tiempopres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_codclienteinver;
        private System.Windows.Forms.Button btn_registrarinver;
        private System.Windows.Forms.Panel pnl_fechasinver;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txb_fechaterminoinver;
        private System.Windows.Forms.TextBox txb_fecharealizacioninver;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox txb_tiempoinver;
        private System.Windows.Forms.ComboBox txb_estadoinver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txb_tasainver;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_montoinver;
        private System.Windows.Forms.TextBox txb_fechasolicitudinver;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
    }
}