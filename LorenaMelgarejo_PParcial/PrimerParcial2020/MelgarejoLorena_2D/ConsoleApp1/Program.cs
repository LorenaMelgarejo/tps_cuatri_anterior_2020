using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsoleApp1
//namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Alumno a1 = new Alumno("Lucia","Salazar",455896324,true,2500,1658,Responsable.EParentesco.Abuela,EColores.Amarillo);
           // Alumno a4 = new Alumno("Lucia", "Salazar", 455896324, true, 2500, 1658,Entidades.Responsable.EParentesco, EColores.Amarillo);



            // Alumno a2 = new Alumno("Maria", "Salas", 455896324, true, 2500, 1658, Responsable.EParentesco.Otro, EColores.Amarillo);
            //Alumno a3= new Alumno("Lucas", "Salazar", 455896324, false, 2500, 1658, Responsable.EParentesco.Abuelo, EColores.Amarillo);
            Administrativo ad = new Administrativo("Perez", "Juan", 283256987, false, DateTime.Parse("08:00"),DateTime.Parse("12:00"), ECargo.Tesorería, 30000);
            Responsable res = new Responsable("nadia", "Xio",21456987,true,Responsable.EParentesco.Abuela,"1245589799");
            Docente doc = new Docente("Mora", "Fink", 29214758, true, DateTime.Parse("08:00"), DateTime.Parse("12:00"), 300);
           // Aula salon = new Aula(EColores.Amarillo,ETurno.Tarde,);
            //Console.WriteLine(a1.ToString());
           Console.WriteLine(ad.ToString());
            //Console.WriteLine(res.ToString());
            //Console.WriteLine(doc.ToString());
            //Console.WriteLine(salon.Mostrar(salon));
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
