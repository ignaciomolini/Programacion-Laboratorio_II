using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ProgramEj53
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartuchera1 cartuchera1 = new Cartuchera1();
            Cartuchera2 cartuchera2 = new Cartuchera2();
            bool retorno;

            cartuchera1.Utiles = new Boligrafo(3, ConsoleColor.Green);
            cartuchera1.Utiles = new Lapiz(1);
            cartuchera1.Utiles = new Boligrafo(5, ConsoleColor.Yellow);
            cartuchera1.Utiles = new Lapiz(2);

            cartuchera2.Boligrafos = new Boligrafo(4, ConsoleColor.Green);
            cartuchera2.Boligrafos = new Boligrafo(2, ConsoleColor.Red);
            cartuchera2.Lapices = new Lapiz(3);
            cartuchera2.Lapices = new Lapiz(2);

            do
            {
                retorno = cartuchera1.ProbarElementos();
                Console.WriteLine(retorno);
            }
            while (retorno); //Prueba los utiles hasta que un boligrafo no pueda escribir por falta de tinta y el metodo retorne false

            Console.WriteLine();

            do
            {
                retorno = cartuchera2.ProbarElementos();
                Console.WriteLine(retorno); 
            }
            while (retorno); //Lo mismo que anterior

            Console.ReadKey();
        }
    }
}
