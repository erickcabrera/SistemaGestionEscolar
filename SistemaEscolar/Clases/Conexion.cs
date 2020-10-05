using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaEscolar.Clases
{
    class Conexion
    {
        private static SqlConnection cone = null;
        private static String server = "localhost";       
        private static String usuario = "sa";
        private static String clave = "123456";
        private static String db = "BD_escuela";
        private static String cadena = "server=" + server + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db+ "; Integrated security = true;";
        //private static String cadena = "server=" + server +  ";database=" + db + "; Integrated security = true;";

        public SqlConnection Conectar()
        {
            try
            {
                cone = new SqlConnection(cadena);
                cone.Open();

                if (cone != null)
                {
                    Console.WriteLine("Conexion Establecida");
                }
                else
                {
                    Console.WriteLine("Error al conectar");
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error al conectar " + Ex.Message);
            }
            return cone;
        }

        public void Desconectar()
        {
            try
            {
                cone.Close();
                Console.WriteLine("Conexion Finalizada");
            }
            catch (SqlException Ex)
            {
                Console.WriteLine("Error al desconectar " + Ex.Message);
            }
        }
    }
}
