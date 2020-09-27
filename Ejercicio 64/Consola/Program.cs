using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);

            negocio.Clientes.Add("Marcos");
            negocio.Clientes.Add("Jose");
            negocio.Clientes.Add("Cristina");
            negocio.Clientes.Add("Romina");
            negocio.Clientes.Add("Carlos");
            negocio.Clientes.Add("Roman");
            negocio.Clientes.Add("Josefina");


            Thread hiloNegocio = new Thread(negocio.AsignarCaja);
            Thread hiloCaja1 = new Thread(negocio.Caja1.AtenderClientes);
            Thread hiloCaja2 = new Thread(negocio.Caja2.AtenderClientes);

            hiloCaja1.Name = "Caja 1";
            hiloCaja2.Name = "Caja 2";

            hiloNegocio.Start();
            hiloNegocio.Join();
            hiloCaja1.Start();
            hiloCaja1.Join(); // atiende primero la caja 1 y desp pasa a la siguiente en vez de hacer las dos a la vez
            hiloCaja2.Start();

            Console.ReadKey();
        }
    }
}
