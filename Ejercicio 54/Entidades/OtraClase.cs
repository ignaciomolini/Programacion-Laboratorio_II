using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void MetodoDeInstancia()
        {
            try
            {
                new MiClase("");
            }
            catch(UnaExcepcion ex)
            {
                throw new MiExcepcion("OtraClase metodo de instancia.", ex); //ex contiene UnaExcepcion
            }
        }
    }
}
