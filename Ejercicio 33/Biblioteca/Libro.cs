using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        private List<string> paginas;

        public string this[int index]
        {
            get
            {
                return this.paginas[index];
            }

            set
            {

            }
        }
    }
}
