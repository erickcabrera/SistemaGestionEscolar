using System;
using System.Collections.Generic;
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
        public Profesor(string nombres, string apellidos, string fechaNac, string sexo, string telefono, string direccion,  string fotoProfesor, string dui, string nit, string correo, string numEscalafon )
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

        
    }
}
