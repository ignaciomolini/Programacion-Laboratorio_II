using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool esValido = false;

            if(c == 's' || c == 'S')
            {
                esValido = true;
            }

            return esValido;
        }
    }
}
