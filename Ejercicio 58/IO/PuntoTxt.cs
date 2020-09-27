using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string objeto)
        {
            bool retorno = false;

            if (this.ValidarArchivos(ruta, true))
            {
                using (StreamWriter sw = new StreamWriter(ruta, true, UTF8Encoding.Default))
                {
                    sw.WriteLine(objeto);
                    retorno = true;
                }
            }
            else
            {
                if (this.GuardarComo(ruta, objeto))
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public bool GuardarComo(string ruta, string objeto)
        {
            bool retorno = false;
           
            using (StreamWriter sw = new StreamWriter(ruta, true, UTF8Encoding.Default))
            {
                sw.WriteLine(objeto);
                retorno = true;
            }
            
            return retorno;
        }

        public string Leer(string ruta)
        {
            string retornoLectura = "";

            if (this.ValidarArchivos(ruta, true))
            {
                using (StreamReader fs = new StreamReader(ruta, UTF8Encoding.Default))
                {
                    retornoLectura = fs.ReadToEnd();
                }
            }

            return retornoLectura;
        }

        protected override bool ValidarArchivos(string ruta, bool validaExistencia)
        {
            bool retorno = false;

            try
            {
                if (base.ValidarArchivos(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".txt")
                    {
                        retorno = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .txt");
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", ex);
            }

            return retorno;
        }
    }
}
