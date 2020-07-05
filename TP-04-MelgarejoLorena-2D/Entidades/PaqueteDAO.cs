using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Threading;
//using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Entidades
{
    public static class PaqueteDAO
    {
        #region ATRIBUTOS

        private static SqlCommand comando;

        private static SqlConnection conexion;

        #endregion

        #region METODOS

         static PaqueteDAO()
        {

            //conexion = new SqlConnection("Data Source = DESKTOP - 57AHTKO\\SQLEXPRESS; Initial Catalog = correo-sp-2017; Integrated Security = True");
            conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            comando = new SqlCommand();
            comando.Connection = conexion;
           


        }


        public static bool Insertar(Paquete p)
        {
            string cmd = String.Format("INSERT INTO Paquetes([direccionEntrega],[trackingID],[alumno]) values('{0}','{1}','Lorena Melgarejo')", p.DireccionEntrega, p.TrackingID);
            try
            {
                comando.CommandText = cmd;
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                comando.Connection.Close();
            }

        }
        #endregion
    }
}
