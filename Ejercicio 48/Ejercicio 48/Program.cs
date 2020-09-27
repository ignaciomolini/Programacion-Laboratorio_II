using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();
            Recibo reciboUno = new Recibo();
            Recibo reciboDos = new Recibo(25807596);
            Factura facturaUno = new Factura(15706976);
            Factura facturaDos = new Factura(34546398);

            contabilidad += reciboUno;
            contabilidad += reciboDos;
            contabilidad += facturaUno;
            contabilidad += facturaDos;

            contabilidad.Mostrar(); // Creo un metodo para mostrar los numeros de documentos de las facturas de la lista de agresos de contablidad y
                                    // y los de los recibos de la lista de ingresos de contabilidad

            Console.ReadKey();
        }
    }
}
