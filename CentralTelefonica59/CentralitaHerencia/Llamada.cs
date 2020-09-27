using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        public float duracion;     // los cambio a public porque xml solo serializa atributos publicos
        public string nroDestino;
        public string nroOrigen;

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

        public abstract float CostoLlamada
        {
            get;
        }
        #endregion

        #region Constructores
        public Llamada()
        {

        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Metodos
        protected virtual string Mostrar()
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

        #region Operadores
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;

            if(l1.Equals(l2) && l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion
    }
}
