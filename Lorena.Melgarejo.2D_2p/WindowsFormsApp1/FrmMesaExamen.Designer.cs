namespace WindowsFormsApp1
{
    partial class FrmMesaExamen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstAEvaluar = new System.Windows.Forms.ListBox();
            this.lstEvaluados = new System.Windows.Forms.ListBox();
            this.lblListAlumnos = new System.Windows.Forms.Label();
            this.lblProximoAlum = new System.Windows.Forms.Label();
            this.lblAlumEvaluados = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lsbDocente = new System.Windows.Forms.ListBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtNotaF = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNotaF = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblAula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnDescarga = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAEvaluar
            // 
            this.lstAEvaluar.FormattingEnabled = true;
            this.lstAEvaluar.Location = new System.Drawing.Point(303, 386);
            this.lstAEvaluar.Name = "lstAEvaluar";
            this.lstAEvaluar.Size = new System.Drawing.Size(141, 69);
            this.lstAEvaluar.TabIndex = 1;
            // 
            // lstEvaluados
            // 
            this.lstEvaluados.FormattingEnabled = true;
            this.lstEvaluados.Location = new System.Drawing.Point(482, 399);
            this.lstEvaluados.Name = "lstEvaluados";
            this.lstEvaluados.Size = new System.Drawing.Size(131, 56);
            this.lstEvaluados.TabIndex = 2;
            // 
            // lblListAlumnos
            // 
            this.lblListAlumnos.AutoSize = true;
            this.lblListAlumnos.Location = new System.Drawing.Point(13, 289);
            this.lblListAlumnos.Name = "lblListAlumnos";
            this.lblListAlumnos.Size = new System.Drawing.Size(47, 13);
            this.lblListAlumnos.TabIndex = 3;
            this.lblListAlumnos.Text = "Alumnos";
            // 
            // lblProximoAlum
            // 
            this.lblProximoAlum.AutoSize = true;
            this.lblProximoAlum.Location = new System.Drawing.Point(300, 349);
            this.lblProximoAlum.Name = "lblProximoAlum";
            this.lblProximoAlum.Size = new System.Drawing.Size(92, 13);
            this.lblProximoAlum.TabIndex = 4;
            this.lblProximoAlum.Text = "Proximo a Evaluar";
            // 
            // lblAlumEvaluados
            // 
            this.lblAlumEvaluados.AutoSize = true;
            this.lblAlumEvaluados.Location = new System.Drawing.Point(479, 359);
            this.lblAlumEvaluados.Name = "lblAlumEvaluados";
            this.lblAlumEvaluados.Size = new System.Drawing.Size(100, 13);
            this.lblAlumEvaluados.TabIndex = 5;
            this.lblAlumEvaluados.Text = "Alumnos Evaluados";
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(309, 468);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 6;
            this.lblDocente.Text = "Docente";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.EnableHeadersVisualStyles = false;
            this.dgvAlumnos.Location = new System.Drawing.Point(16, 318);
            this.dgvAlumnos.Name = "dgvAlumnos";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.Size = new System.Drawing.Size(268, 234);
            this.dgvAlumnos.TabIndex = 7;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(16, 576);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(198, 26);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar Alumnos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lsbDocente
            // 
            this.lsbDocente.FormattingEnabled = true;
            this.lsbDocente.Location = new System.Drawing.Point(302, 496);
            this.lsbDocente.Name = "lsbDocente";
            this.lsbDocente.Size = new System.Drawing.Size(109, 56);
            this.lsbDocente.TabIndex = 9;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.lblApellido);
            this.gbxDatos.Controls.Add(this.txtApellido);
            this.gbxDatos.Controls.Add(this.btnDescarga);
            this.gbxDatos.Controls.Add(this.btnLimpiar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.txtObservacion);
            this.gbxDatos.Controls.Add(this.btnCalcular);
            this.gbxDatos.Controls.Add(this.txtProfesor);
            this.gbxDatos.Controls.Add(this.txtAula);
            this.gbxDatos.Controls.Add(this.txtNotaF);
            this.gbxDatos.Controls.Add(this.txtNota2);
            this.gbxDatos.Controls.Add(this.txtNota1);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(this.lblObservaciones);
            this.gbxDatos.Controls.Add(this.lblNota2);
            this.gbxDatos.Controls.Add(this.lblNotaF);
            this.gbxDatos.Controls.Add(this.lblNota1);
            this.gbxDatos.Controls.Add(this.lblProfesor);
            this.gbxDatos.Controls.Add(this.lblAula);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Location = new System.Drawing.Point(58, 34);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(521, 225);
            this.gbxDatos.TabIndex = 10;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos Alumno";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(395, 187);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(213, 187);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(9, 171);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(189, 39);
            this.txtObservacion.TabIndex = 22;
            this.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(276, 107);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(39, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "=";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(400, 41);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor.TabIndex = 21;
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(276, 41);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(100, 20);
            this.txtAula.TabIndex = 20;
            // 
            // txtNotaF
            // 
            this.txtNotaF.Location = new System.Drawing.Point(343, 107);
            this.txtNotaF.Name = "txtNotaF";
            this.txtNotaF.Size = new System.Drawing.Size(100, 20);
            this.txtNotaF.TabIndex = 19;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(138, 108);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 18;
            this.txtNota2.TextChanged += new System.EventHandler(this.txtNota2_TextChanged);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(9, 107);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 17;
            this.txtNota1.TextChanged += new System.EventHandler(this.txtNota1_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(9, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(6, 140);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 16;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(159, 91);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 13);
            this.lblNota2.TabIndex = 15;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblNotaF
            // 
            this.lblNotaF.AutoSize = true;
            this.lblNotaF.Location = new System.Drawing.Point(340, 91);
            this.lblNotaF.Name = "lblNotaF";
            this.lblNotaF.Size = new System.Drawing.Size(55, 13);
            this.lblNotaF.TabIndex = 11;
            this.lblNotaF.Text = "Nota Final";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(9, 91);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 13);
            this.lblNota1.TabIndex = 14;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(397, 25);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(46, 13);
            this.lblProfesor.TabIndex = 13;
            this.lblProfesor.Text = "Profesor";
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Location = new System.Drawing.Point(273, 25);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(28, 13);
            this.lblAula.TabIndex = 12;
            this.lblAula.Text = "Aula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(511, 524);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(47, 28);
            this.btnLlamar.TabIndex = 11;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseCompatibleTextRendering = true;
            this.btnLlamar.UseVisualStyleBackColor = true;
            // 
            // btnDescarga
            // 
            this.btnDescarga.Location = new System.Drawing.Point(301, 187);
            this.btnDescarga.Name = "btnDescarga";
            this.btnDescarga.Size = new System.Drawing.Size(75, 23);
            this.btnDescarga.TabIndex = 25;
            this.btnDescarga.Text = "Descargar";
            this.btnDescarga.UseVisualStyleBackColor = true;
            this.btnDescarga.Click += new System.EventHandler(this.btnDescarga_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(138, 41);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 26;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(135, 25);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 27;
            this.lblApellido.Text = "Apellido";
            // 
            // FrmMesaExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 614);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.lsbDocente);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.lblAlumEvaluados);
            this.Controls.Add(this.lblProximoAlum);
            this.Controls.Add(this.lblListAlumnos);
            this.Controls.Add(this.lstEvaluados);
            this.Controls.Add(this.lstAEvaluar);
            this.Name = "FrmMesaExamen";
            this.Text = "Mesa de Examen";
            this.Load += new System.EventHandler(this.FrmMesaExamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstAEvaluar;
        private System.Windows.Forms.ListBox lstEvaluados;
        private System.Windows.Forms.Label lblListAlumnos;
        private System.Windows.Forms.Label lblProximoAlum;
        private System.Windows.Forms.Label lblAlumEvaluados;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lsbDocente;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNotaF;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtNotaF;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDescarga;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
    }
}

