using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09
{
    public class Alumno
    {
        #region Atributos

        protected int legajo;
        protected string apellido;
        protected string nombre;
        protected ETipoExamen examen;

        #endregion

        #region Propiedades

        public int Legajo { get { return this.legajo; } }
        public string Apellido { get { return this.apellido; } }
        public string Nombre { get { return this.nombre; } }
        public ETipoExamen Examen { get { return this.examen; } }

        #endregion

        #region Constructores

        public Alumno(string apellido, string nombre, int legajo, ETipoExamen examen)
        {
            this.legajo = legajo;
            this.apellido = apellido;
            this.nombre = nombre;
            this.examen = examen;
        }

        #endregion

        #region Métodos
        
        public virtual string Mostrar()
        {
            return "Legajo: " + this.legajo.ToString().PadLeft(4, '0') + " Apellido: " + this.apellido + " Nombre: " + this.nombre + " Examen: " + this.examen;
        }

        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {
            return string.Compare(a.apellido, b.apellido);
        }

        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return string.Compare(b.apellido, a.apellido);
        }

        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            int retorno = 0;

            if(a.legajo > b.legajo)
            {
                retorno = 1;
            }
            else if(a.legajo < b.legajo)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int OrdenarPorLegajoDesc(Alumno a, Alumno b)
        {
            return Alumno.OrdenarPorLegajoAsc(b, a);
        }

        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Alumno a, Alumno b)
        {
            bool retorno = false;

            if(Object.Equals(a,null) && Object.Equals(b, null))
            {
                retorno = true;
            }
            else if(!Object.Equals(a, null) && !Object.Equals(b, null))
            {
                if (a.legajo == b.legajo)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a == b);
        }

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}
