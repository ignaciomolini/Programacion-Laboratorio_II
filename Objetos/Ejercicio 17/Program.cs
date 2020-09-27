using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades17;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
            string dibujo1;
            string dibujo2;

            Console.WriteLine($"El Boligrafo 1 tiene un nivel de tinta de: {boligrafo1.GetTinta()} y es de " +
            $"color: {boligrafo1.GetColor()}");
            Console.WriteLine($"El Boligrafo 2 tiene un nivel de tinta de: {boligrafo2.GetTinta()} y es de " +
            $"color: {boligrafo2.GetColor()}");

            Console.WriteLine();

            if(boligrafo1.Pintar(15,out dibujo1))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Gasto de tinta: " + dibujo1);
            }
            else
            {
                Console.WriteLine("No se puedo pintar!");
            }

            if (boligrafo2.Pintar(10, out dibujo2))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Gasto de tinta: " + dibujo2);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("No se puedo pintar!");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine($"\nEl Boligrafo 1 tiene un nivel de tinta de: {boligrafo1.GetTinta()} y es de " +
            $"color: {boligrafo1.GetColor()}");
            Console.WriteLine($"El Boligrafo 2 tiene un nivel de tinta de: {boligrafo2.GetTinta()} y es de " +
            $"color: {boligrafo2.GetColor()}");

            Console.WriteLine("\nSe recarga la tinta.");
            boligrafo1.Recargar();
            boligrafo2.Recargar();
            Console.WriteLine($"\nEl Boligrafo 1 tiene un nivel de tinta de: {boligrafo1.GetTinta()} y es de " +
            $"color: {boligrafo1.GetColor()}");
            Console.WriteLine($"El Boligrafo 2 tiene un nivel de tinta de: {boligrafo2.GetTinta()} y es de " +
            $"color: {boligrafo2.GetColor()}");

            Console.ReadKey();
        }
    }
}
