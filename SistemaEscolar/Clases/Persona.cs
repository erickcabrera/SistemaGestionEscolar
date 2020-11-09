using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Clases
{
    class Persona
    {
        protected string nombres;
        protected string apellidos;
        protected string fechaNac;
        protected string sexo;
        protected string telefono;
        protected string direccion;
        protected byte[] foto;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public byte[] Foto { get => foto; set => foto = value; }

        public Persona()
        {

        }
        public Persona(string nombres, string apellidos, string fechaNac, string sexo, string telefono, string direccion, byte[] foto)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.sexo = sexo;
            this.telefono = telefono;
            this.direccion = direccion;
            this.foto = foto;
        }
        ~Persona()
        {

        }
    }
}