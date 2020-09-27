using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("SuperLiga");
            EquipoBasquet eBasquet1 = new EquipoBasquet("Boston Celtics", new DateTime(1946, 6, 6));
            EquipoBasquet eBasquet2 = new EquipoBasquet("Chicago Bulls", new DateTime(1966, 1, 16));
            EquipoBasquet eBasquet3 = new EquipoBasquet("Dallas Mavericks", new DateTime(1980, 1, 23));
            EquipoFutbol eFutbol1 = new EquipoFutbol("Lanus", new DateTime(1915, 1, 3));
            EquipoFutbol eFutbol2 = new EquipoFutbol("Independiente", new DateTime(1905, 1, 1));
            EquipoFutbol eFutbol3 = new EquipoFutbol("Tigre", new DateTime(1902, 8, 3));

            torneoBasquet += eBasquet1;
            torneoBasquet += eBasquet2;
            torneoBasquet += eBasquet3;
            torneoFutbol += eFutbol1;
            torneoFutbol += eFutbol2;
            torneoFutbol += eFutbol3;

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine("Partidos: ");
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine();

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine("Partidos: ");
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.ReadKey();
        }
    }
}
