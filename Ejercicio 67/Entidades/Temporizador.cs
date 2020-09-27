using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get
            {
                return !(this.hilo is null) && this.hilo.IsAlive;
            }
            set
            {
                if(value && (this.hilo is null) && !this.hilo.IsAlive)
                {
                    this.hilo = new Thread(this.Corriendo);
                    this.hilo.Start();
                }
                else if(value && !(this.hilo is null) && !this.hilo.IsAlive)
                {
                    this.hilo.Start();
                }
                else if (!value && this.Activo)
                {
                    this.hilo.Abort();
                }
            }
        }

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        private void Corriendo()
        {

        }

        public delegate void encargadoTiempo();

        public event encargadoTiempo EventoTiempo;
    }
}
