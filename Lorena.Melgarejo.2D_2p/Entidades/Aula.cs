using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        private List<Alumno> alumnos;
        private EColores colorSala;
        private Docente docente;
        private ETurno turno;

        //    #region PROPIEDADES

        public List<Alumno> Alumnos
        {
            get
            { return this.alumnos; }

            set
            { this.alumnos = value; }
        }

        public EColores ColorSala
        {
            get
            { return this.colorSala; }

            set
            { this.colorSala = value; }
        }

        public Docente Docente
        {
            get
            { return docente; }

            set
            { this.docente = value; }
        }

        //    public ETurno Turno
        //    {
        //        get
        //        { return this.turno; }

        //        set
        //        { this.turno = value; }
        //    }

        //    #endregion

        //    #region METODOS

        //    /// <summary>
        //    /// constructor que inicializa la lista
        //    /// </summary>

        private Aula()
        {
            this.alumnos = new List<Alumno>();
        }


        public Aula(EColores colorS, ETurno turn, Docente docent) : this()
        {
            colorSala = colorS;
            turno = turn;
            docente = docent;
        }


        //    /// <summary>
        //    /// Agrega un alumno al Aula
        //    /// </summary>
        //    /// <param name="aula"></param>
        //    /// <param name="alumno"></param>
        //    /// <returns></returns>
        //    public static bool operator +(Aula aula, Alumno alumno)
        //    {
        //        bool retorno = false;

        //        if (aula.alumnos.Count() <= 30)
        //        {
        //            foreach (Alumno item in aula.alumnos)
        //            {
        //                if (item != alumno)
        //                {

        //                    aula.alumnos.Add(alumno);
        //                    return true;
        //                }

        //            }


        //        }
        //        return retorno;
        //    }



        //    /// <summary>
        //    /// muestra los datos del Aula
        //    /// </summary>
        //    /// <param name="aulita"></param>
        //    /// <returns></returns>
        public string Mostrar(Aula aulita)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Color de aula: " + this.colorSala);
            sb.AppendFormat("Docente: {0} {1}", this.Docente.Nombre, this.Docente.Apellido);
            sb.AppendLine("Turno : " + this.turno);
            sb.AppendLine("ALUMNOS : ");
            foreach (Alumno item in aulita.alumnos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();

        }

        
    }
}
