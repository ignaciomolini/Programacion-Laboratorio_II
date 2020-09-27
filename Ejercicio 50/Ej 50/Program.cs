using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ej_50
{
    class Program
    {
        static void Main(string[] args)
        {
            GuardarTexto<object, object> guardarTexto = new GuardarTexto<object, object>();
            Serializar<object, object> serializar = new Serializar<object, object>();

            Console.WriteLine(guardarTexto.Leer());
            Console.WriteLine(serializar.Leer());

            Console.ReadKey();
        }
    }
}
