using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar.Clases
{
    class Matricula:Conexion
    {
        public DataTable mostrarAlumnosSinMatricular()
        {
            DataTable tabla = new DataTable();
            try
            {                
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_mostrar_alumnos_noMatriculados";
                comando.CommandType = CommandType.StoredProcedure;               

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

        public void llenarComboGrupos(ComboBox nombreC, int año)
        {
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_mostrar_Grupos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@anioActual", año);
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    nombreC.Items.Add(leer["Grupo"].ToString());
                }

                this.Desconectar();
                leer.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos " + e.Message);
            }
        }

        public void obtenerIdGrupo(Label nombreL, string grado, string seccion)
        {

            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_mostrar_alumnos_curso";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreGrado", grado);
                comando.Parameters.AddWithValue("@nombreSeccion", seccion);
                comando.ExecuteNonQuery();
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    nombreL.Text = leer["Codigo"].ToString();
                }
                this.Desconectar();
                leer.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos " + e.Message);


            }

        }

        public bool Matricular(int idDetalle, int idAlumno)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_matricular";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", idAlumno);
                comando.Parameters.AddWithValue("@idDetalle", idDetalle);
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

        public bool actualizarEstadoMatricula(int idAlumno)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_actualizar_estado_matricula";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", idAlumno);                
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

        public DataTable mostrarMatriculas()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_leer_matriculas";
                comando.CommandType = CommandType.StoredProcedure;

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

        public bool modificarMatricula(int idMatricula, int idDetalle)
        {
            try
            {               
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_modificar_matricula";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idDetalle", idDetalle);               
                comando.Parameters.AddWithValue("@idMatricula", idMatricula);
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

        public bool darDeBaja(int idAlumno)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_dardeBaja";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", idAlumno);                
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

        public bool actualizarEstadoM(int idMatricula)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_actualizar_estado_activo_matricula";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idMatricula", idMatricula);
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
    }
}
