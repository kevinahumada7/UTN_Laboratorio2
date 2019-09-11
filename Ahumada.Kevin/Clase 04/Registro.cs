using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    class Registro
    {
        static int legajo;
        public string usuario;
        public int edad;
        public DateTime datoRegistro;

        static Registro()
        {
            Registro.legajo = 1;
        }

        public Registro(string usuario, int edad, DateTime dateTime)
        {
            this.usuario = usuario;
            this.edad = edad;
            this.datoRegistro = dateTime;
            Registro.legajo++;
        }

        public string Mostrar()
        {
            return Registro.legajo+" - "+this.usuario + " " + this.edad + " años - " + this.datoRegistro+"\n";
        }
    }
}
