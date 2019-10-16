using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13
{
    class DepositoDeCocinas
    {
        List<Cocina> _lista;
        int _cantidadMaxima;
        
        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._cantidadMaxima = capacidad;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            if (d._lista.Count <= d._cantidadMaxima)
            {
                d._lista.Add(c);
                return true;
            }
            return false;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            int indice;
            if ((indice = d.GetIndice(c)) != -1)
            {
                d._lista.RemoveAt(indice);
                return true;
            }
            return false;
        }

        private int GetIndice(Cocina c)
        {
            int indice = 0;
            int retorno = -1;

            foreach (Cocina cocina in this._lista)
            {
                if (cocina == c)
                {
                    retorno = indice;
                    break;
                }
                indice++;
            }

            return retorno;
        }

        public bool Agregar(Cocina c)
        {
            return this + c;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            string retorno = "Lista de Cocinas - Capacidad: " + this._cantidadMaxima + "\n\n";

            foreach (Cocina c in this._lista)
            {
                retorno += c.ToString() + "\n";
            }

            return retorno;
        }
    }
}
