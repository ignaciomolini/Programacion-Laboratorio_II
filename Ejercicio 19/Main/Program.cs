using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma = new Sumador(5);
            Sumador suma2 = new Sumador(5);

            Console.WriteLine($"suma de fun+ciona: {suma.Sumar("Fun", "ciona")}");
            Console.WriteLine($"suma de 2+4: {suma2.Sumar(2, 4)}");

            Console.WriteLine($"\nLa suma de las sumas de ambos objetos es: {suma + suma2}"); 
            Console.WriteLine($"Los objetos tienen la misma cantidad de sumas: {suma | suma2}");

            Console.WriteLine($"Cantida de sumas de suma2: {(int)suma2}"); //Si lo casteo a int me da la cantidad de sumas del objeto *conv explicita*

            Console.ReadKey();
        }
    }
}
