using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class NumeroRandom
    {
        static Random nroRandom;

        /// <summary>
        /// Constructor estatico que instancia 
        /// el atributo nroRandom.
        /// </summary>
        static NumeroRandom()
        {
            nroRandom = new Random();
        }

        /// <summary>
        /// Metodo que genera un numero random entre los numeros pasados por parametro.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Retorna un entero con el numero generado</returns>
        public static int GenerarRandom(int min, int max)
        {
            return nroRandom.Next(min, max);
        }
    }
}
