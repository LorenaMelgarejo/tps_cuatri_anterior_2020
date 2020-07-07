using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Excepciones
{
    class SerialiceException : Exception, IArchivo
    {
        public SerialiceException(string message, Exception innerException) : base(message, innerException)
        {
            ArchivoTexto.Escribir(this, true);
        }

        public string Texto
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(DateTime.Now.ToString() + ":");
                sb.AppendLine(this.Message);
                Exception innerException = this.InnerException;
                while (innerException != null)
                {
                    sb.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }

                return sb.ToString();
            }
        }

        public string Ruta
        {
            get
            {
                return String.Format("{0}log.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            }
        }
    }
}
