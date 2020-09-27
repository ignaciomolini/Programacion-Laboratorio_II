using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class NumeroRandom
    {
        static Random nroRandom;

        static NumeroRandom()
        {
            nroRandom = new Random();
        }

        public static int GenerarRandom(int min, int max)
        {
            return nroRandom.Next(min, max);
        }
    }
}
