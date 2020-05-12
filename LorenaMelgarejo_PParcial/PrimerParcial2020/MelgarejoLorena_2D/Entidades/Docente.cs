using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente: Personal
    {
        private double valorHora;

        #region PROPIEDADES

        public int HorasMesuales
        {
            get
            {
                int horasM;
                horasM = 4 * 20;
                return horasM;
            }
        }

        public double ValorHora
        {
            get
            { return this.valorHora; }

            set
            { this.valorHora = value; }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// metodo que calcula el salario mensual
        /// </summary>
        /// <returns>salario</returns>

        protected override double CalcularSalario()
        {
            double salario;
            salario = valorHora * HorasMesuales;
            return salario;
        }


        /// <summary>
        /// Inicializa un Docente
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="horaSalida"></param>
        /// <param name="valorHora"></param>
        public Docente(string nombre, string apellido ,int dni, bool femenino,DateTime horaEntrada, DateTime horaSalida, double valorHora):base(nombre, apellido,dni,femenino,horaEntrada,horaSalida)
        {
            this.valorHora = valorHora;
        }


        /// <summary>
        /// Muestra los datos del docente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("Valor Hora: " + this.valorHora);
            sb.AppendLine("Horas Mensuales: " + this.HorasMesuales);
            sb.AppendLine("Sueldo : " + this.CalcularSalario());
            return sb.ToString();

        }

        #endregion
    }
}
