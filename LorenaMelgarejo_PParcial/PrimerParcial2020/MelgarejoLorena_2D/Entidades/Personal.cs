using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal: Persona
    {
        private DateTime horaEntrada;
        private DateTime horaSalida;

        #region PROPIEDADES

        public DateTime HoraEntrada
        {
            get
            { return this.horaEntrada; }

            set
            { this.horaEntrada = value; }
        }

        public DateTime HoraSalida
        {
            get
            { return this.horaSalida; }

            set
            { this.horaSalida = value; }
        }

        public double Salario
        {
            get
            { return CalcularSalario(); }
        }

        #endregion

        #region METODOS

        protected abstract double CalcularSalario();
        
        /// <summary>
        /// inicializa un Personal
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="horaSalida"></param>
        
        protected Personal(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida):base(nombre, apellido,dni,femenino)
        {
            this.horaEntrada = horaEntrada; //DateTime.Parse("");
            this.horaSalida = horaSalida;//DateTime.Parse("");
        }


        /// <summary>
        /// muestra los datos de la clase Personal
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("Hora de entrada: " + this.horaEntrada.ToString());
            sb.AppendLine("Hora de salida: " + this.horaSalida.ToString() );           
            return sb.ToString();

        }

        #endregion

    }
}
