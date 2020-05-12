using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private bool femenino;
        private string nombre;


        #region PROPIEDADES

        public string Apellido
        {
            get
            { return this.apellido;}

            set
            { this.apellido = value;}
        }

        public int Dni
        {
            get
            { return this.dni;}

            set
            { this.dni = value;}
        }

        public bool Femenino
        {
            get
            { return this.femenino; }

            set
            { this.femenino = value; }

        }

        public string Nombre
        {
            get
            { return this.nombre; }

            set
            { this.nombre = value; }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Inicializa una Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>

        protected Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        protected Persona(string nombre, string apellido, int dni, bool femenino):this(nombre,apellido,dni)//protected
        {
            this.femenino = femenino;
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
            sb.AppendLine("Femenino: " + this.femenino);
            
            return sb.ToString();

        }

        #endregion
    }
}