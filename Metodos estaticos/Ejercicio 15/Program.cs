using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double resultado;
            string operador;

            Console.Write("Ingrese el primer numero: ");
            double.TryParse(Console.ReadLine(), out num1);

            Console.Write("Ingrese el segundo numero: ");
            double.TryParse(Console.ReadLine(), out num2);

            Console.Write("Ingrese el operador: ");
            operador = Console.ReadLine();

            resultado = Calculadora.Calcular(num1, num2, operador);

            if(operador == "+" || operador == "-" || operador == "*" || operador == "/" && (operador != "/" || num2 != 0))
            {
                Console.WriteLine($"\nEl resultador de la operacion es: {resultado}");
            }
            
            Console.ReadKey();
        }
    }
}
