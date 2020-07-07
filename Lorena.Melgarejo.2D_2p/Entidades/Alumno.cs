using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno: Persona
    {
        

        private EColores colorSala;
        private int id;
        public float promedio;
        //    //private int legajo;
        //    //private float precioCuota;
        public Responsable.EParentesco responsable;

        public EColores ColorSala
        {
            get
            { return this.colorSala; }

            set
            { this.colorSala = value; }
        }

        public float Promedio
        {
            get
            { return this.promedio; }

            set
            { this.promedio = value; }
        }


        public Responsable.EParentesco Responsable
        {
            get
            { return responsable; }

            set
            { this.responsable = value; }
        }

    
        public Alumno()
        { }

        /// <summary>
        /// Inicializa  un Alumno
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        /// <param name="direccion"></param>
        /// <param name="id"></param>
        /// <param name="colorSala"></param>
        /// <param name="promedio"></param>

        public Alumno(string nombre, string apellido, int dni, int edad, string direccion, int id, EColores colorSala, float promedio) : base(nombre, apellido, dni, edad, direccion, id)
        {
            this.colorSala = ColorSala;
            this.promedio = promedio;
        }


        ///// <summary>
        ///// retorna el responsable del alumnno pasado por parametro
        ///// </summary>
        ///// <param name="al"></param>
        public static implicit operator Responsable.EParentesco(Alumno al)
        {
            return al.responsable;
        }


        /// <summary>
        /// Muestra los datos del Alumno
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("Color de Sala: " + this.colorSala);
            sb.AppendLine("Id: " + this.id);
            sb.AppendLine("promedio: " + this.promedio);
            return sb.ToString();

        }



        
    }
}
