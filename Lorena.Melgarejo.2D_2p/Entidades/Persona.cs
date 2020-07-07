using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string apellido;
        private string nombre;
        private int dni;
        private int edad;
        private string direccion;
        private int id;

        
        #region PROPIEDADES


        public string Nombre
        {
            get
            { return this.nombre; }

            set
            { this.nombre = value; }
        }

        public string Apellido
        {
            get
            { return this.apellido; }

            set
            { this.apellido = value; }
        }

        public int Dni
        {
            get
            { return this.dni; }

            set
            { this.dni = value; }
        }

        public string Direccion
        {
            get
            { return this.direccion; }

            set
            { this.direccion = value; }
        }

       public int Edad
        {
            get
            { return this.edad; }

            set
            { this.edad = value; }
        }

        public int Id
        {
            get
            { return this.id; }

            set
            { this.id = value; }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Inicializa una Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        
        public Persona()
        { }

        public Persona(string nombre, string apellido, int dni,int edad,string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.direccion=direccion;
          
        }

        public Persona(string nombre, string apellido, int dni, int edad, string direccion, int id):this()
        {
            this.id = id;
        }


        /// <summary>
        /// Muestra los datos de persona
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre:" + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Dni: " + this.dni);
            sb.AppendLine("Edad: " + this.edad);
            sb.AppendLine("Direcion: " + this.direccion);
            sb.AppendLine("Id: " + this.id);

            return sb.ToString();

        }

        #endregion
    }
}
