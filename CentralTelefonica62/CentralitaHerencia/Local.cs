using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        public float costo; // xml serializa solo atributos publicos
        private string rutaDeArchivoLocal = "locales.xml";

        #region Propiedades
        public string RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivoLocal;
            }
            set
            {
                this.rutaDeArchivoLocal = value;
            }
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Local() : base()
        {

        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        #endregion 

        #region Metodos
        public bool Guardar()
        {
            bool retorno = false;
            
            using(XmlTextWriter tw = new XmlTextWriter(RutaDeArchivo, UTF8Encoding.Default))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Local));
                ser.Serialize(tw, this);
                retorno = true;
            }

            return retorno;
        }

        public Local Leer()
        {
            Local llamadaLocal;

            using(XmlTextReader tr = new XmlTextReader(RutaDeArchivo))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Local));
                object obj = ser.Deserialize(tr);

                if(obj is Local)
                {
                    llamadaLocal = (Local)obj;
                }
                else
                {
                    throw new InvalidCastException();
                }
            }

            return llamadaLocal;
        }

        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Tipo de llamada: Local");
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: ${this.CostoLlamada}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
