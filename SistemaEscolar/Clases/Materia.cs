using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

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

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_mostrar_materias";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);

                this.Desconectar();
                leer.Close();
                return tabla;
            }
            catch(SqlException e)
            {
                Console.WriteLine("Error al mostrar datos de las materias "+e.Message);
            }
            return tabla;
        }

        public bool Modificar(string nombreMateria, int idMateria)
        {
            try
            {
                this.nombreMateria = nombreMateria.Trim().ToUpper();

                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_modificar_materia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idMateria", idMateria);
                comando.Parameters.AddWithValue("@nombreMateria", this.nombreMateria);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                this.Desconectar();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo modificar el registro " + e.Message);
            }
            return false;
        }

        public bool Eliminar(int idMateria)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_eliminar_materia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idMateria", idMateria);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                this.Desconectar();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo eliminar el registro " + e.Message);
            }
            return false;
        }


        public DataTable Buscar(string nombreMateria)
        {
            DataTable tabla = new DataTable();
            try
            {
                this.nombreMateria = nombreMateria.Trim().ToUpper();
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_buscar_materia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreMateria", this.nombreMateria);

                leer = comando.ExecuteReader();
                tabla.Load(leer);

                this.Desconectar();
                leer.Close();
                return tabla;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al buscar datos " + e.Message);
            }
            return tabla;
        }

        public void llenarComboMaterias(ComboBox nombreC)
        {
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_mostrar_materias";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    nombreC.Items.Add(leer["Materia"].ToString());
                }

                this.Desconectar();
                leer.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos " + e.Message);
            }
        }
    }
}
