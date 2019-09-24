using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06
{
    public class Paleta
    {
        public Tempera[] colores;
        private int cantColores;

        private Paleta(int cantColores)
        {
            this.colores = new Tempera[cantColores];
            this.cantColores = cantColores;
        }

        private Paleta() : this(5) { } //Inicia con 5 colores

        public static implicit operator Paleta(int cantColores)
        {
            if (cantColores > 0)
            {
                Paleta paleta = new Paleta(cantColores);
                return paleta;
            }
            else
            {
                Paleta paleta = new Paleta();
                return paleta;
            }
        }

        private string Mostrar()
        {
            string retorno = "NullObject";

            if (!this.Equals(null))
            {
                if (this.colores.Count() > 0)
                {
                    for (int i = 0; i < this.cantColores; i++)
                    {
                        if(!Object.Equals(this.colores[i],null))
                        {
                            retorno = this.colores[i] + "\n";
                        }
                    }
                }
            }

            return retorno;
        }

        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();
        }

        private int buscarLibre()
        {
            int index = -1;

            for (int i = 0; i < this.cantColores; i++)
            {
                if(Object.Equals(this.colores[i],null))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool retorno = false;

            if (!Object.Equals(paleta,null))
            {
                for (int i = 0; i < paleta.cantColores; i++)
                {
                    if(!Object.Equals(paleta.colores[i],null))
                    {
                        if (paleta.colores[i] == tempera)
                        {
                            retorno = true;
                            break;
                        }
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            if (paleta == tempera)
            {
                for (int i = 0; i < paleta.cantColores; i++)
                {
                    if(paleta.colores[i] == tempera)
                    {
                        paleta.colores[i] += tempera;
                        break;
                    }
                }
            }
            else
            {
                int index = paleta.buscarLibre();

                if(index != -1)
                {
                    paleta.colores[index] = tempera;
                }
            }

            return paleta;
        }

        public static int operator |(Paleta paleta, Tempera tempera)
        {
            int retorno = -1;

            if(!paleta.Equals(null))
            {
                for(int i=0; i<paleta.cantColores; i++)
                {
                    if(paleta.colores[i] == tempera)
                    {
                        retorno = i;
                        break;
                    }
                }
            }

            return retorno;
        }

        //INDEXADOR
        public Tempera this[int index]
        {
            get { return this.colores[index]; }
            set { this.colores[index] = value; }
        }
    }
}
