using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        #region Atributos
        private ConsoleColor colorTinta;
        private float tinta;
        #endregion

        #region Propiedades
        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }
        #endregion

        #region Constructores
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.UnidadesDeEscritura = unidades;
            this.Color = color;
        }
        #endregion

        #region Metodos
        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper eW;
            float nivelTinta;

            nivelTinta = this.UnidadesDeEscritura - (float)(texto.Length * 0.3);
            if(nivelTinta < 0)
            {
                eW = new EscrituraWrapper("-No hay suficiente tinta para escribir ese texto-", ConsoleColor.Gray);
            }
            else
            {
                this.UnidadesDeEscritura = nivelTinta;
                eW = new EscrituraWrapper(texto, this.Color);
            }

            return eW;
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("[Bolígrafo]");
            sb.AppendLine($"Color: {this.Color}");
            sb.AppendLine($"Nivel de tinta: {this.UnidadesDeEscritura}");

            return sb.ToString();
        }
        #endregion

    }
}
