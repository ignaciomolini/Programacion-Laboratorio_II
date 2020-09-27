using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            string salir;
            float totalBruto;
            float totalNeto;
            float descuento;

            do
            {
                Console.Write("Ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese el valor por hora: ");
                float.TryParse(Console.ReadLine(), out valorHora);

                Console.Write("Ingrese la antiguedad: ");
                int.TryParse(Console.ReadLine(), out antiguedad);

                Console.Write("Ingrese las horas trabajadas(en el mes): ");
                int.TryParse(Console.ReadLine(), out horasTrabajadas);

                totalBruto = (valorHora * horasTrabajadas) + (150 * antiguedad);
                descuento = totalBruto * 13 / 100;
                totalNeto = totalBruto - descuento;

                Console.WriteLine("\nNombre del empleado: " + nombre);
                Console.WriteLine("Valor por hora: " + valorHora);
                Console.WriteLine("Antiguedad del empleado: " + antiguedad);
                Console.WriteLine("Ganancia en bruto: " + totalBruto);
                Console.WriteLine("Descuento: " + descuento);
                Console.WriteLine("Ganancia en neto: " + totalNeto);

                Console.Write("\nDesea ingresar mas empleados?: ");
                salir = Console.ReadLine();
                Console.Write("\n");

            } while (salir == "si");

            Console.ReadKey();
        }
    }
}
