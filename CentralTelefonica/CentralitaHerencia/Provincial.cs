﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }

        protected Franja franjaHoraria;

        #region Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja, new Llamada(duracion, destino, origen))
        {

        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float costoLlamada = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costoLlamada = (float)(this.Duracion * 0.99);
                    break;

                case Franja.Franja_2:
                    costoLlamada = (float)(this.Duracion * 1.25);
                    break;

                case Franja.Franja_3:
                    costoLlamada = (float)(this.Duracion * 0.66);
                    break;
            }

            return costoLlamada;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Tipo de llamada: Provincial");
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: ${this.CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria} ");

            return sb.ToString();
        }
        #endregion
    }
}
