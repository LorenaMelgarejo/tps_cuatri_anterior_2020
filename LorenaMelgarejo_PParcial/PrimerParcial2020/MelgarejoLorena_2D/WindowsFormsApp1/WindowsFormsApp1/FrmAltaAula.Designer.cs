namespace WindowsFormsApp1
{
    partial class FrmAltaAula
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
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbDocente = new System.Windows.Forms.ComboBox();
            this.gbConAula = new System.Windows.Forms.GroupBox();
            this.lstAlumConAula = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.gbSinAula = new System.Windows.Forms.GroupBox();
            this.gbConAula.SuspendLayout();
            this.gbSinAula.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(24, 60);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(73, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color de Aula:";
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Location = new System.Drawing.Point(93, 56);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(97, 21);
            this.cmbColores.TabIndex = 2;
            this.cmbColores.SelectedIndexChanged += new System.EventHandler(this.cmbColores_SelectedIndexChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(206, 59);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "Turno:";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(376, 59);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(51, 13);
            this.lblDocente.TabIndex = 4;
            this.lblDocente.Text = "Docente:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cmbTurno.Location = new System.Drawing.Point(250, 53);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(101, 21);
            this.cmbTurno.TabIndex = 5;
            // 
            // cmbDocente
            // 
            this.cmbDocente.FormattingEnabled = true;
            this.cmbDocente.Items.AddRange(new object[] {
            "Laura Ojeda",
            "Marcela Rearte",
            "Nadia Lopez",
            "Cecilia Nina"});
            this.cmbDocente.Location = new System.Drawing.Point(424, 55);
            this.cmbDocente.Name = "cmbDocente";
            this.cmbDocente.Size = new System.Drawing.Size(101, 21);
            this.cmbDocente.TabIndex = 6;
            // 
            // gbConAula
            // 
            this.gbConAula.Controls.Add(this.lstAlumConAula);
            this.gbConAula.Location = new System.Drawing.Point(27, 161);
            this.gbConAula.Name = "gbConAula";
            this.gbConAula.Size = new System.Drawing.Size(195, 367);
            this.gbConAula.TabIndex = 7;
            this.gbConAula.TabStop = false;
            this.gbConAula.Text = "Alumnos con Aula";
            // 
            // lstAlumConAula
            // 
            this.lstAlumConAula.FormattingEnabled = true;
            this.lstAlumConAula.Location = new System.Drawing.Point(6, 19);
            this.lstAlumConAula.Name = "lstAlumConAula";
            this.lstAlumConAula.Size = new System.Drawing.Size(183, 329);
            this.lstAlumConAula.TabIndex = 12;
            this.lstAlumConAula.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbAlumConAula_DragDrop);
            this.lstAlumConAula.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbAlumConAula_DragEnter);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(352, 556);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.AllowDrop = true;
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(11, 19);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(193, 342);
            this.lstAlumnos.TabIndex = 11;
            this.lstAlumnos.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstAlumnos_DragEnter);
            this.lstAlumnos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstAlumnos_MouseDown);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(51, 556);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(153, 23);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "Ir al Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // gbSinAula
            // 
            this.gbSinAula.Controls.Add(this.lstAlumnos);
            this.gbSinAula.Location = new System.Drawing.Point(323, 155);
            this.gbSinAula.Name = "gbSinAula";
            this.gbSinAula.Size = new System.Drawing.Size(214, 372);
            this.gbSinAula.TabIndex = 13;
            this.gbSinAula.TabStop = false;
            this.gbSinAula.Text = "Alumnos sin Aula";
            // 
            // FrmAltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(560, 591);
            this.Controls.Add(this.gbSinAula);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbConAula);
            this.Controls.Add(this.cmbDocente);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.cmbColores);
            this.Controls.Add(this.lblColor);
            this.Name = "FrmAltaAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Aula";
            this.Load += new System.EventHandler(this.FrmAltaAula_Load);
            this.gbConAula.ResumeLayout(false);
            this.gbSinAula.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbDocente;
        private System.Windows.Forms.GroupBox gbConAula;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.ListBox lstAlumConAula;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.GroupBox gbSinAula;
    }
}