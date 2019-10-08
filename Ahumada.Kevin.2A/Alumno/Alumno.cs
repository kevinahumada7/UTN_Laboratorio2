using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        string _apellido;
        int _legajo;
        string _nombre;
        float _nota;

        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }

        public int Legajo { get { return this._legajo; } set { this._legajo = value; } }

        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public float Nota { get { return this._nota; } set { this._nota = value; } }

        public Alumno(int legajo, string nombre, string apellido)
        {
            this._legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
        }

        private string Mostrar()
        {
            return this._legajo.ToString().PadLeft(5,'0') + " - " + this._apellido + ", " + this._nombre + " - Nota: " + this._nota+"\n";
        }

        public static string Mostrar(Alumno alumno)
        {
            return alumno.Mostrar();
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            return Object.Equals(a1.Legajo, a2.Legajo);
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

    }
}
