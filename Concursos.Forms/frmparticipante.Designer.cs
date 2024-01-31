namespace Concursos.Forms
{
    partial class frmparticipante
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
            this.GrbPersonalData = new System.Windows.Forms.GroupBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.TbxApellidoPaterno = new System.Windows.Forms.TextBox();
            this.LblApellidoPaterno = new System.Windows.Forms.Label();
            this.TbxApellidoMaterno = new System.Windows.Forms.TextBox();
            this.LblApellidoMaterno = new System.Windows.Forms.Label();
            this.GrbDatosDeContacto = new System.Windows.Forms.GroupBox();
            this.TbxInstitutionalEmail = new System.Windows.Forms.TextBox();
            this.LblInstitutionalEmail = new System.Windows.Forms.Label();
            this.TbxPersonalEmail = new System.Windows.Forms.TextBox();
            this.LblPersonalEmail = new System.Windows.Forms.Label();
            this.TbxTelephoneNumber = new System.Windows.Forms.TextBox();
            this.LblTelephoneNumber = new System.Windows.Forms.Label();
            this.GrbDatosDeCarrera = new System.Windows.Forms.GroupBox();
            this.LblSemestreCursando = new System.Windows.Forms.Label();
            this.LblFechaDeIngreso = new System.Windows.Forms.Label();
            this.LblCarrera = new System.Windows.Forms.Label();
            this.DtpAdmitionDay = new System.Windows.Forms.DateTimePicker();
            this.CbxCarrera = new System.Windows.Forms.ComboBox();
            this.NmrSemestre = new System.Windows.Forms.NumericUpDown();
            this.GrbPersonalData.SuspendLayout();
            this.GrbDatosDeContacto.SuspendLayout();
            this.GrbDatosDeCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrSemestre)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbPersonalData
            // 
            this.GrbPersonalData.Controls.Add(this.TbxApellidoMaterno);
            this.GrbPersonalData.Controls.Add(this.LblApellidoMaterno);
            this.GrbPersonalData.Controls.Add(this.TbxApellidoPaterno);
            this.GrbPersonalData.Controls.Add(this.LblApellidoPaterno);
            this.GrbPersonalData.Controls.Add(this.TbxNombre);
            this.GrbPersonalData.Controls.Add(this.LblNombre);
            this.GrbPersonalData.Location = new System.Drawing.Point(12, 12);
            this.GrbPersonalData.Name = "GrbPersonalData";
            this.GrbPersonalData.Size = new System.Drawing.Size(338, 110);
            this.GrbPersonalData.TabIndex = 0;
            this.GrbPersonalData.TabStop = false;
            this.GrbPersonalData.Text = "Datos Personales";
            this.GrbPersonalData.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(15, 19);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            this.LblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // TbxNombre
            // 
            this.TbxNombre.Location = new System.Drawing.Point(100, 16);
            this.TbxNombre.MaxLength = 15;
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(232, 20);
            this.TbxNombre.TabIndex = 2;
            // 
            // TbxApellidoPaterno
            // 
            this.TbxApellidoPaterno.Location = new System.Drawing.Point(100, 42);
            this.TbxApellidoPaterno.MaxLength = 15;
            this.TbxApellidoPaterno.Name = "TbxApellidoPaterno";
            this.TbxApellidoPaterno.Size = new System.Drawing.Size(232, 20);
            this.TbxApellidoPaterno.TabIndex = 4;
            // 
            // LblApellidoPaterno
            // 
            this.LblApellidoPaterno.AutoSize = true;
            this.LblApellidoPaterno.Location = new System.Drawing.Point(15, 45);
            this.LblApellidoPaterno.Name = "LblApellidoPaterno";
            this.LblApellidoPaterno.Size = new System.Drawing.Size(84, 13);
            this.LblApellidoPaterno.TabIndex = 3;
            this.LblApellidoPaterno.Text = "Apellido Paterno";
            this.LblApellidoPaterno.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TbxApellidoMaterno
            // 
            this.TbxApellidoMaterno.Location = new System.Drawing.Point(100, 68);
            this.TbxApellidoMaterno.MaxLength = 15;
            this.TbxApellidoMaterno.Name = "TbxApellidoMaterno";
            this.TbxApellidoMaterno.Size = new System.Drawing.Size(232, 20);
            this.TbxApellidoMaterno.TabIndex = 4;
            this.TbxApellidoMaterno.TextChanged += new System.EventHandler(this.TxbApellidoMaterno_TextChanged);
            // 
            // LblApellidoMaterno
            // 
            this.LblApellidoMaterno.AutoSize = true;
            this.LblApellidoMaterno.Location = new System.Drawing.Point(15, 68);
            this.LblApellidoMaterno.Name = "LblApellidoMaterno";
            this.LblApellidoMaterno.Size = new System.Drawing.Size(86, 13);
            this.LblApellidoMaterno.TabIndex = 3;
            this.LblApellidoMaterno.Text = "Apellido Materno";
            // 
            // GrbDatosDeContacto
            // 
            this.GrbDatosDeContacto.Controls.Add(this.TbxTelephoneNumber);
            this.GrbDatosDeContacto.Controls.Add(this.LblTelephoneNumber);
            this.GrbDatosDeContacto.Controls.Add(this.TbxInstitutionalEmail);
            this.GrbDatosDeContacto.Controls.Add(this.LblInstitutionalEmail);
            this.GrbDatosDeContacto.Controls.Add(this.TbxPersonalEmail);
            this.GrbDatosDeContacto.Controls.Add(this.LblPersonalEmail);
            this.GrbDatosDeContacto.Location = new System.Drawing.Point(12, 147);
            this.GrbDatosDeContacto.Name = "GrbDatosDeContacto";
            this.GrbDatosDeContacto.Size = new System.Drawing.Size(338, 104);
            this.GrbDatosDeContacto.TabIndex = 1;
            this.GrbDatosDeContacto.TabStop = false;
            this.GrbDatosDeContacto.Text = "Datos de Contacto";
            // 
            // TbxInstitutionalEmail
            // 
            this.TbxInstitutionalEmail.Location = new System.Drawing.Point(94, 45);
            this.TbxInstitutionalEmail.MaxLength = 50;
            this.TbxInstitutionalEmail.Name = "TbxInstitutionalEmail";
            this.TbxInstitutionalEmail.Size = new System.Drawing.Size(238, 20);
            this.TbxInstitutionalEmail.TabIndex = 4;
            // 
            // LblInstitutionalEmail
            // 
            this.LblInstitutionalEmail.AutoSize = true;
            this.LblInstitutionalEmail.Location = new System.Drawing.Point(3, 48);
            this.LblInstitutionalEmail.Name = "LblInstitutionalEmail";
            this.LblInstitutionalEmail.Size = new System.Drawing.Size(91, 13);
            this.LblInstitutionalEmail.TabIndex = 3;
            this.LblInstitutionalEmail.Text = "Email Institucional";
            // 
            // TbxPersonalEmail
            // 
            this.TbxPersonalEmail.Location = new System.Drawing.Point(94, 19);
            this.TbxPersonalEmail.MaxLength = 50;
            this.TbxPersonalEmail.Name = "TbxPersonalEmail";
            this.TbxPersonalEmail.Size = new System.Drawing.Size(238, 20);
            this.TbxPersonalEmail.TabIndex = 6;
            // 
            // LblPersonalEmail
            // 
            this.LblPersonalEmail.AutoSize = true;
            this.LblPersonalEmail.Location = new System.Drawing.Point(6, 22);
            this.LblPersonalEmail.Name = "LblPersonalEmail";
            this.LblPersonalEmail.Size = new System.Drawing.Size(76, 13);
            this.LblPersonalEmail.TabIndex = 5;
            this.LblPersonalEmail.Text = "Email Personal";
            // 
            // TbxTelephoneNumber
            // 
            this.TbxTelephoneNumber.Location = new System.Drawing.Point(94, 71);
            this.TbxTelephoneNumber.Name = "TbxTelephoneNumber";
            this.TbxTelephoneNumber.Size = new System.Drawing.Size(238, 20);
            this.TbxTelephoneNumber.TabIndex = 8;
            // 
            // LblTelephoneNumber
            // 
            this.LblTelephoneNumber.AutoSize = true;
            this.LblTelephoneNumber.Location = new System.Drawing.Point(3, 74);
            this.LblTelephoneNumber.Name = "LblTelephoneNumber";
            this.LblTelephoneNumber.Size = new System.Drawing.Size(93, 13);
            this.LblTelephoneNumber.TabIndex = 7;
            this.LblTelephoneNumber.Text = "Número de celular";
            // 
            // GrbDatosDeCarrera
            // 
            this.GrbDatosDeCarrera.Controls.Add(this.NmrSemestre);
            this.GrbDatosDeCarrera.Controls.Add(this.CbxCarrera);
            this.GrbDatosDeCarrera.Controls.Add(this.DtpAdmitionDay);
            this.GrbDatosDeCarrera.Controls.Add(this.LblFechaDeIngreso);
            this.GrbDatosDeCarrera.Controls.Add(this.LblSemestreCursando);
            this.GrbDatosDeCarrera.Controls.Add(this.LblCarrera);
            this.GrbDatosDeCarrera.Location = new System.Drawing.Point(434, 12);
            this.GrbDatosDeCarrera.Name = "GrbDatosDeCarrera";
            this.GrbDatosDeCarrera.Size = new System.Drawing.Size(306, 110);
            this.GrbDatosDeCarrera.TabIndex = 9;
            this.GrbDatosDeCarrera.TabStop = false;
            this.GrbDatosDeCarrera.Text = "Datos de la Carrera";
            // 
            // LblSemestreCursando
            // 
            this.LblSemestreCursando.AutoSize = true;
            this.LblSemestreCursando.Location = new System.Drawing.Point(3, 48);
            this.LblSemestreCursando.Name = "LblSemestreCursando";
            this.LblSemestreCursando.Size = new System.Drawing.Size(99, 13);
            this.LblSemestreCursando.TabIndex = 7;
            this.LblSemestreCursando.Text = "Semestre Cursando";
            // 
            // LblFechaDeIngreso
            // 
            this.LblFechaDeIngreso.AutoSize = true;
            this.LblFechaDeIngreso.Location = new System.Drawing.Point(6, 74);
            this.LblFechaDeIngreso.Name = "LblFechaDeIngreso";
            this.LblFechaDeIngreso.Size = new System.Drawing.Size(78, 13);
            this.LblFechaDeIngreso.TabIndex = 3;
            this.LblFechaDeIngreso.Text = "Año de ingreso";
            this.LblFechaDeIngreso.Click += new System.EventHandler(this.LblFechaDeIngreso_Click);
            // 
            // LblCarrera
            // 
            this.LblCarrera.AutoSize = true;
            this.LblCarrera.Location = new System.Drawing.Point(6, 22);
            this.LblCarrera.Name = "LblCarrera";
            this.LblCarrera.Size = new System.Drawing.Size(41, 13);
            this.LblCarrera.TabIndex = 5;
            this.LblCarrera.Text = "Carrera";
            // 
            // DtpAdmitionDay
            // 
            this.DtpAdmitionDay.Location = new System.Drawing.Point(106, 74);
            this.DtpAdmitionDay.Name = "DtpAdmitionDay";
            this.DtpAdmitionDay.Size = new System.Drawing.Size(200, 20);
            this.DtpAdmitionDay.TabIndex = 9;
            this.DtpAdmitionDay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CbxCarrera
            // 
            this.CbxCarrera.FormattingEnabled = true;
            this.CbxCarrera.Items.AddRange(new object[] {
            "Ingeniería en Software",
            "Diseño Digital",
            "Diseño de Modas",
            "Arquitectura",
            "Ingeniería Mecatrónica",
            "Derecho",
            ""});
            this.CbxCarrera.Location = new System.Drawing.Point(106, 16);
            this.CbxCarrera.Name = "CbxCarrera";
            this.CbxCarrera.Size = new System.Drawing.Size(121, 21);
            this.CbxCarrera.TabIndex = 10;
            this.CbxCarrera.SelectedIndexChanged += new System.EventHandler(this.CbxCarrera_SelectedIndexChanged);
            // 
            // NmrSemestre
            // 
            this.NmrSemestre.Location = new System.Drawing.Point(108, 46);
            this.NmrSemestre.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NmrSemestre.Name = "NmrSemestre";
            this.NmrSemestre.Size = new System.Drawing.Size(120, 20);
            this.NmrSemestre.TabIndex = 11;
            // 
            // frmparticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrbDatosDeCarrera);
            this.Controls.Add(this.GrbDatosDeContacto);
            this.Controls.Add(this.GrbPersonalData);
            this.Name = "frmparticipante";
            this.Text = "frmparticipante";
            this.GrbPersonalData.ResumeLayout(false);
            this.GrbPersonalData.PerformLayout();
            this.GrbDatosDeContacto.ResumeLayout(false);
            this.GrbDatosDeContacto.PerformLayout();
            this.GrbDatosDeCarrera.ResumeLayout(false);
            this.GrbDatosDeCarrera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrSemestre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbPersonalData;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.TextBox TbxApellidoPaterno;
        private System.Windows.Forms.Label LblApellidoPaterno;
        private System.Windows.Forms.TextBox TbxApellidoMaterno;
        private System.Windows.Forms.Label LblApellidoMaterno;
        private System.Windows.Forms.GroupBox GrbDatosDeContacto;
        private System.Windows.Forms.TextBox TbxTelephoneNumber;
        private System.Windows.Forms.Label LblTelephoneNumber;
        private System.Windows.Forms.TextBox TbxInstitutionalEmail;
        private System.Windows.Forms.Label LblInstitutionalEmail;
        private System.Windows.Forms.TextBox TbxPersonalEmail;
        private System.Windows.Forms.Label LblPersonalEmail;
        private System.Windows.Forms.GroupBox GrbDatosDeCarrera;
        private System.Windows.Forms.Label LblSemestreCursando;
        private System.Windows.Forms.Label LblFechaDeIngreso;
        private System.Windows.Forms.Label LblCarrera;
        private System.Windows.Forms.DateTimePicker DtpAdmitionDay;
        private System.Windows.Forms.ComboBox CbxCarrera;
        private System.Windows.Forms.NumericUpDown NmrSemestre;
    }
}