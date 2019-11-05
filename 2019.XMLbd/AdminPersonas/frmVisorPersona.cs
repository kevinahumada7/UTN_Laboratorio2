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
using System.Data.SqlClient;

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

            foreach (Persona p in this.lista)
            {
                this.lstVisor.Items.Add(p);
            }
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

            this.lstVisor.Items.Clear();

            foreach(Persona p in this.lista)
            {
                this.lstVisor.Items.Add(p);
            }

            try
            {
                SqlConnection sqlConnection= new SqlConnection(Properties.Settings.Default.conexion);
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "INSERT INTO Personas(nombre,apellido,edad) VALUES('Pepe','Argento',31)";
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(this.lstVisor.SelectedIndex != -1)
            {
                this.lista.RemoveAt(this.lstVisor.SelectedIndex);

                this.lstVisor.Items.Clear();

                foreach (Persona p in this.lista)
                {
                    this.lstVisor.Items.Add(p);
                }
            } 
        }
    }
}
