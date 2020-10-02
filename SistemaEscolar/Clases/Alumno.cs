using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string nombrePadre, string nombreMadre, string nombreEncargado, string fotoAlumno)
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
    }
}
