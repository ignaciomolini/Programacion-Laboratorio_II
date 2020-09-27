using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(int numeroDecimal)
        {
            string resultado = "";

            if(numeroDecimal > 0)
            {
                while(numeroDecimal > 0)
                {
                    if(numeroDecimal % 2 == 0)
                    {
                        resultado = "0" + resultado;
                    }
                    else
                    {
                        resultado = "1" + resultado;
                    }

                    numeroDecimal = (int)(numeroDecimal / 2);
                }
            }
            else
            {
                if(numeroDecimal == 0)
                {
                    resultado = "0";
                }
                else
                {
                    resultado = "-1";
                }
            }
            return resultado;
        }

        public static int BinarioDecimal(string binario)
        {
            int resultado = 0;
            int j = 0;

            for (int i = binario.Length - 1; i >= 0; i--)
            { 
                if (binario[i] == '1' || binario[i] == '0')
                {
                    resultado += (int)(int.Parse(binario[i].ToString()) * Math.Pow(2, j)); 
                }
                else 
                {
                    resultado = -1;
                    break;
                }
                j++;
            }
            return resultado;
        }
    }
}
