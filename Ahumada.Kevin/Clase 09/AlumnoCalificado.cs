using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09
{
    public class AlumnoCalificado : Alumno
    {
        #region Atributos

        protected double nota;

        #endregion

        #region Propiedades

        public double Nota { get { return this.nota; } }

        #endregion

        #region Constructores

        public AlumnoCalificado(Alumno a, double nota) : base(a.Apellido, a.Nombre, a.Legajo, a.Examen)
        {
            this.nota = nota;
        }

        public AlumnoCalificado(string apellido, string nombre, int legajo, ETipoExamen examen, double nota) : this(new Alumno(apellido, nombre, legajo, examen), nota) { }

        #endregion

        #region Métodos

        public override string Mostrar()
        {
            return base.Mostrar()+" Nota: "+this.nota;
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
