using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Propiedades
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duracion de la llamada: {this.Duracion} segundos");
            sb.AppendLine($"Numero de destino: {this.NroDestino}");
            sb.AppendLine($"Numero de origen: {this.NroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno;

            if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                retorno = -1;
            }
            else
            {
                retorno = 0;
            }

            return retorno;
        }
        #endregion
    }
}
