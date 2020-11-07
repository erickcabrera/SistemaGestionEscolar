using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SistemaEscolar.Clases
{
    class Grupo : Conexion
    {
        private Grado grado;
        private Seccion seccion;
        private string turno;
        private int id_Detale;

        internal Grado Grado { get => grado; set => grado = value; }
        internal Seccion Seccion { get => seccion; set => seccion = value; }
        public string Turno { get => turno; set => turno = value; }
        public int Id_Detale { get => id_Detale; set => id_Detale = value; }

        public Grupo()
        {

        }
        public Grupo(Grado grado, Seccion seccion, string turno)
        {
            this.grado = grado;
            this.seccion = seccion;
            this.turno = turno;
        }

        public void llenarComboGrupos(ComboBox grupo, string idProfesor)
        {
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_mostrar_cursos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_Profesor", idProfesor);
                comando.ExecuteNonQuery();
                leer = comando.ExecuteReader();
                comando.Parameters.Clear();

                while (leer.Read())
                {
                    grupo.Items.Add(leer["Curso"].ToString());
                }

                this.Desconectar();
                leer.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos " + e.Message);
                

            }
        }

        public void llenardgv(Label nombreL, string grado, string seccion)
        {
            
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_mostrar_alumnos_curso";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreGrado", grado);
                comando.Parameters.AddWithValue("@nombreSeccion",seccion);
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

        public DataTable mostrarAlumnos(int idDetalle)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_mostrar_alumnos_nombres";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@grupo", idDetalle);
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
        ~Grupo()
        {

        }
    }
}
