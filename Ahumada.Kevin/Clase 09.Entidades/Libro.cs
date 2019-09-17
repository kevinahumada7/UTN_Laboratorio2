using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_09.Entidades
{
    public class Libro
    {
        string titulo;
        string autor;
        List<Capitulo> capitulos;

        public string getTitulo
        {
            get { return this.titulo; }
        }

        public string getAutor
        {
            get { return this.autor; }
        }

        public Libro(string tituloLibro, string autor)
        {
            this.titulo = tituloLibro;
            this.autor = autor;
            this.capitulos = new List<Capitulo>();
        }

        public int CantidadDePaginas
        {
            get
            {
                int cant=0;

                foreach(Capitulo cap in this.capitulos)
                {
                    cant += cap.getPaginas;
                }

                return cant;
            }
        }

        public int CantidadDeCapitulos
        {
            get
            {
                int cant = 0;

                foreach(Capitulo cap in this.capitulos)
                {
                    cant++;
                }
                
                return cant;
            }
        }

        public Capitulo this[int index]
        {
            get
            {
                if(index < 0 || index > this.capitulos.Count)
                {
                    return null;
                }
                else
                {
                    return this.capitulos[index];
                }
            }

            set
            {
                if( index < 0 ||  index > (this.capitulos.Count)+1)
                {
                    this.capitulos.Add(value);
                }
                else
                {
                    this.capitulos.Insert(index, value);
                }
            }
        }
    }
}
