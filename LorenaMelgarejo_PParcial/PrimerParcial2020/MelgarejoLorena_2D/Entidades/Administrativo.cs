using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrativo: Personal
    {
        private ECargo cargo;
        public static double salarioBase;

        #region PROPIEDADES

        public ECargo Cargo
        {
            get
            { return this.cargo; }

            set
            { this.cargo = value; }
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Asigna a salario el valor de 30000
        /// </summary>
        
        static Administrativo()
        {
            salarioBase = 30000;
        }


        /// <summary>
        /// Constructor que inicializa Administratico
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="horaSalida"></param>
        /// <param name="cargo"></param>
        /// <param name="salarioB"></param>
        
        public Administrativo(string apellido, string nombre, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, ECargo cargo, double salarioB ):base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this.cargo = cargo;
            salarioBase = salarioB;

        }


        /// <summary>
        /// Metodo que Calcula el salario segun el cargo
        /// </summary>
        /// <returns></returns>
        
        protected override double CalcularSalario()
        {
            double sueldo = 0;

            switch (cargo)
            {
                case ECargo.Cocina:
                    sueldo = (salarioBase * 110)/100;
                    break;

                case ECargo.Dirección:
                    sueldo = (salarioBase * 180)/100;
                    break;

                case ECargo.Portería:
                    sueldo= (salarioBase * 100)/100;
                    break;

                case ECargo.Secretaría:
                    sueldo = (salarioBase * 140)/100;
                    break;

                case ECargo.Tesorería:
                    sueldo = (salarioBase * 240)/100;
                    break;                    

            }
            return sueldo;


        }


        /// <summary>
        /// Muestra los datos de Administrativo
        /// </summary>
        /// <returns></returns>
        
        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("Cargo: " + this.cargo);
            sb.AppendLine("Salario : " + this.CalcularSalario());
            return sb.ToString();

        }


        #endregion
    }
}
