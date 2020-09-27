using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ArchivoTexto
    {
        /// <summary>
        /// Metodo que guarda el texto del objeto pasado por parametro 
        /// en la ruta que el objeto tambien le da.
        /// </summary>
        /// <param name="objeto">objeto que impleta la interfaz IArchivoTexto</param>
        public static void Guardar(IArchivoTexto objeto)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(objeto.Ruta, true, UTF8Encoding.Default);
                sw.WriteLine(objeto.Texto);
            }
            finally
            {
                if(!(sw is null))
                {
                    sw.Close();
                }
            }
        }
    }
}
