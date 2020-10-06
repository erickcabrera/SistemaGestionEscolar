using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Clases
{
    class Seccion
    {
        private string nombreSeccion;
        public string NombreSeccion { get => nombreSeccion; set => nombreSeccion = value; }

        public Seccion()
        {

        }
        public Seccion(string nombreSeccion)
        {
            this.nombreSeccion = nombreSeccion;
        }
        ~Seccion()
        {

        }
        
    }
}
