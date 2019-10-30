using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        private List<Persona> lista;

        public frmVisorPersona()
        {
            InitializeComponent();
            this.lista = new List<Persona>();
        }

        public frmVisorPersona(List<Persona> l):this()
        {
            this.lista = l;
        }

        public List<Persona> ListaFrm { get { return this.lista; } }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            if(frm.DialogResult== DialogResult.OK)
            {
                this.lista.Add(frm.Persona);
            }

            foreach(Persona p in this.lista)
            {
                this.lstVisor.Items.Add(p);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            this.lista.RemoveAt(this.lstVisor.SelectedIndex);
            this.lstVisor.Items.Remove(this.lstVisor.SelectedItem);
            
        }
    }
}
