using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {   
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(2, 6);
            Punto punto3 = new Punto(10, -5);

            Rectangulo rectangulo1 = new Rectangulo(punto1, punto3);

            Console.WriteLine($"El area del rectangulo es: {rectangulo1.GetArea()} y su perimetro: {rectangulo1.GetPerimetro()}");

            Console.ReadKey();
        }
    }
}
