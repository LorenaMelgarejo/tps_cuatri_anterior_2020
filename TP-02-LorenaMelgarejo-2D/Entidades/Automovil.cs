using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        public enum ETipo
        {
            Monovolumen, Sedan
        }

        private ETipo tipo;

        #region CONSTRUCTORES

        /// <summary>
        /// Se creo un constructor que contenga 3 parametros, 
        /// que heredan de la clase padre
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Automovil(EMarca marca, string chasis, ConsoleColor color):base(chasis,marca,color)
        {
        }

        /// <summary>
        /// Por defecto, TIPO será Monovolumen,
        /// Se agrego el parametro tipo.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        

        public Automovil(EMarca marca, string chasis, ConsoleColor color, ETipo tipo):this(marca,chasis,color)
        {
            this.tipo = tipo;
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Los automoviles son medianos,
        /// se modifico la firma ya que debe tener la misma firma que la clase base.
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }


        /// <summary>
        ///  falto invocar al método Tostring.
        ///  se cambio el appendline por appendformat
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
