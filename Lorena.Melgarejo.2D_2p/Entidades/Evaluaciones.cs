using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Evaluaciones
    {
        public int notaUno;
        public int notaDos;
        public float notaF;
        public string observaciones;



        public Evaluaciones()
        { }

        public int NotaUno
        {
           get{ return notaUno;}
           set{notaUno=value;}
        }

        public int NotaDos
        {
            get { return notaDos; }
            set { notaDos = value; }
        }

        public float NotaF
        {
            get { return notaF; }
            set { notaF = value; }
        }


        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }


        public float Promedio(int uno, int dos)
        {
            float prom;
            prom = ((float)uno + (float)dos) / 2;
            return prom;
        }

    }
}
