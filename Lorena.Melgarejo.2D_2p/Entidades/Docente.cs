using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class Docente:Persona
    {
        public string email;
        public string sexo;

        #region PROPIEDADES

        public string Email
        {
            get
            { return this.email; }

            set
            { this.email = value; }
        }

        public string Sexo
        {
            get
            { return this.sexo; }

            set
            { this.sexo = value; }
        }

        #endregion



        /// <summary>
        /// Inicializa un Docente
        public Docente()
        { }
        
        public Docente(string nombre, string apellido, int dni, int edad, string direccion,int id,string email,string sexo) : base(nombre,apellido,dni,edad,direccion,id)
        {
            this.email = email;
            this.sexo = sexo;
            
        }

        ///// <summary>
        ///// Muestra los datos del docente
        ///// </summary>
        ///// <returns></returns>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("Email: " + this.email);
            sb.AppendLine("Sexo: " + this.sexo);
            return sb.ToString();

        }

        public static string Leer()
        {
            Xml<Docente> auxArchivo = new Xml<Docente>();
            //List<Docente> auxArchivo = new List<Docente>();
            //string path = AppDomain.CurrentDomain.BaseDirectory;
            string path= (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcial\JardinUtn\Docentes.xml");
            if (!auxArchivo.Leer(path + @"Docentes.xml", out Docente rtn))
            {
                rtn = null;
            }

            return rtn.ToString();
        }

        //public static Docente Leer()
        //{
        //    Docente retorno;
        //    Xml<Docente> aux = new Xml<Docente>();
        //    if (aux.Leer("Docente.xml", out retorno) == false)
        //    {
        //        // throw new ArchivosException("Error al leer la universidad.");
        //    }
        //    return retorno;
        //}


    }
}