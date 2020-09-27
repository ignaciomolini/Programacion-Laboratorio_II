using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void CalcularFinal()
        {
            Random notaRandom = new Random();

            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = notaRandom.Next(4, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nota 1: {nota1}");
            sb.AppendLine($"Nota 2: {nota2}");

            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine($"Alumno desaprobado!");
            }

            return sb.ToString();
        }
    }
}
