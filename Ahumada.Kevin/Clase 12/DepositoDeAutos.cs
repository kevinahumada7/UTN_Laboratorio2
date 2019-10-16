using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12
{
    class DepositoDeAutos
    {
        List<Auto> _lista;
        int _cantidadMaxima;

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._cantidadMaxima = capacidad;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            if(d._lista.Count < d._cantidadMaxima)
            {
                d._lista.Add(a);
                return true;
            }
            return false;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            int indice;
            if((indice= d.GetIndice(a)) != -1)
            {
                d._lista.RemoveAt(indice);
                return true;
            }
            return false;
        }

        private int GetIndice(Auto a)
        {
            int indice = 0;
            int retorno=-1;

            foreach(Auto auto in this._lista)
            {
                if(auto == a)
                {
                    retorno = indice;
                    break;
                }
                indice++;
            }

            return retorno;
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string retorno = "Lista de Autos - Capacidad: "+this._cantidadMaxima+"\n\n";

            foreach(Auto a in this._lista)
            {
                retorno += a.ToString() + "\n";
            }

            return retorno;
        }
    }
}
