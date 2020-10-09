using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Clases
{
    class Grado
    {
        private string nombreGrado;
        public string NombreGrado { get => nombreGrado; set => nombreGrado = value; }

        public Grado()
        {

        }
        public Grado(string nombreGrado)
        {
            this.nombreGrado = nombreGrado;
        }
        ~Grado()
        {

        }
    }
}
