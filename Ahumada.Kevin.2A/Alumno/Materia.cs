using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        List<Alumno> _alumnos;
        EMateria _nombre;
        static Random _notaParaUnAlumno;

        public List<Alumno> Alumnos { get { return this._alumnos; } set { this._alumnos = value; } }

        public EMateria Nombre { get { return this._nombre; } set { this._nombre = value; } }

        private Materia()
        {
            this._alumnos = new List<Alumno>();
        }

        private Materia(EMateria nombre):this()
        {
            this._nombre = nombre;
        }

        static Materia()
        {
            Materia._notaParaUnAlumno = new Random();
        }

        private string Mostrar()
        {
            string retorno = "Materia: " + this._nombre + "\n\n";

            foreach(Alumno a in this._alumnos)
            {
                retorno += Alumno.Mostrar(a);
            }

            return retorno;
        }

        public void CalificarAlumnos()
        {
            foreach(Alumno a in this._alumnos)
            {
                a.Nota = Materia._notaParaUnAlumno.Next(0, 10);
            }
        }

        public static implicit operator Materia(EMateria nombre)
        {
            Materia materia = new Materia(nombre);
            return materia;
        }

        public static implicit operator float(Materia m)
        {
            float acumulador = 0;

            foreach(Alumno a in m._alumnos)
            {
                acumulador += a.Nota;
            }

            return acumulador / m._alumnos.Count;
        }

        public static explicit operator string(Materia materia)
        {
            return materia.Mostrar();
        }

        public static bool operator ==(Materia m, Alumno a)
        {
            foreach(Alumno alum in m._alumnos)
            {
                if(alum == a)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }

        public static Materia operator +(Materia m, Alumno a)
        {
            if (m != a)
            {
                m._alumnos.Add(a);
            }

            return m;
        }

        public static Materia operator -(Materia m, Alumno a)
        {
            if (m == a)
            {
                m._alumnos.Remove(a);
            }

            return m;
        }
    }
}
