using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades
{
    public static class GuardarString
    {
        /// <summary>
        /// Crea un método de extensión para la clase String.
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            StreamWriter ruta = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo, true);

            bool retorno = false;
            try
            {
                ruta.Write(texto);
                ruta.Close();
                retorno = true;
            }
            catch (Exception e)
            {
                throw e;
            }

            return retorno;
        }
    }
}
