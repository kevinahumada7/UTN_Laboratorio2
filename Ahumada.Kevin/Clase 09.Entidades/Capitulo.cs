using System;

namespace Clase_09.Entidades
{
    public class Capitulo
    {
        int numero;
        string titulo;
        int paginas;
        static Random generadorDeNumeros;
        static Random generadorDePaginas;

        public int getNumero
        {
            get { return this.numero; }
        }

        public string getTitulo
        {
            get { return this.titulo; }
        }

        public int getPaginas
        {
            get { return this.paginas; }
        }


        static Capitulo()
        {
            Capitulo.generadorDeNumeros = new Random();
            Capitulo.generadorDePaginas = new Random();
        }

        private Capitulo(int numero, string titulo, int paginas)
        {
            this.numero = numero;
            this.titulo = titulo;
            this.paginas = paginas;
        }

        public static implicit operator Capitulo(string titulo)
        {
            Capitulo capitulo = new Capitulo(Capitulo.generadorDeNumeros.Next(1, 65), titulo, Capitulo.generadorDePaginas.Next(15, 233));

            return capitulo;
        }

        public static bool operator ==(Capitulo cap1, Capitulo cap2)
        {
            if(cap1.numero == cap2.numero && cap1.titulo == cap2.titulo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Capitulo cap1, Capitulo cap2)
        {
            return !(cap1 == cap2);
        }
    }
}
