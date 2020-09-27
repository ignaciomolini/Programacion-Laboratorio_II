﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException(string mensaje) : this(mensaje, null)
        {

        }

        public ArchivoIncorrectoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
