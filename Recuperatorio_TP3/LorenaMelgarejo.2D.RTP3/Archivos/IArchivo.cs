using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {
        
        /// <summary>
        /// Guarda en un archivo 
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Guardar(string archivo, T datos);

        /// <summary>
        /// Lee en un archivo 
        /// </summary>
        /// <param name="archivo"> Path del archivo</param>
        /// <param name="datos"> Clase a guardar</param>
        /// <returns></returns>
        bool Leer(string archivo, out T datos);
       
    }

}
