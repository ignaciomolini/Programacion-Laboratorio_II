using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        protected float costo;

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
                return CalcularCosto();
            }
        }
        #endregion

        #region Constructores
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
            throw new NotImplementedException();
        }

        public Local Leer()
        {
            throw new NotImplementedException();
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
