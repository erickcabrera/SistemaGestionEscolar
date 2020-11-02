using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Clases
{
    class DetalleGrupo:Conexion
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
                Console.WriteLine("Error al mostrar datos " + e);
            }
            return tabla;
        }
    }
}
