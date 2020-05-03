using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:Vehiculo
    {
        #region CONSTRUCTORES
        /// <summary>
        /// se llama a los atributos de la clase padre
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Moto(EMarca marca, string chasis, ConsoleColor color):base(chasis,marca,color)
        {
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Las motos son chicas
        /// se modifico la firma ya que debe tener la misma firma que la clase base.
        /// </summary>
        protected override ETamanio Tamanio // protected new short Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        /// <summary>
        /// el método debe ser público.
        /// falto invocar al método Tostring.
        /// </summary>
        /// <returns></returns>

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
           // sb.AppendLine(this.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}" , this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
