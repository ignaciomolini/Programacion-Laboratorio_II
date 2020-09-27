using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string lectura;

            Console.Write("Ingrese un numero: ");
            lectura = Console.ReadLine();

            while (!int.TryParse(lectura, out numero))
            {
                Console.Write("Error. Ingrese un numero: ");
                lectura = Console.ReadLine();
            }

            for (int centro = 1; centro <= numero; centro++)
            {
                int acumulador = 0;
                for (int i = 1; i < centro; i++)
                {
                    acumulador += i;
                }

                int contador = centro + 1;
                do
                {
                    acumulador -= contador;
                    contador++;

                } while (acumulador > 0);

                if (acumulador == 0)
                {
                    Console.WriteLine("{0} es centro numérico", centro);
                }            
            }
            Console.ReadKey();        
        }
    }
}
