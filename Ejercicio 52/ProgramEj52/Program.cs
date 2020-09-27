using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ProgramEj52
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(2);
            Boligrafo miBoligrafo = new Boligrafo(2, ConsoleColor.Green);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Se puede escribir");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            EscrituraWrapper e2Lapiz = ((IAcciones)miLapiz).Escribir("No se puede escribir");
            Console.ForegroundColor = e2Lapiz.color;
            Console.WriteLine(e2Lapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("No se puede escribir");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);
            miBoligrafo.Recargar(20);
            Console.WriteLine("Hago una recarga\n");
            EscrituraWrapper e2Boligrafo = miBoligrafo.Escribir("Se puede escribir");
            Console.ForegroundColor = e2Boligrafo.color;
            Console.WriteLine(e2Boligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.ReadKey();
        }
    }
}
