using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rosal : Planta
    {
        public enum Color
        {
            Roja,
            Blanca,
            Amarilla,
            Rosa,
            Azul
        }

        private Color florColor;

        public override bool TieneFlores
        {
            get
            {
                return true;
            }
        }

        public override bool TieneFruto
        {
            get
            {
                return false;
            }
        }

        public Rosal(string nombre, int tamanio) : base(nombre, tamanio)
        {

        }

        public Rosal(string nombre, int tamanio, Color flor) : this(nombre, tamanio)
        {
            this.florColor = flor;
        }

        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ResumenDeDatos());
            sb.AppendLine(String.Format("Flores de color: {0}", florColor));

            return sb.ToString();
        }

    }
}
