﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15
{
    class Contabilidad<T, U> where U : new()
    {
        List<T> egresos;
        List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c.egresos.Add(egreso);

            return c;


        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);

            return c;
        }
    }
}
