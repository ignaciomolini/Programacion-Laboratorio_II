using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        public enum Tipo
        {
            Terrozo,
            Arenozo
        }

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        public Tipo TipoSuelo
        {
            set
            {
                Jardin.suelo = value;
            }
        }

        static Jardin()
        {
            Jardin.suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal) : this()
        {
            this.espacioTotal = espacioTotal;
        }

        private int EspacioOcupado()
        {
            int espacioOcupado = 0;

            foreach(Planta i in plantas)
            {
                espacioOcupado += i.Tamanio;
            }

            return espacioOcupado;
        }

        private int EspacioOcupado(Planta planta)
        {
            return EspacioOcupado() + planta.Tamanio;
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            int espacioOcupado = jardin.EspacioOcupado(planta);
            bool retorno = false;

            if(jardin.espacioTotal >= espacioOcupado )
            {
                jardin.plantas.Add(planta);
                retorno = true;
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Composicion del jardin: {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado {EspacioOcupado()} de {this.espacioTotal}");

            sb.AppendLine("-----------------------------------------------------------");

            foreach (Planta i in plantas)
            {
                sb.Append(i.ResumenDeDatos());
            }

            return sb.ToString();
        }


    }
}
