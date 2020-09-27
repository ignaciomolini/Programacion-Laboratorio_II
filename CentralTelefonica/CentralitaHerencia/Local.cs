using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        #region Propiedades
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion


        #region Constructores
        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : this(new Llamada(duracion, destino, origen), costo)
        {

        }

        #endregion 

        #region Metodos
        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Tipo de llamada: Local");
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: ${this.CostoLlamada}");

            return sb.ToString();
        }
        #endregion
    }
}
