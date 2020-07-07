using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class ArchivoTexto
    {
        public static void Escribir(IArchivo objeto, bool append)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(objeto.Ruta, append, Encoding.UTF8);
                sw.Write(objeto.Texto);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public static string Leer(string ruta)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(ruta);
                return sr.ReadToEnd();
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
