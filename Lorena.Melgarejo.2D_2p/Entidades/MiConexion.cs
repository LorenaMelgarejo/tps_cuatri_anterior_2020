using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class MiConexion
    {
   
        #region Atributos
        private static SqlCommand comando;
        private static SqlConnection conexion;
       // private static SqlDataReader data;
        #endregion


        public static void Conectar()
        {
            conexion = new SqlConnection("Data Source = DESKTOP - 57AHTKO\\SQLEXPRESS; Initial Catalog = JardinUtn; Integrated Security = True");
            comando = new SqlCommand();
            comando.Connection = conexion;
            //conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            
        }

        public static void Insertar(Docente doc)
        {
            //List<Docente> listadoD; 
            Docente docente = new Docente();
            try
            {
                string cmd = String.Format("INSERT INTO dbo.Docentes(Nombre, Apellido, Edad, Sexo, Dni, Direccion, Email) VALUES(@Nombre, @Apellido, @Edad, @Sexo, @Dni, @Direccion, @Email)" );               
                comando.Parameters.Add(new SqlParameter("Nombre",docente.Nombre ));
                comando.Parameters.Add(new SqlParameter("Apellido", docente.Apellido));
                comando.Parameters.Add(new SqlParameter("Edad", docente.Edad));
                comando.Parameters.Add(new SqlParameter("Sexo", docente.Sexo));
                comando.Parameters.Add(new SqlParameter("Dni", docente.Dni));
                comando.Parameters.Add(new SqlParameter("Direccion", docente.Direccion));
                comando.Parameters.Add(new SqlParameter("Email", docente.Email));

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
              conexion.Close();
                
            }
            

        }
    }
}
