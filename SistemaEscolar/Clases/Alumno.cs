using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaEscolar.Clases
{
    class Alumno : Persona
    {
        private string numPartida;
        private string nie;
        private string nombrePadre;
        private string nombreMadre;
        private string nombreEncargado;

        public string NumPartida { get => numPartida; set => numPartida = value; }
        public string Nie { get => nie; set => nie = value; }
        public string NombrePadre { get => nombrePadre; set => nombrePadre = value; }
        public string NombreMadre { get => nombreMadre; set => nombreMadre = value; }
        public string NombreEncargado { get => nombreEncargado; set => nombreEncargado = value; }

        public Alumno()
        {

        }
        public Alumno(string nombres, string apellidos, string fechaNac, string sexo, string telefono, string direccion, string numPartida, string nie,
            string nombrePadre, string nombreMadre, string nombreEncargado, byte[] fotoAlumno)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.sexo = sexo;
            this.telefono = telefono;
            this.direccion = direccion;
            this.numPartida = numPartida;
            this.nie = nie;
            this.nombrePadre = nombrePadre;
            this.NombreEncargado = nombreEncargado;
            this.foto = fotoAlumno;
        }
        ~Alumno()
        {

        }


        public bool Agregar(string nombres, string apellidos, string fechaNac, string sexo, string telefono, string direccion, string numPartida, string nie,
            string nombrePadre, string nombreMadre, string nombreEncargado, byte[] fotoAlumno)
        {
            try
            {
                this.nombres = nombres.Trim().ToUpper();
                this.apellidos = apellidos.Trim().ToUpper();
                this.fechaNac = fechaNac;
                this.sexo = sexo;
                this.telefono = telefono;
                this.direccion = direccion.Trim().ToUpper();
                this.foto = fotoAlumno;
                this.NombreMadre = nombreMadre.Trim().ToUpper();
                this.NombrePadre = NombrePadre.Trim().ToUpper();
                this.nombreEncargado = nombreEncargado.Trim().ToUpper();
                this.nie = nie;
                this.numPartida = numPartida;

                Conexion conexion = new Conexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_insertar_alumno";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreAlumno", this.Nombres);
                comando.Parameters.AddWithValue("@apellidoAlumno", this.Apellidos);
                comando.Parameters.AddWithValue("@numPartida", this.NumPartida);
                comando.Parameters.AddWithValue("@NIE", this.Nie);
                comando.Parameters.AddWithValue("@direccionAlumno", this.direccion);
                comando.Parameters.AddWithValue("@telefonoAlumno", this.telefono);
                comando.Parameters.Add(new SqlParameter("@fechaNacAlumno", SqlDbType.Date));
                comando.Parameters["@fechaNacAlumno"].Value = this.fechaNac;
                comando.Parameters.Add(new SqlParameter("@fotoAlumno", SqlDbType.Image));
                comando.Parameters["@fotoAlumno"].Value = this.foto;
                comando.Parameters.AddWithValue("@NombrePapaAlumno", this.NombrePadre);
                comando.Parameters.AddWithValue("@NombreMamaAlumno", this.NombreMadre);
                comando.Parameters.AddWithValue("@NombreEncargadoAlumno", this.NombreEncargado);
                comando.Parameters.AddWithValue("@sexo", this.sexo);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.Desconectar();
                return true;
            }
            catch (Exception ex)
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
                Conexion conexion = new Conexion();
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_mostrar_alumno";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);

                conexion.Desconectar();
                leer.Close();
                return tabla;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al inicar sesión " + e.Message);
            }
            return tabla;
        }

        public bool Eliminar(int idAlumno)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_eliminar_Alumno";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", idAlumno);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.Desconectar();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo eliminar el registro " + e.Message);
            }
            return false;
        }

        public DataTable Buscar(string filtro)
        {
            DataTable tabla = new DataTable();
            try
            {
                Conexion conexion = new Conexion();

                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_buscar_alumno";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@filtro", filtro);
                leer = comando.ExecuteReader();
                tabla.Load(leer);

                conexion.Desconectar();
                leer.Close();
                return tabla;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al buscar datos " + e.Message);
            }
            return tabla;
        }

        public void ExtraerFoto(string idAlumno, PictureBox pbFotoAlumno)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_extraer_foto_alumno";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", idAlumno);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Byte[] data = new Byte[0];

                    data = (Byte[])(leer["fotoAlumno"]);

                    MemoryStream mem = new MemoryStream(data);

                    Bitmap bitmap = new Bitmap(mem);

                    pbFotoAlumno.Image = bitmap;
                }
                if (leer != null)
                {
                    Console.WriteLine("Datos encontrados");
                }
                conexion.Desconectar();
                leer.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al extraer foto " + e.Message);
            }
        }

        public bool Modificar(int idAlumno, string nombres, string apellidos, string fechaNac, string sexo, string telefono, string direccion, string numPartida, string nie,
            string nombrePadre, string nombreMadre, string nombreEncargado, byte[] fotoAlumno)
        {
            try
            {
                this.nombres = nombres.Trim().ToUpper();
                this.apellidos = apellidos.Trim().ToUpper();
                this.fechaNac = fechaNac;
                this.sexo = sexo;
                this.telefono = telefono;
                this.direccion = direccion.Trim().ToUpper();
                this.foto = fotoAlumno;
                this.NombreMadre = nombreMadre.Trim().ToUpper();
                this.NombrePadre = NombrePadre.Trim().ToUpper();
                this.nombreEncargado = nombreEncargado.Trim().ToUpper();
                this.nie = nie;
                this.numPartida = numPartida;

                Conexion conexion = new Conexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_modificar_alumno";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", idAlumno);
                comando.Parameters.AddWithValue("@nombreAlumno", this.Nombres);
                comando.Parameters.AddWithValue("@apellidoAlumno", this.Apellidos);
                comando.Parameters.AddWithValue("@numPartida", this.NumPartida);
                comando.Parameters.AddWithValue("@NIE", this.Nie);
                comando.Parameters.AddWithValue("@direccionAlumno", this.direccion);
                comando.Parameters.AddWithValue("@telefonoAlumno", this.telefono);
                comando.Parameters.Add(new SqlParameter("@fechaNacAlumno", SqlDbType.Date));
                comando.Parameters["@fechaNacAlumno"].Value = this.fechaNac;
                comando.Parameters.Add(new SqlParameter("@fotoAlumno", SqlDbType.Image));
                comando.Parameters["@fotoAlumno"].Value = this.foto;
                comando.Parameters.AddWithValue("@NombrePapaAlumno", this.NombrePadre);
                comando.Parameters.AddWithValue("@NombreMamaAlumno", this.NombreMadre);
                comando.Parameters.AddWithValue("@NombreEncargadoAlumno", this.NombreEncargado);
                comando.Parameters.AddWithValue("@sexo", this.sexo);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.Desconectar();
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
