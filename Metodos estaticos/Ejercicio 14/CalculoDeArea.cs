using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return lado * lado;
        }

        public static double CalcularTriangulo(double baseT, double alturaT)
        {
            return (baseT * alturaT) / 2;
        }

        public static double CalcularCirculo(double radio)
        {
            return Math.Pow(radio, 2) * Math.PI;
        }
    }
}
