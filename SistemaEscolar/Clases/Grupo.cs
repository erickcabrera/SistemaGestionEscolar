using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Clases
{
    class Grupo
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
        ~Grupo()
        {

        }
    }
}
