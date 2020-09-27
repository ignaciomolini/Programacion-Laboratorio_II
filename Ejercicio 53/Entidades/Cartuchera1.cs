using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        #region Atributos
        private List<IAcciones> utiles;
        #endregion

        #region Propiedades
        public IAcciones Utiles
        {
            set
            {
                this.utiles.Add(value);
            }
        }
        #endregion

        #region Constructores
        public Cartuchera1()
        {
            this.utiles = new List<IAcciones>();
        }
        #endregion

        #region Metodos
        public bool ProbarElementos()
        {
            bool retorno = true;
            //EscrituraWrapper eW;

            foreach(IAcciones item in this.utiles)
            {
                //if(item is Lapiz)
                //{
                //    ((IAcciones)item).Escribir("1");
                //}
                //else
                //{
                //    eW = item.Escribir("1");

                //    if (eW.texto != "1")
                //    {
                //        retorno = false;
                //        item.Recargar(1);
                //    }   
                //}

                if(item.UnidadesDeEscritura >= 1)
                {
                    item.UnidadesDeEscritura -= 1;
                }
                else if(item is Boligrafo && item.UnidadesDeEscritura < 1)
                {
                    retorno = false;
                    item.Recargar(5); 
                }
            }

            return retorno;
        }
        #endregion
    }
}
