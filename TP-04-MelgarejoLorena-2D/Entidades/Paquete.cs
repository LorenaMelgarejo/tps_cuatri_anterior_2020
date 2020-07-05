using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        #region DELEGADO
        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformaEstado;
        #endregion

        #region ENUMERADO
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
        #endregion

        #region ATRIBUTOS
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        #endregion

        #region PROPIEDADES
        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }
        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }
        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }
        #endregion

        #region CONSTRUCTOR
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
            // this.Estado = EEstado.Ingresado;
        }
        #endregion
        #region METODOS


        /// <summary>
        /// Muestra los datos
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = new Paquete(((Paquete)elemento).direccionEntrega, ((Paquete)elemento).trackingID);

            return string.Format("{0} para {1}\n", p.trackingID, p.direccionEntrega);
        }

        /// <summary>
        /// retorna la información del paquete
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }


        public void MockCicloDeVida()
        {
            while (true)
            {
                Thread.Sleep(4000);

                if (this.Estado != EEstado.Entregado)
                {
                    this.Estado++;
                    this.InformaEstado(this, new EventArgs());
                }
                else
                {
                    this.InformaEstado(this, new EventArgs());
                    try
                    {
                        PaqueteDAO.Insertar(this);
                    }
                    catch (Exception e)
                    {
                        this.InformaEstado(e, new EventArgs());
                    }
                    break;
                }
            }
        }

        #endregion
        #region SOBRECARGAS
        /// <summary>
        /// Dos paquetes serán iguales siempre y cuando su Tracking ID sea el mismo
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.trackingID == p2.trackingID);
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
