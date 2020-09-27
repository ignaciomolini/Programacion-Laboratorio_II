using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoCuerda
    {
        GuitarraElectrica,
        GuitarraAcustica,
        Bajo,
        Violin,
        Piano
    }

    public class InstrumentoCuerda : InstrumentoMusical
    {
        ETipoCuerda tipoInstrumento;

        public InstrumentoCuerda(int precio, string marca, bool fabricadoEnArgentina) : base(precio, marca, fabricadoEnArgentina)
        {

        }
    }
}
