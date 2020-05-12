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
    public partial class FrmAltaAlumno : Form
    {
        //List<Alumno> alum= new List<Alumno>();

        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        public Responsable.EParentesco responsable;
        //private string telefono;
        private string apellido;
        private int dni;
        private bool femenino;
        private string nombre;
        public Alumno alumno;
        private bool v;
        private List<Alumno> listaAlumnitos;





        // Alumno miAlumno = new Alumno("Maria", "Perez", 602145753, true, 2500, 001, Responsable.EParentesco.Abuela, EColores.Amarillo);

        public FrmAltaAlumno()
        {
            InitializeComponent();
            Responsable resp = new Responsable("maria", "", 15487897,true,Responsable.EParentesco.Abuela,"144546566");
            //this.miAlumno = new List<Alumno>();
           // List<Alumno> alum = new List<Alumno>();
        }


        public FrmAltaAlumno(List<Alumno> listaAlumnitos) : this()
        {
            this.listaAlumnitos = listaAlumnitos;
        }


        public Alumno Alumno
        {
            get
            {
                return this.alumno;
            }

            set
            {
                this.alumno = value;
            }
        }



        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {
            cmbColores.DataSource = Enum.GetValues(typeof(EColores));
            cmbResponsable.DataSource = Enum.GetValues(typeof(Responsable.EParentesco));

        }


        public Alumno retornarMetodo()
        {
            return  new Alumno(this.nombre,this.apellido,this.dni,this.femenino, this.precioCuota,this.legajo, this.responsable, this.colorSala);
        }

        /// <summary>
        /// Se guardara los datos ingresados
        /// en el formulario alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
           this.nombre = txtNombre.Text;
           this.apellido = txtApellido.Text;
           this.dni = Convert.ToInt32(txtDni.Text);
          // this.femenino = Convert.ToBoolean(txtFemenino.Text);
           this.legajo = Convert.ToInt32(txtLegajo.Text);
           this.responsable = (Responsable.EParentesco)cmbResponsable.SelectedItem;
           this.colorSala = (EColores)cmbColores.SelectedItem;
           this.precioCuota = Convert.ToInt64(txtCuota.Text);           
           this.alumno = retornarMetodo();
           MessageBox.Show("Los datos se han guardado correctamente" + alumno.ToString());
           
            if (this.DialogResult == DialogResult.OK)
            {
                this.alumno = retornarMetodo();
               // this.listaAlumnitos.Add(alumno);  //tira una excepcion
                MessageBox.Show("Los datos se han guardado correctamente" + alumno.ToString());
            }

        }



        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form formularioInicio = new FrmMenuInicio();
            formularioInicio.Show();
            this.Hide();
        }


        /// <summary>
        /// Valida que los valores ingresados en los campos sean numericos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <=255))
            {
                MessageBox.Show("valores invalidos, solo valores numericos");
                e.Handled = true;
            }
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("valores invalidos, solo valores numericos");
                e.Handled = true;
            }
        }

        private void txtCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("valores invalidos, solo valores numericos");
                e.Handled = true;
            }
        }

        private void btnResponsable_Click(object sender, EventArgs e)
        {
            Form formularioResponsable = new FrmResponsable();
            formularioResponsable.Show();
            this.Hide();

        }
    }
}
