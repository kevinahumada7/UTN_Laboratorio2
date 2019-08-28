using System;

namespace Clase_4.Entidades
{
    public class Cosa
    {
        int entero;
        string cadena;
        DateTime fecha;

        public string Mostrar()
        {
            return entero.ToString().PadLeft(4,'0')+" - "+cadena.PadRight(20)+" - "+fecha.ToString();
        }

        public void EstablecerValor(int datNumero)
        {
            this.entero = datNumero;
        }

        public void EstablecerValor(string datCadena)
        {
            this.cadena = datCadena;
        }

        public void EstablecerValor(DateTime datFecha)
        {
            this.fecha = datFecha;
        }

        public Cosa()
        {
            this.entero = -1;
            this.cadena = "Default";
            this.fecha = DateTime.Today;
        }

        public Cosa(DateTime dateTime):this()
        {
            this.fecha = dateTime;
        }

        public Cosa(string dateCadena):this()
        {
            this.cadena = dateCadena;
        }

        public Cosa(int dateNumero):this()
        {
            this.entero = dateNumero;

        }

        public Cosa(int dateNum, string dateCad, DateTime dateTime)
        {
            this.entero = dateNum;
            this.cadena = dateCad;
            this.fecha = dateTime;
        }
    }
}
