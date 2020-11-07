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
    class Seccion: Conexion
    {
        private string nombreSeccion;
        public string NombreSeccion { get => nombreSeccion; set => nombreSeccion = value; }

        public Seccion()
        {

        }
        public Seccion(string nombreSeccion)
        {
            this.nombreSeccion = nombreSeccion;
        }
        ~Seccion()
        {

        }
        public bool Agregar(string nombreSeccion)
        {
            try
            {
                this.nombreSeccion = nombreSeccion.Trim().ToUpper();

                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_insertar_seccion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreSeccion", this.nombreSeccion);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                this.Desconectar();
                return true;
            }
            catch (Exception Ex)
            {
                Console.WriteLine("No se pudo agregar la sección" + Ex.Message);
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
                comando.CommandText = "ps_mostrar_secciones";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);

                this.Desconectar();
                leer.Close();
                return tabla;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos de las secciones " + e.Message);
            }
            return tabla;
        }

        public bool Modificar(string nombreSeccion, int idSeccion)
        {
            try
            {
                this.nombreSeccion = nombreSeccion.Trim().ToUpper();

                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_modificar_seccion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idSeccion", idSeccion);
                comando.Parameters.AddWithValue("@nombreSeccion", this.nombreSeccion);
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

        public bool Eliminar(int idSeccion)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_eliminar_seccion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idSeccion", idSeccion);
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

        public DataTable Buscar(string nombreSeccion)
        {
            DataTable tabla = new DataTable();
            try
            {
                this.nombreSeccion = nombreSeccion.Trim().ToUpper();
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_buscar_secciones";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreSeccion", this.nombreSeccion);

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
