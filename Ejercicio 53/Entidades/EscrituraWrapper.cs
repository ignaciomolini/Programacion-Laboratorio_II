﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EscrituraWrapper
    {
        #region Atributos
        public ConsoleColor color;
        public string texto;
        #endregion

        #region Constructores
        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.color = color;
            this.texto = texto;
        }
        #endregion
    }
}
