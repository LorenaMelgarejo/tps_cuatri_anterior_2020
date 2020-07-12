using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda cadena de texto en un archivo y lo retorna 
        /// </summary>
        /// <param name="archivo"> Path del archivo</param>
        /// <param name="datos"> Cadena de texto a guardar</param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {

            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(datos.ToString());
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException("Archivos Exception", ex);
            }

        }

        /// <summary>
        /// Recibe el dato de un archivo y retorna con true
        /// </summary>
        /// <param name="archivo"> Path del archivo</param>
        /// <param name="datos"> Salida del archivo</param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    datos = reader.ReadToEnd();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException("Archivos Exception", ex);
            }
        }

    }
}
