﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15
{
    class Recibo : Documento
    {
        public Recibo(int numero) : base(numero) { }

        public Recibo() : this(0) { }
    }
}