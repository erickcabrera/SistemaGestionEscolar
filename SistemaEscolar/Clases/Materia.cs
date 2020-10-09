using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Clases
{
    class Materia
    {
        private string nombreMateria;

        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }

        public Materia()
        {

        }
        public Materia(string nombreMateria)
        {
            this.nombreMateria = nombreMateria;
        }
        ~Materia()
        {

        }
    }
}
