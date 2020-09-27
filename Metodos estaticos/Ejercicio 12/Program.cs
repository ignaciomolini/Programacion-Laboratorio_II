using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;
            char respuesta;
            bool continuar;

            do
            {
                Console.Write("Ingrese el numero a sumar: ");
                int.TryParse(Console.ReadLine(), out numero);
                acumulador += numero;

                Console.Write("Desea continuar(S/N): ");
                char.TryParse(Console.ReadLine(), out respuesta);
                continuar = ValidarRespuesta.ValidaS_N(respuesta);

            } while (continuar);

            Console.WriteLine($"\nEl resultado de la suma es: {acumulador}");

            Console.ReadKey();
        }
    }
}
