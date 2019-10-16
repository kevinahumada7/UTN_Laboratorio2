using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14.Entidades
{
    public class Deposito<T>
    {
        List<T> _lista;
        int _cantidadMaxima;

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._cantidadMaxima = capacidad;
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            if (d._lista.Count <= d._cantidadMaxima)
            {
                d._lista.Add(a);
                return true;
            }
            return false;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            int indice;
            if ((indice = d.GetIndice(a)) != -1)
            {
                d._lista.RemoveAt(indice);
                return true;
            }
            return false;
        }

        private int GetIndice(T a)
        {
            int indice = 0;
            int retorno = -1;

            foreach (T t in this._lista)
            {
                if (Object.Equals(t, a))
                {
                    retorno = indice;
                    break;
                }
                indice++;
            }

            return retorno;
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string retorno = "Lista de "+ typeof(T).Name +"- Capacidad: " + this._cantidadMaxima + "\n\n";

            foreach (T a in this._lista)
            {
                retorno += a.ToString() + "\n";
            }

            return retorno;
        }
    }
}
