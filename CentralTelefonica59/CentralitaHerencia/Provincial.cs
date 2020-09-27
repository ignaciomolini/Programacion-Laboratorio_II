using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }

        private string rutaDeArchivoProvincial = "provinciales.xml";
        public Franja franjaHoraria; // xml serializa solo atributos publicos, si lo dejo en protected sale por defecto franja_1

        #region Propiedades
        public string RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivoProvincial;
            }
            set
            {
                this.rutaDeArchivoProvincial = value;
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
        public Provincial() : base()
        {

        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
            
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion

        #region Metodos
        public bool Guardar()
        {
            bool retorno = false;

            using (XmlTextWriter tw = new XmlTextWriter(RutaDeArchivo, UTF8Encoding.Default))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Provincial));
                ser.Serialize(tw, this);
                retorno = true;
            }

            return retorno; ;
        }

        public Provincial Leer()
        {
            Provincial llamadaProvincial;

            using (XmlTextReader tr = new XmlTextReader(RutaDeArchivo))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Provincial));
                object obj = ser.Deserialize(tr);

                if (obj is Provincial)
                {
                    llamadaProvincial = (Provincial)obj;
                }
                else
                {
                    throw new InvalidCastException();
                }
            }

            return llamadaProvincial;
        }

        private float CalcularCosto()
        {
            float costoLlamada = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costoLlamada = (float)(base.Duracion * 0.99);
                    break;

                case Franja.Franja_2:
                    costoLlamada = (float)(base.Duracion * 1.25);
                    break;

                case Franja.Franja_3:
                    costoLlamada = (float)(base.Duracion * 0.66);
                    break;
            }

            return costoLlamada;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Tipo de llamada: Provincial");
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: ${this.CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria} ");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
