using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class FrmResponsable : Form
    {
        private string nombre;
        private string apellido;
        private int dni;
        private bool femenino;
        public Responsable.EParentesco responsable;
        private string telefono;
        public Responsable parentesco;
        //private bool v;
        private List<Responsable> listaResponsable;


        public FrmResponsable()
        {
            InitializeComponent();
        }


        public FrmResponsable(List<Responsable> listaResponsable) : this()
        {
            this.listaResponsable= listaResponsable;
        }


        public Responsable Responsable
        {
            get
            {
                return this.parentesco;
            }

            set
            {
                this.parentesco = value;
            }
        }

        private void btnMAlumno_Click(object sender, EventArgs e)
        {
            Form formularioAlumno = new FrmAltaAlumno();
            formularioAlumno.Show();
            this.Hide();
        }

        private void FrmResponsable_Load(object sender, EventArgs e)
        {
            cmbResponsable.DataSource = Enum.GetValues(typeof(Responsable.EParentesco));
        }



        public Responsable retornarMetodo()
        {
            return new Responsable(this.nombre, this.apellido, this.dni, this.femenino, this.responsable, this.telefono);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.nombre = txtNombre.Text;
            this.apellido = txtApellido.Text;
            this.dni = Convert.ToInt32(txtDni.Text);
            //this.femenino = Convert.ToBoolean(txtFemenino.Text);            
            this.responsable = (Responsable.EParentesco)cmbResponsable.SelectedItem;
            this.telefono = txtTelefono.Text;
           // this.responsable = retornarMetodo();
            MessageBox.Show("Los datos se han guardado correctamente" );
            //this.listaResponsable.Add(parentesco);

            if (this.DialogResult == DialogResult.OK)
            {
                this.parentesco = retornarMetodo();
                // this.listaResposable.Add(Responsable);  //tira una excepcion
                MessageBox.Show("Los datos se han guardado correctamente" + parentesco.ToString());
            }
        }


        /// <summary>
        /// Valida que los valores ingresados en los campos sean numericos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("valores invalidos, solo valores numericos");
                e.Handled = true;
            }
        }
    }
}
