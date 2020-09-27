using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caja
    {
        private List<string> filaClientes;

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            foreach(string item in this.FilaClientes)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"Atendiendo a {item} en la {Thread.CurrentThread.Name}");
            }
        }
    }
}
