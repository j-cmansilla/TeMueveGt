﻿namespace TeMueveGt
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grupoConfiguracion = new System.Windows.Forms.GroupBox();
            this.txtAsientos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVagones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadTrenes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grupoCreacionDeTrenes = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.radioSi = new System.Windows.Forms.RadioButton();
            this.txtNombreTren = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrearTren = new System.Windows.Forms.Button();
            this.grupoReservarComprar = new System.Windows.Forms.GroupBox();
            this.comboVagon = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDisponiblidad = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grupoDatosCliente = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tipoDeAsiento = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioComprar = new System.Windows.Forms.RadioButton();
            this.radioReservar = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.grupoDisponibilidad = new System.Windows.Forms.GroupBox();
            this.seleccionDeAsiento = new System.Windows.Forms.GroupBox();
            this.Asientos = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreTrenReporte = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAsientosDisponiblesReporte = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReservado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNombreReservado = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDPIReservado = new System.Windows.Forms.TextBox();
            this.txtTelefonoReservado = new System.Windows.Forms.TextBox();
            this.txtCorreoReservado = new System.Windows.Forms.TextBox();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.grupoConfiguracion.SuspendLayout();
            this.grupoCreacionDeTrenes.SuspendLayout();
            this.grupoReservarComprar.SuspendLayout();
            this.grupoDatosCliente.SuspendLayout();
            this.grupoDisponibilidad.SuspendLayout();
            this.seleccionDeAsiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Asientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoConfiguracion
            // 
            this.grupoConfiguracion.Controls.Add(this.txtAsientos);
            this.grupoConfiguracion.Controls.Add(this.label4);
            this.grupoConfiguracion.Controls.Add(this.txtFilas);
            this.grupoConfiguracion.Controls.Add(this.label3);
            this.grupoConfiguracion.Controls.Add(this.txtVagones);
            this.grupoConfiguracion.Controls.Add(this.label2);
            this.grupoConfiguracion.Controls.Add(this.label1);
            this.grupoConfiguracion.Controls.Add(this.txtCantidadTrenes);
            this.grupoConfiguracion.Controls.Add(this.button1);
            this.grupoConfiguracion.Location = new System.Drawing.Point(13, 13);
            this.grupoConfiguracion.Name = "grupoConfiguracion";
            this.grupoConfiguracion.Size = new System.Drawing.Size(171, 152);
            this.grupoConfiguracion.TabIndex = 0;
            this.grupoConfiguracion.TabStop = false;
            this.grupoConfiguracion.Text = "Configuración inicial";
            this.grupoConfiguracion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAsientos
            // 
            this.txtAsientos.Location = new System.Drawing.Point(105, 93);
            this.txtAsientos.Name = "txtAsientos";
            this.txtAsientos.Size = new System.Drawing.Size(54, 20);
            this.txtAsientos.TabIndex = 8;
            this.txtAsientos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsientos_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Asientos por fila:";
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(105, 69);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(54, 20);
            this.txtFilas.TabIndex = 6;
            this.txtFilas.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtFilas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filas por vagon:";
            // 
            // txtVagones
            // 
            this.txtVagones.Location = new System.Drawing.Point(105, 43);
            this.txtVagones.Name = "txtVagones";
            this.txtVagones.Size = new System.Drawing.Size(54, 20);
            this.txtVagones.TabIndex = 4;
            this.txtVagones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vagones por tren:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de trenes:";
            // 
            // txtCantidadTrenes
            // 
            this.txtCantidadTrenes.Location = new System.Drawing.Point(105, 19);
            this.txtCantidadTrenes.Name = "txtCantidadTrenes";
            this.txtCantidadTrenes.Size = new System.Drawing.Size(54, 20);
            this.txtCantidadTrenes.TabIndex = 1;
            this.txtCantidadTrenes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadTrenes_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grupoCreacionDeTrenes
            // 
            this.grupoCreacionDeTrenes.Controls.Add(this.label6);
            this.grupoCreacionDeTrenes.Controls.Add(this.radioNo);
            this.grupoCreacionDeTrenes.Controls.Add(this.radioSi);
            this.grupoCreacionDeTrenes.Controls.Add(this.txtNombreTren);
            this.grupoCreacionDeTrenes.Controls.Add(this.label5);
            this.grupoCreacionDeTrenes.Controls.Add(this.btnCrearTren);
            this.grupoCreacionDeTrenes.Enabled = false;
            this.grupoCreacionDeTrenes.Location = new System.Drawing.Point(190, 13);
            this.grupoCreacionDeTrenes.Name = "grupoCreacionDeTrenes";
            this.grupoCreacionDeTrenes.Size = new System.Drawing.Size(284, 152);
            this.grupoCreacionDeTrenes.TabIndex = 1;
            this.grupoCreacionDeTrenes.TabStop = false;
            this.grupoCreacionDeTrenes.Text = "Creación de trenes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Asientos De Lujo:";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(177, 72);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(39, 17);
            this.radioNo.TabIndex = 12;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // radioSi
            // 
            this.radioSi.AutoSize = true;
            this.radioSi.Location = new System.Drawing.Point(137, 72);
            this.radioSi.Name = "radioSi";
            this.radioSi.Size = new System.Drawing.Size(34, 17);
            this.radioSi.TabIndex = 11;
            this.radioSi.TabStop = true;
            this.radioSi.Text = "Si";
            this.radioSi.UseVisualStyleBackColor = true;
            // 
            // txtNombreTren
            // 
            this.txtNombreTren.Location = new System.Drawing.Point(59, 43);
            this.txtNombreTren.Name = "txtNombreTren";
            this.txtNombreTren.Size = new System.Drawing.Size(158, 20);
            this.txtNombreTren.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre:";
            // 
            // btnCrearTren
            // 
            this.btnCrearTren.Location = new System.Drawing.Point(7, 118);
            this.btnCrearTren.Name = "btnCrearTren";
            this.btnCrearTren.Size = new System.Drawing.Size(271, 23);
            this.btnCrearTren.TabIndex = 0;
            this.btnCrearTren.Text = "Crear Tren";
            this.btnCrearTren.UseVisualStyleBackColor = true;
            this.btnCrearTren.Click += new System.EventHandler(this.button2_Click);
            // 
            // grupoReservarComprar
            // 
            this.grupoReservarComprar.Controls.Add(this.comboVagon);
            this.grupoReservarComprar.Controls.Add(this.label14);
            this.grupoReservarComprar.Controls.Add(this.btnDisponiblidad);
            this.grupoReservarComprar.Controls.Add(this.comboBox1);
            this.grupoReservarComprar.Controls.Add(this.label8);
            this.grupoReservarComprar.Controls.Add(this.grupoDatosCliente);
            this.grupoReservarComprar.Controls.Add(this.radioComprar);
            this.grupoReservarComprar.Controls.Add(this.radioReservar);
            this.grupoReservarComprar.Controls.Add(this.label7);
            this.grupoReservarComprar.Enabled = false;
            this.grupoReservarComprar.Location = new System.Drawing.Point(12, 203);
            this.grupoReservarComprar.Name = "grupoReservarComprar";
            this.grupoReservarComprar.Size = new System.Drawing.Size(461, 266);
            this.grupoReservarComprar.TabIndex = 2;
            this.grupoReservarComprar.TabStop = false;
            this.grupoReservarComprar.Text = "Reservar/Comprar";
            // 
            // comboVagon
            // 
            this.comboVagon.FormattingEnabled = true;
            this.comboVagon.Location = new System.Drawing.Point(338, 14);
            this.comboVagon.Name = "comboVagon";
            this.comboVagon.Size = new System.Drawing.Size(110, 21);
            this.comboVagon.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(291, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Vagón:";
            // 
            // btnDisponiblidad
            // 
            this.btnDisponiblidad.Enabled = false;
            this.btnDisponiblidad.Location = new System.Drawing.Point(187, 41);
            this.btnDisponiblidad.Name = "btnDisponiblidad";
            this.btnDisponiblidad.Size = new System.Drawing.Size(261, 25);
            this.btnDisponiblidad.TabIndex = 22;
            this.btnDisponiblidad.Text = "Verificar Disponibilidad";
            this.btnDisponiblidad.UseVisualStyleBackColor = true;
            this.btnDisponiblidad.Click += new System.EventHandler(this.btnDisponiblidad_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tren:";
            // 
            // grupoDatosCliente
            // 
            this.grupoDatosCliente.Controls.Add(this.label13);
            this.grupoDatosCliente.Controls.Add(this.tipoDeAsiento);
            this.grupoDatosCliente.Controls.Add(this.txtCorreo);
            this.grupoDatosCliente.Controls.Add(this.label12);
            this.grupoDatosCliente.Controls.Add(this.txtTelefono);
            this.grupoDatosCliente.Controls.Add(this.btnCancelar);
            this.grupoDatosCliente.Controls.Add(this.label11);
            this.grupoDatosCliente.Controls.Add(this.btnContinuar);
            this.grupoDatosCliente.Controls.Add(this.txtDPI);
            this.grupoDatosCliente.Controls.Add(this.label10);
            this.grupoDatosCliente.Controls.Add(this.txtNombreCliente);
            this.grupoDatosCliente.Controls.Add(this.label9);
            this.grupoDatosCliente.Location = new System.Drawing.Point(7, 68);
            this.grupoDatosCliente.Name = "grupoDatosCliente";
            this.grupoDatosCliente.Size = new System.Drawing.Size(441, 198);
            this.grupoDatosCliente.TabIndex = 17;
            this.grupoDatosCliente.TabStop = false;
            this.grupoDatosCliente.Text = "Datos Del Cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tipo de asiento:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // tipoDeAsiento
            // 
            this.tipoDeAsiento.Enabled = false;
            this.tipoDeAsiento.FormattingEnabled = true;
            this.tipoDeAsiento.Location = new System.Drawing.Point(98, 131);
            this.tipoDeAsiento.Name = "tipoDeAsiento";
            this.tipoDeAsiento.Size = new System.Drawing.Size(337, 21);
            this.tipoDeAsiento.TabIndex = 22;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(55, 105);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(380, 20);
            this.txtCorreo.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(55, 79);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(380, 20);
            this.txtTelefono.TabIndex = 19;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress_2);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(217, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(218, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Teléfono:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(6, 158);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(207, 23);
            this.btnContinuar.TabIndex = 18;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(55, 53);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(380, 20);
            this.txtDPI.TabIndex = 17;
            this.txtDPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "DPI:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(55, 27);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(380, 20);
            this.txtNombreCliente.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nombre:";
            // 
            // radioComprar
            // 
            this.radioComprar.AutoSize = true;
            this.radioComprar.Location = new System.Drawing.Point(81, 33);
            this.radioComprar.Name = "radioComprar";
            this.radioComprar.Size = new System.Drawing.Size(64, 17);
            this.radioComprar.TabIndex = 16;
            this.radioComprar.TabStop = true;
            this.radioComprar.Text = "Comprar";
            this.radioComprar.UseVisualStyleBackColor = true;
            // 
            // radioReservar
            // 
            this.radioReservar.AutoSize = true;
            this.radioReservar.Location = new System.Drawing.Point(7, 33);
            this.radioReservar.Name = "radioReservar";
            this.radioReservar.Size = new System.Drawing.Size(68, 17);
            this.radioReservar.TabIndex = 15;
            this.radioReservar.TabStop = true;
            this.radioReservar.Text = "Reservar";
            this.radioReservar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Operación:";
            // 
            // grupoDisponibilidad
            // 
            this.grupoDisponibilidad.Controls.Add(this.txtAsientosDisponiblesReporte);
            this.grupoDisponibilidad.Controls.Add(this.label17);
            this.grupoDisponibilidad.Controls.Add(this.label16);
            this.grupoDisponibilidad.Controls.Add(this.txtNombreTrenReporte);
            this.grupoDisponibilidad.Enabled = false;
            this.grupoDisponibilidad.Location = new System.Drawing.Point(480, 13);
            this.grupoDisponibilidad.Name = "grupoDisponibilidad";
            this.grupoDisponibilidad.Size = new System.Drawing.Size(305, 152);
            this.grupoDisponibilidad.TabIndex = 3;
            this.grupoDisponibilidad.TabStop = false;
            this.grupoDisponibilidad.Text = "Disponibilidad Del Tren";
            // 
            // seleccionDeAsiento
            // 
            this.seleccionDeAsiento.Controls.Add(this.Asientos);
            this.seleccionDeAsiento.Enabled = false;
            this.seleccionDeAsiento.Location = new System.Drawing.Point(480, 203);
            this.seleccionDeAsiento.Name = "seleccionDeAsiento";
            this.seleccionDeAsiento.Size = new System.Drawing.Size(702, 308);
            this.seleccionDeAsiento.TabIndex = 4;
            this.seleccionDeAsiento.TabStop = false;
            this.seleccionDeAsiento.Text = "Seleccion De Asiento";
            // 
            // Asientos
            // 
            this.Asientos.AllowUserToAddRows = false;
            this.Asientos.AllowUserToDeleteRows = false;
            this.Asientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Asientos.Location = new System.Drawing.Point(8, 20);
            this.Asientos.Name = "Asientos";
            this.Asientos.ReadOnly = true;
            this.Asientos.Size = new System.Drawing.Size(688, 271);
            this.Asientos.TabIndex = 6;
            this.Asientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Asientos_CellClick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(898, 185);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(284, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCorreoReservado);
            this.groupBox1.Controls.Add(this.txtTelefonoReservado);
            this.groupBox1.Controls.Add(this.txtDPIReservado);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtNombreReservado);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(790, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservado Por";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Nombre del tren:";
            // 
            // txtNombreTrenReporte
            // 
            this.txtNombreTrenReporte.Enabled = false;
            this.txtNombreTrenReporte.Location = new System.Drawing.Point(113, 22);
            this.txtNombreTrenReporte.Name = "txtNombreTrenReporte";
            this.txtNombreTrenReporte.Size = new System.Drawing.Size(183, 20);
            this.txtNombreTrenReporte.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Asientos disponibles:";
            // 
            // txtAsientosDisponiblesReporte
            // 
            this.txtAsientosDisponiblesReporte.Enabled = false;
            this.txtAsientosDisponiblesReporte.Location = new System.Drawing.Point(113, 50);
            this.txtAsientosDisponiblesReporte.Name = "txtAsientosDisponiblesReporte";
            this.txtAsientosDisponiblesReporte.Size = new System.Drawing.Size(183, 20);
            this.txtAsientosDisponiblesReporte.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReservado);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(789, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 158);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disponibilidad Del Tren";
            // 
            // txtReservado
            // 
            this.txtReservado.Enabled = false;
            this.txtReservado.Location = new System.Drawing.Point(10, 38);
            this.txtReservado.Name = "txtReservado";
            this.txtReservado.Size = new System.Drawing.Size(269, 20);
            this.txtReservado.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Reservado por:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Correo:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Teléfono:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "DPI:";
            // 
            // txtNombreReservado
            // 
            this.txtNombreReservado.Location = new System.Drawing.Point(54, 19);
            this.txtNombreReservado.Name = "txtNombreReservado";
            this.txtNombreReservado.Size = new System.Drawing.Size(300, 20);
            this.txtNombreReservado.TabIndex = 24;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Nombre:";
            // 
            // txtDPIReservado
            // 
            this.txtDPIReservado.Location = new System.Drawing.Point(54, 42);
            this.txtDPIReservado.Name = "txtDPIReservado";
            this.txtDPIReservado.Size = new System.Drawing.Size(300, 20);
            this.txtDPIReservado.TabIndex = 30;
            // 
            // txtTelefonoReservado
            // 
            this.txtTelefonoReservado.Location = new System.Drawing.Point(54, 68);
            this.txtTelefonoReservado.Name = "txtTelefonoReservado";
            this.txtTelefonoReservado.Size = new System.Drawing.Size(300, 20);
            this.txtTelefonoReservado.TabIndex = 31;
            // 
            // txtCorreoReservado
            // 
            this.txtCorreoReservado.Location = new System.Drawing.Point(54, 94);
            this.txtCorreoReservado.Name = "txtCorreoReservado";
            this.txtCorreoReservado.Size = new System.Drawing.Size(300, 20);
            this.txtCorreoReservado.TabIndex = 32;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Enabled = false;
            this.btnCancelarCompra.Location = new System.Drawing.Point(674, 185);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(218, 23);
            this.btnCancelarCompra.TabIndex = 24;
            this.btnCancelarCompra.Text = "Cancelar";
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 519);
            this.Controls.Add(this.btnCancelarCompra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.seleccionDeAsiento);
            this.Controls.Add(this.grupoDisponibilidad);
            this.Controls.Add(this.grupoReservarComprar);
            this.Controls.Add(this.grupoCreacionDeTrenes);
            this.Controls.Add(this.grupoConfiguracion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Te mueve";
            this.grupoConfiguracion.ResumeLayout(false);
            this.grupoConfiguracion.PerformLayout();
            this.grupoCreacionDeTrenes.ResumeLayout(false);
            this.grupoCreacionDeTrenes.PerformLayout();
            this.grupoReservarComprar.ResumeLayout(false);
            this.grupoReservarComprar.PerformLayout();
            this.grupoDatosCliente.ResumeLayout(false);
            this.grupoDatosCliente.PerformLayout();
            this.grupoDisponibilidad.ResumeLayout(false);
            this.grupoDisponibilidad.PerformLayout();
            this.seleccionDeAsiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Asientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoConfiguracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadTrenes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVagones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAsientos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grupoCreacionDeTrenes;
        private System.Windows.Forms.Button btnCrearTren;
        private System.Windows.Forms.TextBox txtNombreTren;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.RadioButton radioSi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grupoReservarComprar;
        private System.Windows.Forms.RadioButton radioComprar;
        private System.Windows.Forms.RadioButton radioReservar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.GroupBox grupoDatosCliente;
        private System.Windows.Forms.Button btnDisponiblidad;
        private System.Windows.Forms.GroupBox grupoDisponibilidad;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox tipoDeAsiento;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboVagon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox seleccionDeAsiento;
        private System.Windows.Forms.DataGridView Asientos;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAsientosDisponiblesReporte;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNombreTrenReporte;
        private System.Windows.Forms.TextBox txtCorreoReservado;
        private System.Windows.Forms.TextBox txtTelefonoReservado;
        private System.Windows.Forms.TextBox txtDPIReservado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReservado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNombreReservado;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnCancelarCompra;
    }
}

