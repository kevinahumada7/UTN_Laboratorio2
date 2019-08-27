using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_03
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public int dni;
        

        public Persona()
        {
            this.nombre = "Default";
            this.apellido = "Default";
        }

        public string Mostrar()
        {
            return this.nombre + " " + this.apellido + " - " + this.dni.ToString();
        }
    }
}
