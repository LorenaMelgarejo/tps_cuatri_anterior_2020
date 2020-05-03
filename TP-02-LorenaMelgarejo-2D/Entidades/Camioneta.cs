using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta:Vehiculo
    {
        #region CONSTRUCTORES
        public Camioneta(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Las camionetas son grandes,
        ///  se modifico la firma ya que debe tener la misma firma que la clase base.
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// falto invocar al método Tostring.
        /// </summary>
        /// <returns>sb.ToString</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMIONETA");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
