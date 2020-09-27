using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClinicaException : Exception, IArchivoTexto
    {
        /// <summary>
        /// Constructor que recibe un paramatro con el mensaje de error.
        /// </summary>
        /// <param name="mensaje"></param>
        public ClinicaException(string mensaje) : this(mensaje, null)
        {

        }

        /// <summary>
        /// Constructor que recibe un mensaje con el error y la innerExcepcion
        /// y utiliza el metodo Guarda para guardar en un archivo de texto los errores.
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public ClinicaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
            ArchivoTexto.Guardar(this);
        }

        /// <summary>
        /// Implementacion de la propiedad de la interfaz que le da un formato
        /// a los errores de la instancia para poder guardarlos en un archivo de texto.
        /// </summary>
        public string Texto
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(DateTime.Now.FormatearFecha());
                sb.AppendLine(this.Message);
                Exception innerEx = this.InnerException;

                while(!(innerEx is null))
                {
                    sb.AppendLine(innerEx.Message);
                    innerEx = innerEx.InnerException;
                }
                sb.AppendLine();

                return sb.ToString();
            }
        }

        /// <summary>
        /// Implementacion de la propiedad de la interfaz que define la ruta donde
        /// se guardaran los errores.
        /// </summary>
        public string Ruta
        {
            get
            {
                return $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\SegundoParcialUtn\" +
                @"LogClinica\RegistroErrores.txt";
            }
        }

    }
    
}
