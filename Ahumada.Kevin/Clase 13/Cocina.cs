using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13
{
    public class Cocina
    {
        int _codigo;
        bool _esIndustrial;
        double _precio;

        public int Codigo { get { return this._codigo; } }

        public bool EsIndustrial { get { return this._esIndustrial; } }

        public double Precio { get { return this._precio; } }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            if(Object.Equals(a.Codigo,b.Codigo))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if(obj is Cocina && this == (Cocina)obj)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Codigo: " + this._codigo.ToString().PadLeft(4, '0') + " - Precio: " + this._precio + "- Industrial: " + this._esIndustrial;
        }
    }
}
