using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "Jose";
            alumno1.apellido = "Roberto";
            alumno1.legajo = 152152;

            alumno2.nombre = "Carlos";
            alumno2.apellido = "Raul";
            alumno2.legajo = 132659;

            alumno3.nombre = "Hugo";
            alumno3.apellido = "Ricardo";
            alumno3.legajo = 184644;

            alumno1.Estudiar(5, 7);
            alumno1.CalcularFinal();
            Console.WriteLine(alumno1.Mostrar());

            alumno2.Estudiar(10, 8);
            alumno2.CalcularFinal();
            Console.WriteLine(alumno2.Mostrar());

            alumno3.Estudiar(7, 6);
            alumno3.CalcularFinal();
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
