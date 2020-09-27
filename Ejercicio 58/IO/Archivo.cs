using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    [Serializable]
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivos(string ruta, bool validaExistencia)
        {
            bool retorno = false;

            if(validaExistencia) 
            {
                if(File.Exists(ruta))
                {
                    retorno = true;
                }
                else
                {
                    throw new FileNotFoundException();
                }     
            }

            return retorno;
        }
    }
}
