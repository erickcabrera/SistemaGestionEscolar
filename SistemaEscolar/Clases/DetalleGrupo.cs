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
    class DetalleGrupo : Conexion
    {
        private int id_Detalle_Grupo;
        private int id_Grado;
        private int id_Seccion;
        private int id_Profesor_Encargado;
        private int anio;

        public int Id_Detalle_Grupo { get => id_Detalle_Grupo; set => id_Detalle_Grupo = value; }
        public int Id_Grado { get => id_Grado; set => id_Grado = value; }
        public int Id_Seccion { get => id_Seccion; set => id_Seccion = value; }
        public int Id_Profesor_Encargado { get => id_Profesor_Encargado; set => id_Profesor_Encargado = value; }
        public int Anio { get => anio; set => anio = value; }

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_leer_detalle_Grado_Seccion";
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

        public void llenarComboGrado(ComboBox nombreC)
        {
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_leer_Grados";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    nombreC.Items.Add(leer["Grado"].ToString());
                }

                this.Desconectar();
                leer.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos " + e.Message);
            }
        }

        public void llenarComboSeccion(ComboBox nombreC)
        {
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_leer_Secciones";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    nombreC.Items.Add(leer["Seccion"].ToString());
                }

                this.Desconectar();
                leer.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos " + e.Message);
            }
        }

        public void llenarComboMaestros(ComboBox nombreC)
        {
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_leer_nombre_Profesores";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    nombreC.Items.Add(leer["Profesor"].ToString());
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

        public void obtenerCodigoSeccion(Label nombreL, string seccion)
        {
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_obtener_idSeccion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@seccion", seccion);
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

        public void obtenerCodigoGrado(Label nombreL, string grado)
        {
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_obtener_idGrado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@grado", grado);
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    nombreL.Text = leer["Grado"].ToString();
                }
                this.Desconectar();
                leer.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos " + e.Message);
            }
        }

        public bool AgregarGrupo(int idGrado, int idSeccion, int idProfesor, int año)
        {
            try
            {

                this.id_Grado = idGrado;
                this.id_Profesor_Encargado = idProfesor;
                this.id_Seccion = idSeccion;
                this.anio = año;

                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_insertar_detalle_grado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idGrado", this.id_Grado);
                comando.Parameters.AddWithValue("@idSeccion", this.id_Seccion);
                comando.Parameters.AddWithValue("@idProfesor", this.id_Profesor_Encargado);
                comando.Parameters.AddWithValue("@anio", this.anio);
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

        public bool EliminarGrupo(int idGrupo)
        {
            try
            {

                this.id_Detalle_Grupo = idGrupo;

                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_eliminar_grupo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idGrupo", this.id_Detalle_Grupo);
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

        public bool ModificarCurso(int idGrupo, int idGrado, int idSeccion, int idProfesor, int año)
        {
            try
            {
                this.id_Detalle_Grupo = idGrupo;
                this.id_Grado = idGrado;
                this.id_Seccion = idSeccion;
                this.id_Profesor_Encargado = idProfesor;
                this.anio = año;

                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_modificar_grupo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idGrupo", this.id_Detalle_Grupo);
                comando.Parameters.AddWithValue("@idGrado", this.id_Grado);
                comando.Parameters.AddWithValue("@idSeccion", this.id_Seccion);
                comando.Parameters.AddWithValue("@idProfesor", this.id_Profesor_Encargado);
                comando.Parameters.AddWithValue("@anio", this.anio);
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
    }
}
