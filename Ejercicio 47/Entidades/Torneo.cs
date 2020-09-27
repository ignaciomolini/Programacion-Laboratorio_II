using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        #region Atributos
        private List<T> equipos;
        private string nombre;
        private Random random = new Random((int)DateTime.Now.Ticks);
        #endregion

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }
        
        public string JugarPartido
        {
            get
            {
                string retorno;
                Equipo primerEquipo = this.equipos[random.Next(0, equipos.Count)];
                Equipo segundoEquipo = this.equipos[random.Next(0, equipos.Count)];

                while (this.equipos.Count >= 2 && primerEquipo == segundoEquipo)
                {
                    segundoEquipo = this.equipos[random.Next(0, equipos.Count)];
                }

                if (this.equipos.Count < 2)
                {
                    retorno = "Se necesitan dos o mas equipos en el torneo para jugar un partido";
                }
                else
                {
                    retorno = this.CalcularPartido((T)primerEquipo, (T)segundoEquipo);
                }

                return retorno;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("Torneo: {0}", nombre));
            foreach(T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido(T equipoUno, T equipoDos)
        {
            string retorno = "";
            if (equipoUno is EquipoBasquet)
            {
                retorno = $"Resultado:  {equipoUno.Nombre}  {random.Next(0, 100)} : {random.Next(0, 100)}  {equipoDos.Nombre}";
            }
            else
            {
                retorno = $"Resultado:  {equipoUno.Nombre}  {random.Next(0, 10)} : {random.Next(0, 10)}  {equipoDos.Nombre}";
            }

            return retorno;
        }

        public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        {
            bool esta = false;

            foreach (T item in torneo.equipos)
            {
                if(item == equipo)
                {
                    esta = true;
                    break;
                }
            }

            return esta;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, Equipo equipo)
        {
            if(torneo != equipo)
            {
                torneo.equipos.Add((T)equipo);
            }

            return torneo;
        }


    }
}
