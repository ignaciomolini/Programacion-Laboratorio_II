using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera2
    {
        #region Atributos
        private List<Boligrafo> boligrafos;
        private List<Lapiz> lapices;
        #endregion

        #region Propiedades
        public Boligrafo Boligrafos
        {
            set
            {
                this.boligrafos.Add(value);
            }
        }

        public Lapiz Lapices
        {
            set
            {
                this.lapices.Add(value);
            }
        }
        #endregion

        #region Constructores
        public Cartuchera2()
        {
            this.boligrafos = new List<Boligrafo>();
            this.lapices = new List<Lapiz>();
        }
        #endregion

        #region Metodos
        public bool ProbarElementos()
        {
            bool retorno = true;
            //EscrituraWrapper eW;

            foreach(Boligrafo item in this.boligrafos)
            {
                //eW = item.Escribir("1");
                //if (eW.texto != "1")
                //{
                //    retorno = false;
                //    item.Recargar(1);
                //}

                if (item.UnidadesDeEscritura >= 1)
                {
                    item.UnidadesDeEscritura -= 1;
                }
                else
                { 
                    retorno = false;
                    item.Recargar(5);
                }
            }

            foreach(Lapiz item in this.lapices)
            {
                // ((IAcciones)item).Escribir("1");
                if (((IAcciones)item).UnidadesDeEscritura >= 1)
                {
                    ((IAcciones)item).UnidadesDeEscritura -= 1;
                }
            }

            return retorno;
        }
        #endregion


    }
}
