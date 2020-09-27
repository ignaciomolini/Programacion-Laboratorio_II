using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }

        public abstract bool TieneFlores
        {
            get;
        }

        public abstract bool TieneFruto
        {
            get;
        }

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            string respuestaFlores;
            string respuestaFruto;

            if (TieneFlores)
            {
                respuestaFlores = "SI";
            }
            else
            {
                respuestaFlores = "NO";
            }

            if(TieneFruto)
            {
                respuestaFruto = "SI";
            }
            else
            {
                respuestaFruto = "NO";
            }

            sb.AppendLine(String.Format("\n{0} tiene un tamaño de {1} cm", this.nombre, this.tamanio));
            sb.AppendLine(String.Format("Tiene flores: {0}", respuestaFlores));
            sb.AppendLine(String.Format("Tiene frutos: {0}", respuestaFruto));

            return sb.ToString();
        }
    }
}
