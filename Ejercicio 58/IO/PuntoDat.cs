using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        public PuntoDat()
        {

        }

        public bool Guardar(string ruta, PuntoDat objeto)
        {
            bool retorno = false;
     
            if(this.ValidarArchivos(ruta, true) && objeto != null)
            {
                using (Stream fs = new FileStream(ruta, FileMode.Open))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    ser.Serialize(fs, objeto);
                    retorno = true;
                }
            }
            else if(objeto != null)
            {
                if(this.GuardarComo(ruta, objeto))
                {
                    retorno = true;
                }
            }
          
            return retorno;
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            bool retorno = false;

            if(objeto != null)
            {
                using (Stream fs = new FileStream(ruta, FileMode.OpenOrCreate))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    ser.Serialize(fs, objeto);
                    retorno = true;
                }
            }
            
            return retorno;
        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat retornoLectura = null;

            if(this.ValidarArchivos(ruta, true))
            {
                using(Stream fs = new FileStream(ruta, FileMode.Open))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    retornoLectura = (PuntoDat)ser.Deserialize(fs);
                }
            }

            return retornoLectura;
        }

        protected override bool ValidarArchivos(string ruta, bool validaExistencia)
        {
            bool retorno = false;

            try
            {
                if(base.ValidarArchivos(ruta, validaExistencia))
                {
                    if(Path.GetExtension(ruta) == ".dat")
                    {
                        retorno = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .dat");
                    }
                }
            }
            catch(FileNotFoundException ex)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", ex);             
            }

            return retorno;
        }

    }
}
