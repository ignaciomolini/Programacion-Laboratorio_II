using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensionFecha
    {
        /// <summary>
        /// Metodo de extension que cambia el formato de la fecha.
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static string FormatearFecha(this DateTime fecha)
        {
            return $"{fecha.ToString("*** MM/dd/yyyy HH:mm ***")}";
        }
    }
}
