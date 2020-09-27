using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerosAIngresar = 5;
            int auxNumero;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            float promedio = 0;
            string lecturaNumeros;

            for(int i=0; i < numerosAIngresar; i++)
            {
                Console.Write("Ingrese un numero: ");
                lecturaNumeros = Console.ReadLine();

                if(int.TryParse(lecturaNumeros, out auxNumero))
                {
                    if(auxNumero > maximo)
                    {
                        maximo = auxNumero;
                    }
                    if(auxNumero < minimo)
                    {
                        minimo = auxNumero;
                    }
                    promedio = (promedio + auxNumero);
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido!");
                    i--;
                }
            }

            promedio = (promedio / numerosAIngresar);

            Console.WriteLine($"El valor maximo fue {maximo}, el minimo {minimo} y el promedio {promedio}");
            Console.ReadKey();
        }
    }
}
