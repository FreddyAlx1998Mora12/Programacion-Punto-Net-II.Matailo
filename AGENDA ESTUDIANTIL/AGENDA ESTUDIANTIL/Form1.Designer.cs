namespace AGENDA_ESTUDIANTIL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbAgendaE = new System.Windows.Forms.TabControl();
            this.tbDatosPersonales = new System.Windows.Forms.TabPage();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbSangre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gpGenero = new System.Windows.Forms.GroupBox();
            this.chkF = new System.Windows.Forms.CheckBox();
            this.chk1M = new System.Windows.Forms.CheckBox();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNacionalid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCedula = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDatosCarreraE = new System.Windows.Forms.TabPage();
            this.btnPresentar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.tbAgendaE.SuspendLayout();
            this.tbDatosPersonales.SuspendLayout();
            this.gpGenero.SuspendLayout();
            this.tbDatosCarreraE.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAgendaE
            // 
            this.tbAgendaE.Controls.Add(this.tbDatosPersonales);
            this.tbAgendaE.Controls.Add(this.tbDatosCarreraE);
            this.tbAgendaE.Location = new System.Drawing.Point(12, 12);
            this.tbAgendaE.Name = "tbAgendaE";
            this.tbAgendaE.SelectedIndex = 0;
            this.tbAgendaE.Size = new System.Drawing.Size(583, 308);
            this.tbAgendaE.TabIndex = 0;
            // 
            // tbDatosPersonales
            // 
            this.tbDatosPersonales.Controls.Add(this.txtEdad);
            this.tbDatosPersonales.Controls.Add(this.label13);
            this.tbDatosPersonales.Controls.Add(this.btnVerificar);
            this.tbDatosPersonales.Controls.Add(this.btnSiguiente);
            this.tbDatosPersonales.Controls.Add(this.btnGuardar);
            this.tbDatosPersonales.Controls.Add(this.btnLimpiar);
            this.tbDatosPersonales.Controls.Add(this.cbSangre);
            this.tbDatosPersonales.Controls.Add(this.label8);
            this.tbDatosPersonales.Controls.Add(this.gpGenero);
            this.tbDatosPersonales.Controls.Add(this.txtTelef);
            this.tbDatosPersonales.Controls.Add(this.label7);
            this.tbDatosPersonales.Controls.Add(this.cbNacionalid);
            this.tbDatosPersonales.Controls.Add(this.label6);
            this.tbDatosPersonales.Controls.Add(this.txtCedula);
            this.tbDatosPersonales.Controls.Add(this.txtDireccion);
            this.tbDatosPersonales.Controls.Add(this.txtApellido);
            this.tbDatosPersonales.Controls.Add(this.txtNombre);
            this.tbDatosPersonales.Controls.Add(this.label5);
            this.tbDatosPersonales.Controls.Add(this.cbCedula);
            this.tbDatosPersonales.Controls.Add(this.label4);
            this.tbDatosPersonales.Controls.Add(this.label3);
            this.tbDatosPersonales.Controls.Add(this.label2);
            this.tbDatosPersonales.Controls.Add(this.label1);
            this.tbDatosPersonales.Location = new System.Drawing.Point(4, 22);
            this.tbDatosPersonales.Name = "tbDatosPersonales";
            this.tbDatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tbDatosPersonales.Size = new System.Drawing.Size(575, 282);
            this.tbDatosPersonales.TabIndex = 0;
            this.tbDatosPersonales.Text = "DATOS PERSONALES DEL ESTUDIANTE";
            this.tbDatosPersonales.UseVisualStyleBackColor = true;
            this.tbDatosPersonales.Click += new System.EventHandler(this.tbDatosPersonales_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(80, 196);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(103, 20);
            this.txtEdad.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Edad: ";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(230, 198);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(77, 22);
            this.btnVerificar.TabIndex = 20;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(465, 241);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(89, 30);
            this.btnSiguiente.TabIndex = 19;
            this.btnSiguiente.Text = ">>>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(230, 241);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 28);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(345, 241);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 28);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbSangre
            // 
            this.cbSangre.FormattingEnabled = true;
            this.cbSangre.Items.AddRange(new object[] {
            "ORh +",
            "ORh -",
            "A+",
            "A-"});
            this.cbSangre.Location = new System.Drawing.Point(111, 234);
            this.cbSangre.Name = "cbSangre";
            this.cbSangre.Size = new System.Drawing.Size(81, 21);
            this.cbSangre.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipo de Sangre: ";
            // 
            // gpGenero
            // 
            this.gpGenero.Controls.Add(this.chkF);
            this.gpGenero.Controls.Add(this.chk1M);
            this.gpGenero.Location = new System.Drawing.Point(326, 163);
            this.gpGenero.Name = "gpGenero";
            this.gpGenero.Size = new System.Drawing.Size(234, 72);
            this.gpGenero.TabIndex = 14;
            this.gpGenero.TabStop = false;
            this.gpGenero.Text = "Genero";
            // 
            // chkF
            // 
            this.chkF.AutoEllipsis = true;
            this.chkF.Location = new System.Drawing.Point(134, 35);
            this.chkF.Name = "chkF";
            this.chkF.Size = new System.Drawing.Size(94, 17);
            this.chkF.TabIndex = 1;
            this.chkF.Text = "FEMENINO";
            this.chkF.UseVisualStyleBackColor = true;
            this.chkF.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chk1M
            // 
            this.chk1M.AutoEllipsis = true;
            this.chk1M.Location = new System.Drawing.Point(19, 35);
            this.chk1M.Name = "chk1M";
            this.chk1M.Size = new System.Drawing.Size(92, 17);
            this.chk1M.TabIndex = 0;
            this.chk1M.Text = "MASCULINO";
            this.chk1M.UseVisualStyleBackColor = true;
            this.chk1M.CheckedChanged += new System.EventHandler(this.chk1M_CheckedChanged);
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(80, 160);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(103, 20);
            this.txtTelef.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefono: ";
            // 
            // cbNacionalid
            // 
            this.cbNacionalid.FormattingEnabled = true;
            this.cbNacionalid.Items.AddRange(new object[] {
            "VENEZUELA",
            "PARAGUAY ",
            "PERU",
            "BOLIVIA",
            "COLOMBIA",
            "BRAZIL",
            "EE.UU.",
            "MEXICO",
            "PANAMA",
            "Otro....."});
            this.cbNacionalid.Location = new System.Drawing.Point(417, 121);
            this.cbNacionalid.Name = "cbNacionalid";
            this.cbNacionalid.Size = new System.Drawing.Size(143, 21);
            this.cbNacionalid.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nacionalidad";
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Location = new System.Drawing.Point(406, 80);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(154, 20);
            this.txtCedula.TabIndex = 9;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(80, 121);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(242, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(80, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(242, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de Cédula:";
            // 
            // cbCedula
            // 
            this.cbCedula.FormattingEnabled = true;
            this.cbCedula.Items.AddRange(new object[] {
            "CEDULA NACIONAL",
            "NRO. PASAPORTE"});
            this.cbCedula.Location = new System.Drawing.Point(439, 36);
            this.cbCedula.Name = "cbCedula";
            this.cbCedula.Size = new System.Drawing.Size(121, 21);
            this.cbCedula.TabIndex = 4;
            this.cbCedula.SelectedIndexChanged += new System.EventHandler(this.cbCedula_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cédula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres :";
            // 
            // tbDatosCarreraE
            // 
            this.tbDatosCarreraE.Controls.Add(this.btnPresentar);
            this.tbDatosCarreraE.Controls.Add(this.panel1);
            this.tbDatosCarreraE.Location = new System.Drawing.Point(4, 22);
            this.tbDatosCarreraE.Name = "tbDatosCarreraE";
            this.tbDatosCarreraE.Padding = new System.Windows.Forms.Padding(3);
            this.tbDatosCarreraE.Size = new System.Drawing.Size(575, 282);
            this.tbDatosCarreraE.TabIndex = 1;
            this.tbDatosCarreraE.Text = "DATOS ACADEMICOS DEL ESTUDIANTE";
            this.tbDatosCarreraE.UseVisualStyleBackColor = true;
            // 
            // btnPresentar
            // 
            this.btnPresentar.Location = new System.Drawing.Point(411, 247);
            this.btnPresentar.Name = "btnPresentar";
            this.btnPresentar.Size = new System.Drawing.Size(147, 29);
            this.btnPresentar.TabIndex = 9;
            this.btnPresentar.Text = "PRESENTAR DATOS";
            this.btnPresentar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnGuardar1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.cbCarrera);
            this.panel1.Controls.Add(this.txtInstitucion);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(49, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 222);
            this.panel1.TabIndex = 0;
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(342, 167);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar1.TabIndex = 8;
            this.btnGuardar1.Text = "GUARDAR";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(233, 167);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(127, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "CICLO";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDown1.ForeColor = System.Drawing.Color.Blue;
            this.numericUpDown1.Location = new System.Drawing.Point(67, 149);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbCarrera
            // 
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Items.AddRange(new object[] {
            "SISTEMAS INFORMATICOS",
            "MECANICA",
            "INDUSTRIA DE ALIMENTOS ",
            "LOGICA MATEMATICA",
            "BANCA Y FINANZA",
            "REDES Y TELECOMUNICACIONES",
            "ING. AGRICOLA",
            "MEDICINA",
            "DISEÑO GRAFICO",
            "GASTRONOMIA",
            "ENFERMERIA"});
            this.cbCarrera.Location = new System.Drawing.Point(166, 95);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(167, 21);
            this.cbCarrera.TabIndex = 4;
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.Location = new System.Drawing.Point(166, 37);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(298, 20);
            this.txtInstitucion.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(19, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "CICLO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(19, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "CARRERA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(19, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "INSTITUCION EDUCATIVA:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(16, 334);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(574, 127);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 473);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.tbAgendaE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "AGENDA ESTUDIANTIL";
            this.tbAgendaE.ResumeLayout(false);
            this.tbDatosPersonales.ResumeLayout(false);
            this.tbDatosPersonales.PerformLayout();
            this.gpGenero.ResumeLayout(false);
            this.tbDatosCarreraE.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbAgendaE;
        private System.Windows.Forms.TabPage tbDatosPersonales;
        private System.Windows.Forms.GroupBox gpGenero;
        private System.Windows.Forms.CheckBox chkF;
        private System.Windows.Forms.CheckBox chk1M;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbNacionalid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbDatosCarreraE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSangre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPresentar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label13;
    }
}

