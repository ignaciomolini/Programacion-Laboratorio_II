using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        #region Atributos
        private float tamanioMina;
        #endregion

        #region Propiedades
        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.DarkGray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }
        #endregion

        #region Constructores
        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }
        #endregion

        #region Metodos
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            EscrituraWrapper eW;
            float mina;

            mina = ((IAcciones)this).UnidadesDeEscritura - (float)(texto.Length * 0.1);
            if(mina < 0)
            {
                eW = new EscrituraWrapper("-No alcanza la mina del lapiz para ese texto-", ConsoleColor.Gray);
            }
            else
            {
                ((IAcciones)this).UnidadesDeEscritura = mina;
                eW = new EscrituraWrapper(texto, ((IAcciones)this).Color);
            }

            return eW;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("[Lapiz]");
            sb.AppendLine($"Color: {((IAcciones)this).Color}");
            sb.AppendLine($"Tamaño de la mina: {((IAcciones)this).UnidadesDeEscritura}");

            return sb.ToString();
        }
        #endregion
    }
}
