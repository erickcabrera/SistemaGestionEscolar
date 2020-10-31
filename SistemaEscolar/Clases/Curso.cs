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
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos de las materias " + e);
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
                Console.WriteLine("Error al mostrar datos " + e);
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
                Console.WriteLine("Error al mostrar datos " + e);
            }
        }

    }
}
