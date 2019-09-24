using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06
{
    public class Tempera
    {
        private string marca;
        private ConsoleColor color;
        private int cantidad;

        public Tempera(string marca, ConsoleColor color, int cantidad)
        {
            this.marca = marca;
            this.color = color;
            this.cantidad = cantidad;
        }

        public string GetMarca { get { return this.marca; } }

        public ConsoleColor GetColor { get { return this.color; } }

        public int GetCantidad { get { return this.cantidad; } }

        string Mostrar()
        {
            return "Marca: " + this.marca + " Color: " + this.color + " Cantidad: " + this.cantidad;
        }

        public static implicit operator string(Tempera tempera)
        {
            return tempera.Mostrar();
        }

        public static bool operator ==(Tempera temp1, Tempera temp2)
        {
            bool retorno = false;

            if(!temp1.Equals(null) && !temp2.Equals(null))
            {
                if(temp1.marca == temp2.marca && temp1.color == temp2.color)
                {
                    retorno = true;
                }
            }
            else if(temp1.Equals(null) && temp2.Equals(null))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Tempera temp1, Tempera temp2)
        {
            return !(temp1 == temp2);
        }

        public static Tempera operator +(Tempera temp1, int agregarTemp)
        {
            if(!temp1.Equals(null))
            {
                temp1.cantidad += agregarTemp;
            }

            return temp1;
        }

        public static Tempera operator +(Tempera temp1, Tempera temp2)
        {
            if(temp1 == temp2)
            {
                temp1 += temp2.cantidad;
            }

            return temp1;
        }
    }
}
