using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Profesor(string nombres, string apellidos, string fechaNac, string sexo, string telefono, string direccion,  string fotoProfesor, string dui, string nit, string correo, string numEscalafon)
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

        public bool Agregar(string nombres, string apellidos, string fechaNac, string sexo, string telefono, string direccion, string fotoProfesor, string dui, string nit, string correo, string numEscalafon)
        {
            try
            {
                this.nombres = nombres.Trim().ToUpper();
                this.apellidos = nombres.Trim().ToUpper();
                this.fechaNac = nombres.Trim().ToUpper();
                this.sexo = nombres.Trim().ToUpper();
                this.telefono = nombres.Trim().ToUpper();
                this.direccion = nombres.Trim().ToUpper();
                this.foto = nombres.Trim().ToUpper();
                this.dui = nombres.Trim().ToUpper();
                this.nit = nombres.Trim().ToUpper();
                this.correo = nombres.Trim().ToUpper(); 
                this.numEscalafon = nombres.Trim().ToUpper();

                Conexion conexion = new Conexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.Conectar();
                comando.CommandText = "ps_insertar_profesor";
                comando.CommandType = CommandType.StoredProcedure;
                //comando.Parameters.AddWithValue("@nombreMateria", this.nombreMateria);
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


    }
}
