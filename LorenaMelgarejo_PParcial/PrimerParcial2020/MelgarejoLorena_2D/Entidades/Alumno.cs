using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Alumno : Persona
    {
       

        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        public Responsable.EParentesco responsable;

        #region PROPIEDADES

        public EColores ColorSala
        {
            get
            { return this.colorSala; }

            set
            { this.colorSala = value; }
        }

        public int Legajo
        {
            get
            { return this.legajo; }

            set
            { this.legajo = value; }
        }

        public float PrecioCuota
        {
            get
            { return this.precioCuota; }

            set
            { this.precioCuota = value; }
        }

        public Responsable.EParentesco Responsable
        {
            get
            { return responsable; }

            set
            { this.responsable = value; }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// inicializa un Alumno
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="precioCuota"></param>
        /// <param name="legajo"></param>
        /// <param name="responsable"></param>
        /// <param name="colorSala"></param>

        public Alumno( string nombre, string apellido, int dni, bool femenino,float precioCuota,int legajo,Responsable.EParentesco responsable, EColores colorSala):base(nombre, apellido,dni,femenino)
        {
            this.colorSala = ColorSala;
            this.legajo = legajo;
            this.precioCuota = precioCuota;
            this.responsable = responsable;
            
        }


        /// <summary>
        /// retorna el responsable del alumnno pasado por parametro
        /// </summary>
        /// <param name="al"></param>
        public static implicit operator Responsable.EParentesco(Alumno al)
        {
            return al.responsable;
        }

        /// <summary>
        /// Dos Alumnos son iguales si comparten legajo 
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            return (a1.legajo == a2.legajo);
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
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
            sb.AppendLine("Legajo: " + this.legajo);
            sb.AppendLine("Responsable: " + this.Responsable);
            sb.AppendLine("Precio cuota: " + this.precioCuota);
            return sb.ToString();

        }



        #endregion
    }
}
