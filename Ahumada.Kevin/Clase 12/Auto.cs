using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12
{
    class Auto
    {
        private string _color;
        private string _marca;

        public string Color { get { return this._color; } }

        public string Marca { get { return this._marca; } }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            if(Object.Equals(a.Marca,b.Marca) && Object.Equals(a.Color,b.Color))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if(obj is Auto && this == (Auto)obj)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "Marca: " + this.Marca + " Color: " + this.Color;
        }
    }
}
