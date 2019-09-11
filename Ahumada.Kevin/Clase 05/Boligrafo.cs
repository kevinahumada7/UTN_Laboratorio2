using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05
{
    class Tinta
    {
        ConsoleColor color;
        EtipoTinta tipoTinta;

        public Tinta()
        {
            this.color = ConsoleColor.Red;
            this.tipoTinta = EtipoTinta.Comun;
        }

        public Tinta(ConsoleColor color):this()
        {
            this.color = color;
        }

        public Tinta(ConsoleColor color, EtipoTinta tipo):this(color)
        {
            this.tipoTinta = tipo;
        }
        //------------------------------------------------------------------------------//
        string Mostrar()
        {
            return "Color: " + this.color + " - Tipo: " + this.tipoTinta;
        }
        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }
        //------------------------------------------------------------------------------//
        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }
        //------------------------------------------------------------------------------//
        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        {
            bool retorno = false;

            if(!Object.Equals(tinta1,null) && !Object.Equals(tinta2,null))//Si ambas tintas son distintas de null
            {
                if(tinta1.color == tinta2.color && tinta1.tipoTinta == tinta2.tipoTinta)
                {
                    retorno = true;
                }
            }
            else if(Object.Equals(tinta1, null) && Object.Equals(tinta2, null))//Si ambas tintas son null
            {
                if (tinta1.color == tinta2.color && tinta1.tipoTinta == tinta2.tipoTinta)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }
        //------------------------------------------------------------------------------//
        public static bool operator ==(Tinta tinta, ConsoleColor color)
        {
            bool retorno = false;

            if(tinta.color == color)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Tinta tinta, ConsoleColor color)
        {
            return !(tinta == color);
        }
        //------------------------------------------------------------------------------//
    }

    class Pluma
    {
        string marca;
        Tinta tinta;
        int cantidadTinta;

        public Pluma()
        {
            this.marca = "Sin Marca";
            this.tinta = null;
            this.cantidadTinta = 0;
        }
        public Pluma(Tinta tinta):this()
        {
            this.tinta = tinta;
        }
        public Pluma(Tinta tinta, string marca):this(tinta)
        {
            this.marca = marca;
        }
        public Pluma(Tinta tinta, string marca, int cantidad):this(tinta,marca)
        {
            this.cantidadTinta = cantidad;
        }

        //------------------------------------------------------------------------------//
        string Mostrar()
        {
            return "Marca: " + this.marca + " " + Tinta.Mostrar(this.tinta) + " Cantidad de Tinta: " + this.cantidadTinta + "%";
        }
        public static string Mostrar(Pluma pluma)
        {
            return pluma.Mostrar();
        }
        //------------------------------------------------------------------------------//
        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }
        //------------------------------------------------------------------------------//
        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return (pluma.tinta == tinta);
        }
        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma.tinta == tinta);
        }
        //------------------------------------------------------------------------------//
        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (pluma.tinta == tinta && pluma.cantidadTinta < 100)
            {
                pluma.cantidadTinta++;
                return pluma;
            }
            return pluma;
        }
    }
}
