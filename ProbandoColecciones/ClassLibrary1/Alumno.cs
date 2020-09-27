using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Alumno
    {
        public static int NumerosRandom(int min, int max)
        {
            Random nroRandom = new Random();

            return nroRandom.Next();
        }
    }
}
