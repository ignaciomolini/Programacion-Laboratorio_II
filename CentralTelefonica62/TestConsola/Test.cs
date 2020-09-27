using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;
using EntidadesDAO;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {   
            Centralita c = new Centralita("Nacho Center"); 
            Local l1 = new Local("Bernal", 64, "Lanus", 0.21f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_2, 34, "Bariloche");
            Local l3 = new Local("Lanús", 45, "Avellaneda", 0.25f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            ProvincialDAO provincialDAO = new ProvincialDAO();
            LocalDAO localDAO = new LocalDAO();
            List<Llamada> listaLlamadas = new List<Llamada>();

            c.Llamadas.Add(l1);
            c.Llamadas.Add(l2);
            c.Llamadas.Add(l3);
            c.Llamadas.Add(l4);
            Console.WriteLine(c.ToString());
            c.OrdenarLlamadas();
            Console.WriteLine("-----Llamadas ordenadas por duracion-----\n");
            Console.WriteLine(c.ToString());

            try
            {
                if (l1.Guardar())
                {
                    Console.WriteLine(l1.Leer().ToString());
                }

                if (l2.Guardar())
                {
                    Console.WriteLine(l2.Leer().ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            Console.ReadKey();
        }
    }
}
