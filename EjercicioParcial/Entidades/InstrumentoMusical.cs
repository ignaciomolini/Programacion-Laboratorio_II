using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class InstrumentoMusical
    {
        protected int precio;
        protected string marca;
        protected bool fabricadoEnArgentina;
        protected string descripcion;

        public InstrumentoMusical()
        {
            this.descripcion = "Sin descripcion";
        }

        public InstrumentoMusical(int precio, string marca, bool fabricadoEnArgentina) : this()
        {
            this.precio = precio;
            this.marca = marca;
            this.fabricadoEnArgentina = fabricadoEnArgentina;
        }

    }
}
