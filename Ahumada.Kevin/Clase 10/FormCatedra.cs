using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_09;

namespace Clase_10
{
    public partial class FormCatedra : Form
    {
        private Catedra catedra = new Catedra();
        private List<AlumnoCalificado> alumnosCalificados = new List<AlumnoCalificado>();

        public FormCatedra()
        {
            InitializeComponent();

            foreach(ETipoOrdenamiento ordenamiento in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                cbo_Ordenamiento.Items.Add(ordenamiento);
            }
            cbo_Ordenamiento.SelectedIndex = 0;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            FormAlumno frmAlumno = new FormAlumno();
            frmAlumno.ShowDialog();

            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                if (catedra + frmAlumno.Alumno)
                {
                    ActualizarListadoAlumnos(this.catedra, cbo_Ordenamiento.SelectedIndex);
                }
            }
        }

        private void Cbo_Ordenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListadoAlumnos(this.catedra, cbo_Ordenamiento.SelectedIndex);
        }

        private void ActualizarListadoAlumnos(Catedra catedra, int ordenamiento)
        {
            switch(ordenamiento)
            {
                case 0:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    break;

                case 1:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    break;

                case 2:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    break;

                case 3:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    break;
            }

            this.lst_Alumnos.Items.Clear();

            foreach(Alumno alumno in catedra.Alumnos)
            {
                lst_Alumnos.Items.Add(alumno);
            }

            this.lst_AlumnosCalificados.Items.Clear();

            foreach(AlumnoCalificado alumno in alumnosCalificados)
            {
                lst_AlumnosCalificados.Items.Add(alumno);
            }
        }

    }
}
