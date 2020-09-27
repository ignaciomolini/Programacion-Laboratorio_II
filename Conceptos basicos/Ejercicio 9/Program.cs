using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            int largo = 0;

            Console.Write("Ingrese la altura de la piramide: ");

            if(int.TryParse(Console.ReadLine(), out altura))
            {
                for (int i = 0; i < altura; i++)
                {
                    for(int j = 0; j <= largo; j++)
                    {
                        if(j == largo)
                        {
                            Console.WriteLine("*");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    largo += 2;
                }
            }

            Console.ReadKey();  
        }
    }
}
