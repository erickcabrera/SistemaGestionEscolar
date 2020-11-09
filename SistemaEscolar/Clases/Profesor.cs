using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar.Clases
{
    class Profesor : Persona
    {
        private string dui;
        private string nit;
        private string correo;
        private string numEscalafon;

        public string Dui { get => dui; set => dui = value; }
        public string Nit { get => nit; set => nit = value; }
        public string Correo { get => correo; set => correo = value; }
        public string NumEscalafon { get => numEscalafon; set => numEscalafon = value; }

        public Profesor()
        {

        }
        public Profesor(string nombres, string apellidos, string fechaNac, string sexo, string telefono, string direccion,  byte[] fotoProfesor, string dui, string nit, string correo, string numEscalafon)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.sexo = sexo;
            this.telefono = telefono;
            this.direccion = direccion;
            this.foto = fotoProfesor;
            this.dui = dui;
            this.nit = nit;
            this.correo = correo;
            this.numEscalafon = numEscalafon;
        }
        ~Profesor()
        {

        }

        public bool Agregar(string nombres, string apellidos, string fechaNac, string sexo, string telefono, string direccion, byte[] fotoProfesor, string dui, string nit, string correo, string numEscalafon)
        {
            try
            {
                this.nombres = nombres.Trim().ToUpper();
                this.apellidos = apellidos.Trim().ToUpper();
                this.fechaNac = fechaNac;
                this.sexo = sexo;
                this.telefono = telefono;
                this.direccion = direccion.Trim().ToUpper();
                this.foto = fotoProfesor;
                this.dui = dui;
                this.nit = nit;
                this.correo = correo; 
                this.numEscalafon = numEscalafon;

                Conexion conexion = new Conexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_insertar_profesor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@dui", this.dui);
                comando.Parameters.AddWithValue("@nit", this.nit);
                comando.Parameters.AddWithValue("@nombreProfesor", this.nombres);
                comando.Parameters.AddWithValue("@apellidoProfesor", this.apellidos);
                comando.Parameters.AddWithValue("@direccionProfesor", this.direccion);
                comando.Parameters.AddWithValue("@telefonoProfesor", this.telefono);
                comando.Parameters.AddWithValue("@correoProfesor", this.correo);
                comando.Parameters.Add(new SqlParameter("@fechaNacProfesor", SqlDbType.Date));
                comando.Parameters["@fechaNacProfesor"].Value = this.fechaNac;
                comando.Parameters.Add(new SqlParameter("@fotoPerfilProfesor", SqlDbType.Image));
                comando.Parameters["@fotoPerfilProfesor"].Value = this.foto;
                comando.Parameters.AddWithValue("@numeroEscalafon", this.numEscalafon);
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
                comando.CommandText = "ps_mostrar_profesor";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);

                conexion.Desconectar();
                leer.Close();
                return tabla;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al mostrar datos " + e.Message);
            }
            return tabla;
        }

        public void ExtraerFoto(string idProfesor, PictureBox pbFotoProfesor)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_extraer_foto_profesor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProfesor", idProfesor);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Byte[] data = new Byte[0];

                    data = (Byte[])(leer["fotoPerfilProfesor"]);

                    MemoryStream mem = new MemoryStream(data);

                    Bitmap bitmap = new Bitmap(mem);

                    pbFotoProfesor.Image = bitmap;
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

        public bool Eliminar(int idProfesor)
        {
            try
            {
                Conexion conexion = new Conexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_eliminar_profesor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProfesor", idProfesor);
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
                comando.CommandText = "ps_buscar_profesores";
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

        public bool Modificar(int idProfesor,string nombres, string apellidos, string fechaNac, string sexo, string telefono, string direccion, byte[] fotoProfesor, string dui, string nit, string correo, string numEscalafon)
        {
            try
            {
                this.nombres = nombres.Trim().ToUpper();
                this.apellidos = apellidos.Trim().ToUpper();
                this.fechaNac = fechaNac;
                this.sexo = sexo;
                this.telefono = telefono;
                this.direccion = direccion.Trim().ToUpper();
                this.foto = fotoProfesor;
                this.dui = dui;
                this.nit = nit;
                this.correo = correo;
                this.numEscalafon = numEscalafon;

                Conexion conexion = new Conexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_modificar_profesor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProfesor", idProfesor);
                comando.Parameters.AddWithValue("@dui", this.dui);
                comando.Parameters.AddWithValue("@nit", this.nit);
                comando.Parameters.AddWithValue("@nombreProfesor", this.nombres);
                comando.Parameters.AddWithValue("@apellidoProfesor", this.apellidos);
                comando.Parameters.AddWithValue("@direccionProfesor", this.direccion);
                comando.Parameters.AddWithValue("@telefonoProfesor", this.telefono);
                comando.Parameters.AddWithValue("@correoProfesor", this.correo);
                comando.Parameters.Add(new SqlParameter("@fechaNacProfesor", SqlDbType.Date));
                comando.Parameters["@fechaNacProfesor"].Value = this.fechaNac;
                comando.Parameters.Add(new SqlParameter("@fotoPerfilProfesor", SqlDbType.Image));
                comando.Parameters["@fotoPerfilProfesor"].Value = this.foto;
                comando.Parameters.AddWithValue("@numeroEscalafon", this.numEscalafon);
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

        public void llenarComboMaestros(ComboBox nombreC)
        {
            try
            {
                Conexion conexion = new Conexion();

                SqlDataReader leer = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_leer_profesores";
                comando.CommandType = CommandType.StoredProcedure;                
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    nombreC.Items.Add(leer["Profesor"].ToString());
                }

                conexion.Desconectar();
                leer.Close();
                
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al buscar datos " + e.Message);
            }            
        }
    }
}
