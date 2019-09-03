using System;

namespace Clase_05.Entidades
{
    public class Tinta
    {
        ConsoleColor color;
        EtipoTinta tipo;

        public Tinta()
        {
            this.color = ConsoleColor.Blue;
            this.tipo = EtipoTinta.comun;
        }

        public Tinta(ConsoleColor color):this()
        {
            this.color = color;
        }

        public Tinta(ConsoleColor color, EtipoTinta tipo) : this(color)
        {
            this.tipo = tipo;
        }

        private string Mostrar()
        {
            return "Color: "+this.color+" - Tipo: "+this.tipo;
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        {
            if (!Object.Equals(tinta1,null) && !Object.Equals(tinta2, null))
            {
                if (tinta1.color == tinta2.color && tinta1.tipo == tinta2.tipo)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if(Object.Equals(tinta1, null) && Object.Equals(tinta2, null))
            {
                if (tinta1.color == tinta2.color && tinta1.tipo == tinta2.tipo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }

        public static bool operator ==(Tinta tinta, ConsoleColor color)
        {
            if(tinta.color==color)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tinta tinta, ConsoleColor color)
        {
            return !(tinta == color);
        }

        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }
    }   

    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "sin marca";
            this.tinta = null;
            this.cantidad = 0;
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
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            return "Marca: " + this.marca + " " + Tinta.Mostrar(this.tinta) + " Cantidad: " + this.cantidad;
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Pluma pluma,Tinta tinta)
        {
            return (pluma.tinta == tinta);
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma.tinta == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if( pluma.tinta == tinta && pluma.cantidad<100)
            {
                pluma.cantidad++;
                return pluma;
            }

               return pluma;
            
        }
    }
}
