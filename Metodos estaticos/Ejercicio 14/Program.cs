using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Ingrese un lado del cuadrado: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine($"El area del cuadrado es {CalculoDeArea.CalcularCuadrado(num1)}");

            Console.Write("\nIngrese la base del triangulo: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Ingrese la altura del triangulo: ");
            double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine($"El area del triangulo es {CalculoDeArea.CalcularTriangulo(num1, num2)}");

            Console.Write("\nIngrese el radio del circulo: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine($"El area del circulo es {CalculoDeArea.CalcularCirculo(num1)}");

            Console.ReadKey();
        }
    }
}
