using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivoTexto
    {
        /// <summary>
        /// Propiedad a ser implementada por las clases
        /// que implementen la interfaz.
        /// </summary>
        string Texto
        {
            get;
        }

        /// <summary>
        /// Propiedad a ser implementada por las clases
        /// que implementen la interfaz.
        /// </summary>
        string Ruta
        {
            get;
        }
    }
}
