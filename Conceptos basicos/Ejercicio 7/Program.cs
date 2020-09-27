using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaActual = DateTime.Now;
            DateTime fechaNacimiento = new DateTime();
            TimeSpan diferenciaEntreFechas;
            int diasEntreFechas;

            Console.Write("Ingrese la fecha de nacimiento(d/m/a): ");
            DateTime.TryParse(Console.ReadLine(), out fechaNacimiento);

            diferenciaEntreFechas = fechaActual - fechaNacimiento;
            diasEntreFechas = diferenciaEntreFechas.Days;

            Console.Write("Los dias que vivio son: " + diasEntreFechas);
            Console.ReadKey();

        }
    }
}
