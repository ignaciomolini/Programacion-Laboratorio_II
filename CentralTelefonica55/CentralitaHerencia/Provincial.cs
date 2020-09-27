using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }

        protected Franja franjaHoraria;

        #region Propiedades
        public string RutaDeArchivo
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Provincial Leer()
        {
            throw new NotImplementedException();
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
