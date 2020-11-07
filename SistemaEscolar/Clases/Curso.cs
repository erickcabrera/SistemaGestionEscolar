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
    class Curso: Conexion
    {
        private int id_Curso;
        private int id_Detalle_Grado;
        private int id_Materia;
        private int id_Profesor;

        public int Id_Curso { get => id_Curso; set => id_Curso = value; }
        public int Id_Detalle_Grado { get => id_Detalle_Grado; set => id_Detalle_Grado = value; }
        public int Id_Materia { get => id_Materia; set => id_Materia = value; }
        public int Id_Profesor { get => id_Profesor; set => id_Profesor = value; }

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_leer_detalle_Grado";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);

                this.Desconectar();
                leer.Close();
                return tabla;
            }
            catch (SqlException Ex)
            {
                Console.WriteLine("Error al mostrar datos de las materias " + Ex.Message);
            }
            return tabla;
        }

        public void obtenerCodigoMateria(Label nombreL, string materia)
        {
            try
            {
                string nombreM = materia;
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_obtener_idMateria";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreMateria", nombreM);
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


        public void obtenerCodigoProfesor(Label nombreL, string nombre, string apellido)
        {
            try
            {
               /* string Nombre = nombre;
                string Apellido = apellido;*/
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_obtener_idProfesor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreProfesor", nombre);
                comando.Parameters.AddWithValue("@ApellidoProfesor", apellido);
                leer = comando.ExecuteReader();                
                while (leer.Read())
                {                   
                    nombreL.Text = leer["CodigoP"].ToString();
                }
                this.Desconectar();
                leer.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos " + e.Message);
            }
        }

        public Boolean agregarCurso(int idDetalle, int idMateria,int idProfesor)
        {           
            try
            {
                this.id_Detalle_Grado = idDetalle;
                this.id_Materia = idMateria;
                this.id_Profesor = idProfesor;

                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_insertar_curso";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idDetalle", this.id_Detalle_Grado);
                comando.Parameters.AddWithValue("@idMateria", this.id_Materia);
                comando.Parameters.AddWithValue("@idProfesor", this.id_Profesor);

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

        public DataTable MostrarCursos()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_leer_cursos";
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


        public bool EliminarCurso(int idCurso)
        {
            try
            {
                this.id_Curso = idCurso;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_eliminar_curso";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idCurso", idCurso);
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

        public bool ModificarCurso(int idMateria, int idProfesor, int idCurso)
        {
            try
            {
                this.Id_Curso = idCurso;
                this.Id_Profesor = idProfesor;
                this.Id_Materia = idMateria; 

                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_modificar_curso";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idCurso", this.id_Curso);
                comando.Parameters.AddWithValue("@idMateria", this.id_Materia);
                comando.Parameters.AddWithValue("@idProfesor", this.id_Profesor);
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

        public DataTable mostrarCursos_Profesor(int idProfesor, int anio)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_mostrar_cursos_profesor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_Profesor", idProfesor);
                comando.Parameters.AddWithValue("@anio", anio);
                comando.ExecuteNonQuery();
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();

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
    }
}
