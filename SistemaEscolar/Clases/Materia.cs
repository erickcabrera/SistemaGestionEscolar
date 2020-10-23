using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaEscolar.Clases
{
    class Materia: Conexion
    {
        private string nombreMateria;

        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }

        public Materia()
        {

        }
        public Materia(string nombreMateria)
        {
            this.nombreMateria = nombreMateria;
        }
        ~Materia()
        {

        }

        public bool Agregar(string nombreMateria)
        {
            try
            {
                this.nombreMateria = nombreMateria.Trim().ToUpper();

                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_insertar_materia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreMateria", this.nombreMateria);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                this.Desconectar();
                return true;

            }
            catch(Exception ex)
            {
                Console.WriteLine("No se pudo agregar el nuevo registro " + ex.Message);
            }
            return false;
        }
    }
}
