using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Program57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Pablo", "Ramirez");
            Persona personaDos;

            Persona.Guardar(personaUno, "ArchivoBinario.bin");
            personaDos = Persona.Leer("ArchivoBinario.bin");

            Console.WriteLine(personaDos.ToString());

            Console.ReadKey();
        }
    }
}
