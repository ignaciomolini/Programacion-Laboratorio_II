using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.Lanzar();
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public MiClase(string a)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("MiClase 2do constructor de instancia.", ex); //ex contiene DivideByZeroException
            }
        }

        public static void Lanzar()
        {
            throw new DivideByZeroException();
        }
    }
}
