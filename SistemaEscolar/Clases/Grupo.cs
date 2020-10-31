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

        internal Grado Grado { get => grado; set => grado = value; }
        internal Seccion Seccion { get => seccion; set => seccion = value; }
        public string Turno { get => turno; set => turno = value; }

        public Grupo()
        {

        }
        public Grupo(Grado grado, Seccion seccion, string turno)
        {
            this.grado = grado;
            this.seccion = seccion;
            this.turno = turno;
        }

        public void llenarComboGrupos(ComboBox grupo, int idprofesor)
        {
            try
            {
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = this.Conectar();
                comando.CommandText = "ps_mostrar_grupos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_Profesor", idprofesor);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    grupo.Items.Add(leer["Grupo"].ToString());
                }

                this.Desconectar();
                leer.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos " + e);
            }
        }
        ~Grupo()
        {

        }
    }
}
