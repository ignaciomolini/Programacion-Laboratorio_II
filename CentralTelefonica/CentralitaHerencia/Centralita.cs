using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retornoGanancias = 0;

            foreach (Llamada item in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (item is Local)
                        {
                            retornoGanancias += ((Local)item).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            retornoGanancias += ((Provincial)item).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Todas:
                        if (item is Local)
                        {
                            retornoGanancias += ((Local)item).CostoLlamada;
                        }
                        else if (item is Provincial)
                        {
                            retornoGanancias += ((Provincial)item).CostoLlamada;
                        }
                        break;
                }
            }

            return retornoGanancias;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 1;

            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancias en llamadas locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancias en llamadas provinciales: {this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancias en total: {this.GananciasPorTotal}");

            sb.AppendLine("\nDatos de las llamadas:\n");
            foreach (Llamada item in this.listaDeLlamadas)
            {
                if (item is Local)
                {
                    sb.AppendLine($"{i}-{((Local)item).Mostrar()}");
                }
                else if (item is Provincial)
                {
                    sb.AppendLine($"{i}-{((Provincial)item).Mostrar()}");
                }
                i++;
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion

    }
}
