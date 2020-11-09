using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace SistemaEscolar.Clases
{
    class Grado : Conexion
    {
        private string nombreGrado;
        public string NombreGrado { get => nombreGrado; set => nombreGrado = value; }

        public Grado()
        {

        }
        public Grado(string nombreGrado)
        {
            this.nombreGrado = nombreGrado;
        }
        ~Grado()
        {

        }
        
        public bool Agregar(string nombreGrado)
        {
            try
            {
                this.nombreGrado = nombreGrado.Trim().ToUpper();

                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_insertar_grado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreGrado", this.nombreGrado);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                this.Desconectar();
                return true;
            }
            catch (Exception Ex)
            {
                Console.WriteLine("No se pudo agregar el nuevo registro " + Ex.Message);
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
                comando.CommandText = "ps_mostrar_grados";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);

                this.Desconectar();
                leer.Close();
                return tabla;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos " + e.Message);
            }
            return tabla;
        }

        public bool Modificar(string nombreGrado, int idGrado)
        {
            try
            {
                this.nombreGrado = nombreGrado.Trim().ToUpper();

                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_modificar_grado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idGrado", idGrado);
                comando.Parameters.AddWithValue("@nombreGrado", this.nombreGrado);
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

        public bool Eliminar(int idGrado)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_eliminar_grado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idGrado", idGrado);
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

        public DataTable Buscar(string nombreGrado)
        {
            DataTable tabla = new DataTable();
            try
            {
                this.nombreGrado = nombreGrado.Trim().ToUpper();
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_buscar_grados";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreGrado", this.nombreGrado);

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

        public DataTable Buscar_curso(string nombreGrado, int idProfesor)
        {
            DataTable tabla = new DataTable();
            try
            {
                this.nombreGrado = nombreGrado.Trim().ToUpper();
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_buscar_grados_curso";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreGrado", this.nombreGrado);
                comando.Parameters.AddWithValue("@idprofesor", idProfesor);
              
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
    }
}
