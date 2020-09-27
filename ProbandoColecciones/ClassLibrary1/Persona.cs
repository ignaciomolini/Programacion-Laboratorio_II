using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona
    {
        public Persona(string mensaje)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(Imprime));
            thread.Start(mensaje);
        }

        void Imprime(Object o)
        {
            Console.WriteLine((string)o);
        }
    }
}
