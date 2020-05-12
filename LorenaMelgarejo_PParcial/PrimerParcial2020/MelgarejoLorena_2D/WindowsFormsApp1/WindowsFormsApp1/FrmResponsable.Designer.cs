namespace WindowsFormsApp1
{
    partial class FrmResponsable
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
            this.llbNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFemenino = new System.Windows.Forms.Label();
            this.lblParentesco = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtFemenino = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnMAlumno = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // llbNombre
            // 
            this.llbNombre.AutoSize = true;
            this.llbNombre.Location = new System.Drawing.Point(21, 20);
            this.llbNombre.Name = "llbNombre";
            this.llbNombre.Size = new System.Drawing.Size(44, 13);
            this.llbNombre.TabIndex = 0;
            this.llbNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(21, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(21, 88);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "Dni";
            // 
            // lblFemenino
            // 
            this.lblFemenino.AutoSize = true;
            this.lblFemenino.Location = new System.Drawing.Point(21, 123);
            this.lblFemenino.Name = "lblFemenino";
            this.lblFemenino.Size = new System.Drawing.Size(53, 13);
            this.lblFemenino.TabIndex = 3;
            this.lblFemenino.Text = "Femenino";
            // 
            // lblParentesco
            // 
            this.lblParentesco.AutoSize = true;
            this.lblParentesco.Location = new System.Drawing.Point(21, 161);
            this.lblParentesco.Name = "lblParentesco";
            this.lblParentesco.Size = new System.Drawing.Size(61, 13);
            this.lblParentesco.TabIndex = 4;
            this.lblParentesco.Text = "Parentesco";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(21, 197);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.Location = new System.Drawing.Point(100, 194);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(112, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtFemenino
            // 
            this.txtFemenino.Location = new System.Drawing.Point(100, 116);
            this.txtFemenino.Name = "txtFemenino";
            this.txtFemenino.Size = new System.Drawing.Size(112, 20);
            this.txtFemenino.TabIndex = 9;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(100, 85);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(112, 20);
            this.txtDni.TabIndex = 10;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(100, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(112, 20);
            this.txtApellido.TabIndex = 11;
            // 
            // btnMAlumno
            // 
            this.btnMAlumno.Location = new System.Drawing.Point(24, 253);
            this.btnMAlumno.Name = "btnMAlumno";
            this.btnMAlumno.Size = new System.Drawing.Size(75, 21);
            this.btnMAlumno.TabIndex = 12;
            this.btnMAlumno.Text = "Menu Alum";
            this.btnMAlumno.UseVisualStyleBackColor = true;
            this.btnMAlumno.Click += new System.EventHandler(this.btnMAlumno_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(125, 253);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 21);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(101, 157);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(110, 21);
            this.cmbResponsable.TabIndex = 14;
            // 
            // FrmResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(249, 319);
            this.Controls.Add(this.cmbResponsable);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnMAlumno);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtFemenino);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblParentesco);
            this.Controls.Add(this.lblFemenino);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.llbNombre);
            this.Name = "FrmResponsable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Responsable";
            this.Load += new System.EventHandler(this.FrmResponsable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llbNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblFemenino;
        private System.Windows.Forms.Label lblParentesco;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtFemenino;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnMAlumno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbResponsable;
    }
}