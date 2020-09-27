using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Queue<int> colaPositivos = new Queue<int>();
            Queue<int> colaNegativos = new Queue<int>();
            Stack<int> pilaPositivos = new Stack<int>();
            Stack<int> pilaNegativos = new Stack<int>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                lista.Add(random.Next(-50, 50));
            }

            Console.Write("Lista como fue cargada: ");
            foreach (int i in lista)
            {
                Console.Write($"{i} ");
            }

            Console.Write("\nLista ordenada de forma decreciente y solo positivos: ");
            lista.Sort();
            lista.Reverse();
            foreach(int i in lista)
            {
                if(i > 0)
                {
                    Console.Write($"{i} ");
                    colaPositivos.Enqueue(i);
                }
                else if(i < 0)
                {
                    pilaNegativos.Push(i);
                }
            }

            Console.Write("\nLista ordenada de forma creciente y solo negativos: ");
            lista.Reverse();
            foreach(int i in lista)
            {
                if(i < 0)
                {
                    Console.Write($"{i} ");
                    colaNegativos.Enqueue(i);
                }
                else if(i > 0)
                {
                    pilaPositivos.Push(i);
                }
            }

            Console.Write("\n\nPila de solo positivos: ");
            foreach(int i in pilaPositivos)
            {
                Console.Write($"{i} ");
            }

            Console.Write("\nPila de solo negativos: ");
            foreach(int i in pilaNegativos)
            {
                Console.Write($"{i} ");
            }

            Console.Write("\n\nCola de solo positivos: ");
            foreach(int i in colaPositivos)
            {
                Console.Write($"{i} ");
            }

            Console.Write("\nCola de solo negativos: ");
            foreach(int i in colaNegativos)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}
