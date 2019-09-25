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
    public partial class FormAlumno : Form
    {
        private Alumno alumno;

        public Alumno Alumno { get { return this.alumno; } }

        public FormAlumno()
        {
            InitializeComponent();
            
            foreach(ETipoExamen tipoExamen in Enum.GetValues(typeof(ETipoExamen)))
            {
                cbo_Examen.Items.Add(tipoExamen);
                cbo_Examen.SelectedItem = ETipoExamen.Final;
            }
        }

        protected virtual void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            int legajo;
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            ETipoExamen examen = (ETipoExamen)cbo_Examen.SelectedItem;

            if (int.TryParse(txt_Legajo.Text, out legajo) && nombre != "" && apellido != "" && legajo > 0)
            {
                alumno = new Alumno(apellido, nombre, legajo, examen);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Algo anda mal, revisa los datos cargados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
