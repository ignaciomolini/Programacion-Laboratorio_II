using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades17
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";

            if(gasto <= this.tinta)
            {
                gasto *= -1;
                this.SetTinta(gasto);

                for (int i = gasto; i < 0; i++)
                {
                    dibujo += "*";
                }

                retorno = true;
            }

            return retorno;
        }

        public void Recargar()
        {
            int cantidadFaltante = cantidadTintaMaxima - this.tinta;

            this.SetTinta((short)cantidadFaltante);
        }

        private void SetTinta(short tinta)
        {
            int suma = this.tinta + tinta;

            if(suma >= 0 && suma <= cantidadTintaMaxima)
            {
                this.tinta = (short) suma;
            }
        }
    }
}
