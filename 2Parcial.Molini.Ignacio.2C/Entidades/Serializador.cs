using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Serializador<T> where T : class, new()
    {
        /// <summary>
        /// Metodo que serializa en objeto pasado por parametro en Xml y lo guarda en la ruta 
        /// que se le paso tambien por parametro.
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="ruta"></param>
        /// <returns>Retorno un bool en true si lo pudo serializar</returns>
        public static bool SerializarAXml(T objeto, string ruta)
        {
            bool retorno = false;

            try
            {
                using(XmlTextWriter tw = new XmlTextWriter(ruta, UTF8Encoding.Default))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(tw, objeto);
                    retorno = true;
                }
            }
            catch(Exception ex)
            {
                throw new ClinicaException("Error al serializar en Xml", ex);
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que deserializa el archivo Xml que se le pasa por parametro.
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>Retorna un objeto con los datos cargados</returns>
        public static T DeserializarXml(string ruta)
        {
            T objetoRetorno = null;

            try
            {
                using (XmlTextReader tr = new XmlTextReader(ruta))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    objetoRetorno = (T)ser.Deserialize(tr);
                }
            }
            catch (Exception ex)
            {
                throw new ClinicaException("Error al deserializar el archivo Xml", ex);
            }

            return objetoRetorno;
        }

        /// <summary>
        /// Metodo que serializa en objeto pasado por parametro en Binario y lo guarda en la ruta 
        /// que se le paso tambien por parametro.
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="ruta"></param>
        /// <returns>Retorno un bool en true si lo pudo serializar</returns>
        public static bool SerializarABinario(T objeto, string ruta)
        {
            bool retorno = false;

            try
            {
                using(FileStream fs = new FileStream(ruta, FileMode.Create))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    ser.Serialize(fs, objeto);
                    retorno = true;
                }
            }
            catch(Exception ex)
            {
                throw new ClinicaException("Error al serializar binario", ex);
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que deserializa el archivo Binario que se le pasa por parametro.
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>Retorna un objeto con los datos cargados</returns>
        public static T DeserializarBinario(string ruta)
        {
            T objetoRetorno = null;

            try
            {
                using (FileStream fs = new FileStream(ruta, FileMode.Open))
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    objetoRetorno = (T)ser.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new ClinicaException("Error al deserializar el archivo binario", ex);
            }

            return objetoRetorno;
        }
    }
}
