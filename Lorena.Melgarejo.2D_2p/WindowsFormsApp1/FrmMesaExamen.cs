using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    //delegate void Atender(object o);
    public partial class FrmMesaExamen : Form
    {
        
        //public delegate void DelegadoLlamada();
        //public event DelegadoLlamada llamada;        
        List<Alumno> alumnitos;       
        Queue<Alumno> filaAlum;
        SqlConnection conexion;             
        SqlCommand miComando;              
        SqlDataReader informe;
        //DataTable filaAlumnos;
        List<Evaluaciones> examen;
        //List<Thread> hilos;
        //event Atender AtenderProximo;
        

        public FrmMesaExamen()
        {
            miComando = new SqlCommand();
            conexion = new SqlConnection("Data Source = DESKTOP-57AHTKO\\SQLEXPRESS; DataBase = JardinUtn; Integrated security=True;");
            InitializeComponent();
            Alumno alum = new Alumno();
            alumnitos = new List<Alumno>();
            filaAlum= new Queue<Alumno>();
            examen = new List<Evaluaciones>();
            //hilos = new List<Thread>();
            
        }

        private void FrmMesaExamen_Load(object sender, EventArgs e)
        {
            

        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                string alum;
                DataTable filaAlumnos = new DataTable();
                dgvAlumnos.DataSource = null;
                dgvAlumnos.RowHeadersVisible = false;//me elimina la columna que tiene la flecha
                miComando.Connection = conexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT Nombre  FROM Alumnos";

                conexion.Open();

                informe = miComando.ExecuteReader();// es cuando la consulta viaja al serve y la trae
                filaAlumnos.Load(informe);
                dgvAlumnos.DataSource = filaAlumnos;

                while (informe.Read())
                {
                    alum = informe["Nombre"].ToString();

                    // filaAlum.Enqueue(new Alumno());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {
            this.txtNota1.Multiline = true;
        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {
            this.txtNota2.Multiline = true;
        }

       
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int nota1;
            int nota2;
            float notaF;
            string observacion;

            nota1 = int.Parse(txtNota1.Text);
            nota2 = int.Parse(txtNota2.Text);
          

            notaF = ((float)nota1 + (float)nota2)/2;
            txtNotaF.Text = notaF.ToString();


            if (notaF <= 5)
            {
                observacion = "DESAPROBADO";
                txtObservacion.Text = observacion;
            }
            else
            {
                observacion = "APROBADO!!";
                txtObservacion.Text = observacion;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNotaF.Clear();
            txtNombre.Clear();
            txtAula.Clear();
            txtProfesor.Clear();
            txtObservacion.Clear();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-57AHTKO\\SQLEXPRESS; DataBase = JardinUtn; Integrated security=True;"))
            {
                
                miComando.CommandText = "INSERT INTO dbo.Evaluaciones(idAlumno,idDocente,idAula,Nota_1, Nota_2, NotaFinal,Observaciones) VALUES(@idAlumno,@idDocente,@idAula,@Nota_1, @Nota_2, @NotaFinal, @Observaciones);";
                miComando.Connection = conexion;
                miComando.CommandType = CommandType.Text;
                miComando.Parameters.AddWithValue("@idAlumno", txtNombre.Text);
                miComando.Parameters.AddWithValue("@idDocente", txtProfesor.Text);
                miComando.Parameters.AddWithValue("@idAula", txtAula.Text);
                miComando.Parameters.AddWithValue("@Nota_1", txtNota1.Text);
                miComando.Parameters.AddWithValue("@Nota_2", txtNota2.Text);
                miComando.Parameters.AddWithValue("@NotaFinal",txtNotaF.Text);
                miComando.Parameters.AddWithValue("@Observaciones", txtObservacion.Text);
                conexion.Open();
                miComando.ExecuteNonQuery();

            }
        }

        private void btnDescarga_Click(object sender, EventArgs e)
        {             
                Alumno alum= new Alumno();
                alum.Nombre= txtNombre.Text;
                alum.Apellido = txtApellido.Text;
                alum.Promedio = Convert.ToInt32(txtNotaF.Text);


             string ArchivoXml = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"SegundoParcial\JardinUtn\Apellido_Nombre_dia_mes_año.xml");
            //string ArchivoXml = AppDomain.CurrentDomain.BaseDirectory + "Apellido_Nombre_dia_mes_año.xml";

            try
            {
               
                using (XmlTextWriter writer = new XmlTextWriter(ArchivoXml, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Alumno));
                    ser.Serialize(writer, alum);
                }

                using (XmlTextReader reader = new XmlTextReader(ArchivoXml))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Alumno));

                    Alumno aux = new Alumno();

                    aux = (Alumno)ser.Deserialize(reader);

                    Console.WriteLine(aux.ToString());

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Console.Read();
            }


        }
    }
}
