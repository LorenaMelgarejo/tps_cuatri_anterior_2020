using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Responsable : Persona
    {
        public enum EParentesco
        {
            Madre,
            Padre,
            Tia,
            Tio,
            Abuela,
            Abuelo,
            Otro
        }

        public EParentesco parentesco;
        private string telefono;

        #region PROPIEDADES

        public EParentesco Parentesco
        {
            get
            { return this.parentesco; }

            set
            { this.parentesco = value; }

        }

        public string Telefono
        {
            get
            { return this.telefono; }

            set
            { this.telefono = value; }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// constructor de instancia publico que pide todos sus atributos y los setea.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="femenino"></param>
        /// <param name="parentesco"></param>
        /// <param name="telefono"></param>

        public Responsable(string nombre, string apellido, int dni, int edad, string direccion, int id,EParentesco parentesco,string telefono) : base(nombre, apellido, dni, edad, direccion, id)
        {
            this.parentesco = parentesco;
            this.telefono = telefono;
        }


        /// <summary>
        /// Muestra los datos de Responsable
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("Parentesco: " + this.Parentesco);
            sb.AppendLine("Telefono: " + this.telefono);
            return sb.ToString();

        }

        #endregion
    }
}
