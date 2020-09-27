using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad<T,U> where T : Documento where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            if(c != null && egreso != null)
            {
                c.egresos.Add(egreso);
            }

            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (c != null && ingreso != null)
            {
                c.ingresos.Add(ingreso);
            }

            return c;
        }

        public void Mostrar()
        {
            foreach (Documento item in ingresos)
            {
                Console.WriteLine($"Documento de recibo: {item.Numero}");
            }
            Console.WriteLine();
            foreach (Documento item in egresos)
            {
                Console.WriteLine($"Documento de factura: {item.Numero}");
            }           
        }

    }
}
