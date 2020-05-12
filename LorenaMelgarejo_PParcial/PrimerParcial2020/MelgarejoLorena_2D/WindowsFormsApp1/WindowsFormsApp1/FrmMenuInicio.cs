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
    public partial class FrmMenuInicio : Form
    {
        List<Alumno> listaAlumnitos;
        List<Docente> listaDocente;
        List<Administrativo> listaAdmin;



        public FrmMenuInicio()
        {
            InitializeComponent();
            listaAlumnitos = new List<Alumno>();
            listaDocente = new List<Docente>();
            listaAdmin = new List<Administrativo>();
        }

        private void altaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario3 = new FrmAltaAula(this.listaAlumnitos,this.listaDocente);
            formulario3.Show();
            this.Hide();

            
        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario4 = new FrmAltaAlumno();
            formulario4.Show();
            this.Hide();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Se cargara por defectos 50 alumnos, 5 docentes, 10 no docentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmMenuInicio_Load(object sender, EventArgs e)
        {
           
            listaAlumnitos.Add(new Alumno("Maria","Perez", 60125478, true,2500, 001, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Lucas","Gualpa", 62785478, false,2500, 002, Responsable.EParentesco.Tio, EColores.Naranja));
            listaAlumnitos.Add(new Alumno("Noelia","Fernandez", 62455478, true,2500, 003, Responsable.EParentesco.Abuela, EColores.Rojo));
            listaAlumnitos.Add(new Alumno("Mario","Perez", 62425478, false,2500, 004, Responsable.EParentesco.Otro, EColores.Verde));
            listaAlumnitos.Add(new Alumno("Mirian","Godoy", 63125478, true,2500, 005, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Santiago","Loez", 61425478, false,2500, 006, Responsable.EParentesco.Madre, EColores.Naranja));
            listaAlumnitos.Add(new Alumno("Cecilia","Nina", 60125478, true,2500, 007, Responsable.EParentesco.Abuelo, EColores.Rojo));
            listaAlumnitos.Add(new Alumno("Maria","ojeda", 67825478, true,2500, 008, Responsable.EParentesco.Madre, EColores.Verde));
            listaAlumnitos.Add(new Alumno("Marcela","Rearte", 68725478, true,2500, 009, Responsable.EParentesco.Madre, EColores.Verde));
            listaAlumnitos.Add(new Alumno("Gisell","Perez", 67825478, true,2500, 010, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Maria","Perez", 6425478, true,2500, 011, Responsable.EParentesco.Madre, EColores.Naranja));
            listaAlumnitos.Add(new Alumno("Maria","Sosa", 60125478, true,2500, 012, Responsable.EParentesco.Madre, EColores.Rojo));
            listaAlumnitos.Add(new Alumno("Facu","Romero", 60235478, false,2500, 013, Responsable.EParentesco.Otro, EColores.Verde));
            listaAlumnitos.Add(new Alumno("Gaby","Ravena", 64525478, false,2500, 014, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Maria","Perez", 60125478, true,2500, 015, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Mimi","Paez", 61425478, true,2500, 016, Responsable.EParentesco.Madre, EColores.Naranja));
            listaAlumnitos.Add(new Alumno("Jose","Perez", 60125478, false,2500, 017, Responsable.EParentesco.Tia, EColores.Verde));
            listaAlumnitos.Add(new Alumno("Teo", "Manao", 61425478, false,2500, 018, Responsable.EParentesco.Otro, EColores.Rojo));
            listaAlumnitos.Add(new Alumno("Juan","Lopez", 60125478, false,2500, 020, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Leo", "Perez", 69825478, false,2500, 021, Responsable.EParentesco.Madre, EColores.Rojo));
            listaAlumnitos.Add(new Alumno("Riqui","Aquino", 62895478,false,2500, 022, Responsable.EParentesco.Padre, EColores.Verde));
            listaAlumnitos.Add(new Alumno("Maria", "Perez", 60125414, true,2500, 023, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Maria", "Perez", 60125425, true,2500, 024, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Tania", "Perez", 60125478, true,2500, 025, Responsable.EParentesco.Madre, EColores.Rojo));
            listaAlumnitos.Add(new Alumno("Maria", "Nina", 60121478, true,2500, 026, Responsable.EParentesco.Madre, EColores.Verde));
            listaAlumnitos.Add(new Alumno("Simon", "Perez", 60745478,false,2500, 027, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Tais", "Ppppp", 60125478, true,2500, 030, Responsable.EParentesco.Madre, EColores.Rojo));
            listaAlumnitos.Add(new Alumno("Toto", "Nuez", 60125658, false,2500, 031, Responsable.EParentesco.Padre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Lalo", "Perez", 60125148, false,2500, 032, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Maria", "Perez", 61425478, true,2500, 033, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Nadia", "Lalal", 60121478, true,2500, 034, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Maria", "Perez", 60125478, true,2500, 035, Responsable.EParentesco.Madre, EColores.Verde));
            listaAlumnitos.Add(new Alumno("Kalia", "Xio", 60125478, true,2500, 036, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Bauti", "Perez", 69825478, false,2500, 037, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Maria", "Guzman", 6225478, true,2500, 038, Responsable.EParentesco.Madre, EColores.Rojo));
            listaAlumnitos.Add(new Alumno("Pepito", "Perez", 67825478, false,2500, 039, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Ruben", "Paez", 60178478, false,2500, 040, Responsable.EParentesco.Madre, EColores.Naranja));
            listaAlumnitos.Add(new Alumno("Mimi", "Perez", 62225478, true,2500, 041, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Rodri", "Roman", 60125478, false,2500, 042, Responsable.EParentesco.Madre, EColores.Naranja));
            listaAlumnitos.Add(new Alumno("Maria", "Perez", 60125789, true,2500, 043, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Morella", "Perez", 60335478, true,2500, 044, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Marcia", "Nnnnz", 60125478, true,2500, 045, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Simon", "Perez", 65825478, false,2500, 046, Responsable.EParentesco.Madre, EColores.Naranja));
            listaAlumnitos.Add(new Alumno("Maria", "Perez", 60125420, true,2500, 047, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Cecila", "Perez", 61125478, true,2500, 048, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Nicolas", "Perez", 62225478, false,2500, 049, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Teo", "Perez", 64425478, false,2500, 050, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Mami", "Perez", 60125478, true,2500, 051, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Maria", "Perez", 60125478, true,2500, 052, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Mia", "Perez", 60125478, true,2500, 053, Responsable.EParentesco.Madre, EColores.Amarillo));
            listaAlumnitos.Add(new Alumno("Maria", "Perez", 60125478, true,2500, 054, Responsable.EParentesco.Madre, EColores.Amarillo));


            listaDocente.Add(new Docente("Celia", "Moreno", 25498498,true, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"),250));
            listaDocente.Add(new Docente("Mirian", "Perez", 27498498, true, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"), 250));
            listaDocente.Add(new Docente("Carina", "Diaz", 26698498, true, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"), 250));
            listaDocente.Add(new Docente("Tereza", "Perez", 23398498, true, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"), 250));
            listaDocente.Add(new Docente("Laura", "Gomez", 20198498, true, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"), 250));

            listaAdmin.Add(new Administrativo("Dario", "Perez", 60125478, false, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"),ECargo.Cocina,30000));
            listaAdmin.Add(new Administrativo("Mirian", "Perez", 60125478, true, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"),ECargo.Portería,30000));
            listaAdmin.Add(new Administrativo("Martin", "Perez", 60125478, false, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"),ECargo.Secretaría,30000));
            listaAdmin.Add(new Administrativo("Maria", "Godoy", 60125478, true, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"),ECargo.Cocina,30000));
            listaAdmin.Add(new Administrativo("Lucas", "Torrez", 60125478, false, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"),ECargo.Dirección,30000));
            listaAdmin.Add(new Administrativo("Maria", "Perez", 60125478, true, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"),ECargo.Cocina,30000));
            listaAdmin.Add(new Administrativo("Maria", "Perez", 60125478, true, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"),ECargo.Cocina,30000));
            listaAdmin.Add(new Administrativo("Leo", "Mendez", 60125478, false, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"),ECargo.Tesorería,30000));
            listaAdmin.Add(new Administrativo("Maria", "Perez", 60125478, true, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"),ECargo.Cocina,30000));
            listaAdmin.Add(new Administrativo("Carmen", "Amaru", 60125478, false, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"),ECargo.Portería,30000));
            listaAdmin.Add(new Administrativo("Maria", "Perez", 60125478, true, Convert.ToDateTime("11/05/2020 8:00"), Convert.ToDateTime("11/05/2020 12:00"), ECargo.Cocina, 30000));









        }
    } 
}
            