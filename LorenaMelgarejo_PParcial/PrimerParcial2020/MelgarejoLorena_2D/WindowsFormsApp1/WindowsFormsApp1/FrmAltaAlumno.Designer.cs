namespace WindowsFormsApp1
{
    partial class FrmAltaAlumno
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblCSala = new System.Windows.Forms.Label();
            this.lblPrecioCuota = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.lblFemenino = new System.Windows.Forms.Label();
            this.txtFemenino = new System.Windows.Forms.TextBox();
            this.btnResponsable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 65);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(12, 100);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "Dni";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(13, 241);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(69, 13);
            this.lblResponsable.TabIndex = 3;
            this.lblResponsable.Text = "Responsable";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(12, 168);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 4;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblCSala
            // 
            this.lblCSala.AutoSize = true;
            this.lblCSala.Location = new System.Drawing.Point(13, 205);
            this.lblCSala.Name = "lblCSala";
            this.lblCSala.Size = new System.Drawing.Size(55, 13);
            this.lblCSala.TabIndex = 5;
            this.lblCSala.Text = "Color Sala";
            // 
            // lblPrecioCuota
            // 
            this.lblPrecioCuota.AutoSize = true;
            this.lblPrecioCuota.Location = new System.Drawing.Point(13, 276);
            this.lblPrecioCuota.Name = "lblPrecioCuota";
            this.lblPrecioCuota.Size = new System.Drawing.Size(68, 13);
            this.lblPrecioCuota.TabIndex = 6;
            this.lblPrecioCuota.Text = "Precio Cuota";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(137, 93);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(117, 20);
            this.txtDni.TabIndex = 8;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(137, 58);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(117, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(137, 165);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(117, 20);
            this.txtLegajo.TabIndex = 10;
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajo_KeyPress);
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(137, 276);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(117, 20);
            this.txtCuota.TabIndex = 11;
            this.txtCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuota_KeyPress);
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(137, 241);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(117, 21);
            this.cmbResponsable.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(101, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(72, 24);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(181, 337);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(90, 24);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.Text = "Ir al Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Location = new System.Drawing.Point(137, 202);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(117, 21);
            this.cmbColores.TabIndex = 16;
            // 
            // lblFemenino
            // 
            this.lblFemenino.AutoSize = true;
            this.lblFemenino.Location = new System.Drawing.Point(12, 132);
            this.lblFemenino.Name = "lblFemenino";
            this.lblFemenino.Size = new System.Drawing.Size(50, 13);
            this.lblFemenino.TabIndex = 17;
            this.lblFemenino.Text = "femenino";
            // 
            // txtFemenino
            // 
            this.txtFemenino.Location = new System.Drawing.Point(137, 129);
            this.txtFemenino.Name = "txtFemenino";
            this.txtFemenino.Size = new System.Drawing.Size(117, 20);
            this.txtFemenino.TabIndex = 18;
            // 
            // btnResponsable
            // 
            this.btnResponsable.Location = new System.Drawing.Point(15, 338);
            this.btnResponsable.Name = "btnResponsable";
            this.btnResponsable.Size = new System.Drawing.Size(80, 23);
            this.btnResponsable.TabIndex = 19;
            this.btnResponsable.Text = "Responsable";
            this.btnResponsable.UseVisualStyleBackColor = true;
            this.btnResponsable.Click += new System.EventHandler(this.btnResponsable_Click);
            // 
            // FrmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(283, 394);
            this.Controls.Add(this.btnResponsable);
            this.Controls.Add(this.txtFemenino);
            this.Controls.Add(this.lblFemenino);
            this.Controls.Add(this.cmbColores);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbResponsable);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPrecioCuota);
            this.Controls.Add(this.lblCSala);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.MaximizeBox = false;
            this.Name = "FrmAltaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Alumno";
            this.Load += new System.EventHandler(this.FrmAltaAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblCSala;
        private System.Windows.Forms.Label lblPrecioCuota;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Label lblFemenino;
        private System.Windows.Forms.TextBox txtFemenino;
        private System.Windows.Forms.Button btnResponsable;
    }
}