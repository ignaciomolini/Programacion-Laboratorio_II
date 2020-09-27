using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultadoDecimal;
            string resultadoBinario;

            Console.Write("Ingrese un numero binario: ");
            resultadoDecimal = Conversor.BinarioDecimal(Console.ReadLine());

            if(resultadoDecimal != -1)
            {
                Console.WriteLine($"El numero en decimal es: {resultadoDecimal}");
            }
            else
            {
                Console.WriteLine("El numero ingresado no es binario!");
            }

            Console.Write("\nIngrese un numero decimal: ");
            resultadoBinario = Conversor.DecimalBinario(int.Parse(Console.ReadLine()));

            if(resultadoBinario != "-1")
            {
                Console.WriteLine($"El numero en binario es: {resultadoBinario}");
            }
            else
            {
                Console.WriteLine("El numero a ingresar no debe ser negativo!");
            }

            int a;

            int.TryParse(Console.ReadLine(), out a);

            Console.WriteLine(a);
            
            Console.ReadKey();
        }
    }
}
