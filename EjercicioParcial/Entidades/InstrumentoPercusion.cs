using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoPercusion
    {
        Bateria,
        CajonPeruano,
        Tambor
    }

    public class InstrumentoPercusion : InstrumentoMusical
    {
        ETipoPercusion tipoInstrumento;
    }
}
