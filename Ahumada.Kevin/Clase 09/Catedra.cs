using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09
{
    public class Catedra
    {
        #region Atributos

        List<Alumno> alumnos;

        #endregion

        #region Propiedades

        public List<Alumno> Alumnos { get { return this.alumnos; } }

        #endregion

        #region Constructores

        public Catedra()
        {
            alumnos = new List<Alumno>(); 
        }

        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Catedra c, Alumno a)
        {
            bool retorno = false;

            foreach(Alumno alumno in c.alumnos)
            {
                if (alumno == a)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c == a);
        }

        public static bool operator +(Catedra c, Alumno a)
        {
            bool retorno = false;

            if (c != a)
            {
                c.alumnos.Add(a);
                retorno = true;
            }

            return retorno;
        }

        public static int operator |(Catedra c, Alumno a)
        {
            return c.alumnos.IndexOf(a);
        }

        public static bool operator -(Catedra c, Alumno a)
        {
            bool retorno = false;

            if(c == a)
            {
                c.alumnos.RemoveAt(c | a);
                retorno = true;
            }

            return retorno;
        }

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            string listaAlumnos = "";

            foreach(Alumno alumno in this.alumnos)
            {
                listaAlumnos += alumno + "\n";
            }

            return listaAlumnos;
        }

        #endregion
    }
}
