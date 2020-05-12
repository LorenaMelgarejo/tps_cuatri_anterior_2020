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
    public partial class FrmAltaAula : Form
    {
        List<Alumno> alumnitos;
        List<Docente> losDocentes;

        public FrmAltaAula()
        {
            InitializeComponent();
            lstAlumnos.AllowDrop = true;
            lstAlumConAula.AllowDrop = true;
            this.alumnitos = new List<Alumno>();
           // List<Docente> doc = new List<Docente>();
            this.losDocentes = new List<Docente>();
        }


        public FrmAltaAula(List<Alumno> lista,List<Docente> listdoc) : this()
        {
            this.alumnitos = lista;
            this.losDocentes = listdoc;
            
        }

        private void FrmAltaAula_Load(object sender, EventArgs e)
        {
            cmbColores.DataSource = Enum.GetValues(typeof(EColores));
            cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
            cmbDocente.DataSource = losDocentes;

            lstAlumnos.DataSource = alumnitos;


        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lstAlumConAula.Items.Add(lstAlumnos.Items);
        }

        private void lstAlumnos_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lstAlumnos_MouseDown(object sender, MouseEventArgs e)
        {
            lstAlumConAula.DoDragDrop(lstAlumnos.SelectedItem.ToString() , DragDropEffects.Copy);
        }

        private void lbAlumConAula_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lbAlumConAula_DragDrop(object sender, DragEventArgs e)
        {
            lstAlumConAula.Items.Add(e.Data.GetData(DataFormats.Text));
           // lstAlumnos.Items.Remove(e.Data.GetData(DataFormats.Text));
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form formularioInicio = new FrmMenuInicio();
            formularioInicio.Show();
            this.Hide();
        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((EColores)cmbColores.SelectedValue)
            {
                case EColores.Amarillo:
                    this.BackColor = Color.Yellow;
                    break;
                case EColores.Naranja:
                    this.BackColor = Color.Orange;
                    break;
                case EColores.Rojo:
                    this.BackColor = Color.Red;
                    break;
                case EColores.Verde:
                    this.BackColor = Color.Green;
                    break;
            }
        }

       
    }
}
