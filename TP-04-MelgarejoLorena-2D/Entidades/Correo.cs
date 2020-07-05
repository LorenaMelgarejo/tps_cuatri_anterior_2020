using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region ATRIBUTOS
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        #endregion
        #region PROPIEDADES
        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }
        #endregion
        #region CONSTRUCTOR
        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }
        #endregion
        #region METODOS

        /// <summary>
        /// Finaliza todos los hilos activos de la clase correo
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread hilo in this.mockPaquetes)
            {
                if (hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }


        /// <summary>
        ///  Devuelve la informacion del campo paquetes
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            string retorno = "";

            if (!(elementos is null))
            {
                foreach (Paquete p in ((Correo)elementos).paquetes)
                {

                    retorno += string.Format("{0} para {1} ({2})\n", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());

                }
            }

            return retorno;
        }

        #endregion
        #region  OPERADORES
        /// <summary>
        ///  agrega el paquete a la lista de paquetes
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            Thread t;

            foreach (Paquete item in c.Paquetes)
            {
                if (item == p)
                {
                    throw new TrackingIdRepetidoException(string.Format("El Tracking ID {0} ya figura en la lista de envíos", item.TrackingID));
                }
            }

            c.Paquetes.Add(p);
            t = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(t);
            t.Start();

            return c;


        }
        #endregion
    }
}
