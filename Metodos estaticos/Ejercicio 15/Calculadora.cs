using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double num1, double num2, string operador)
        {
            double resultado = 0;

            if(operador == "+")
            {
                resultado = num1 + num2;
            }
            else if(operador == "-")
            {
                resultado = num1 - num2;
            }
            else if (operador == "*")
            {
                resultado = num1 * num2;
            }
            else if (operador == "/")
            {
                if(Validar(num2))
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero!");
                }
            }
            else
            {
                Console.WriteLine("El operador no es valido!");
            }

            return resultado;
        }

        private static bool Validar(double num2)
        {
            bool respuesta = false;

            if(num2 != 0)
            {
                respuesta = true;
            }

            return respuesta;
        }
    }
}
