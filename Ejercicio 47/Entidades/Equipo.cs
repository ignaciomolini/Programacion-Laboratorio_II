using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Ficha()
        {
            return $"Equipo:{nombre} -fundado el {fechaCreacion.Day}/{fechaCreacion.Month}/{fechaCreacion.Year}-";
        }

        public static bool operator ==(Equipo equipoUno, Equipo equipoDos)
        {
            bool sonIguales = false;

            if(equipoUno.nombre == equipoDos.nombre && equipoUno.fechaCreacion == equipoDos.fechaCreacion)
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        public static bool operator !=(Equipo equipoUno, Equipo equipoDos)
        {
            return !(equipoUno == equipoDos);
        }


    }
}
