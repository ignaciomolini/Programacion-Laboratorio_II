using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesos peso = new Pesos(15, 65.45);
            Euro euro = new Euro(50, 0.92);
            Dolar dolar = new Dolar(30);
            Euro auxEuro;
            Pesos auxPeso;

            Console.WriteLine($"Cantidad de pesos: {peso.GetCantidad()} - Cotizacion respecto al dolar: {Pesos.GetCotizacion()}");
            Console.WriteLine($"Cantidad de euros: {euro.GetCantidad()} - Cotizacion respecto al dolar: {Euro.GetCotizacion()}");
            Console.WriteLine($"Cantidad de dolares: {dolar.GetCantidad()}");

            auxEuro = euro + peso;
            Console.WriteLine($"\n{euro.GetCantidad()} Euros + {peso.GetCantidad()} Pesos: {auxEuro.GetCantidad()} Euros");
            auxEuro = euro - dolar;
            Console.WriteLine($"{euro.GetCantidad()} Euros - {peso.GetCantidad()} Dolares: {auxEuro.GetCantidad()} Euros");

            peso = 1500; // Conversiones implicitas
            euro = 35;
            dolar = 250;

            Console.WriteLine($"\nCantidad de pesos: {peso.GetCantidad()} - Cotizacion respecto al dolar: {Pesos.GetCotizacion()}");
            Console.WriteLine($"Cantidad de euros: {euro.GetCantidad()} - Cotizacion respecto al dolar: {Euro.GetCotizacion()}");
            Console.WriteLine($"Cantidad de dolares: {dolar.GetCantidad()}");

            if(peso != dolar)
            {
                auxPeso = peso + dolar;
                Console.WriteLine($"\n{peso.GetCantidad()} Pesos + {dolar.GetCantidad()} Dolares: {auxPeso.GetCantidad()} Pesos");
            }

            euro = (Euro)dolar; // Conversion explicita

            Console.WriteLine($"\nCantidad de euros: {euro.GetCantidad()} - Cotizacion respecto al dolar: {Euro.GetCotizacion()}");

            Console.ReadKey();
        }
    }
}
