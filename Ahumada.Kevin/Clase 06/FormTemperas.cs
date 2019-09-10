using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_06
{
    public partial class FormTemperas : Form
    {
        Tempera tempera;

        public FormTemperas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.cbx_Color.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cbx_Color.Items.Add(c);
            }
            this.cbx_Color.SelectedItem = ConsoleColor.Magenta;
        }

        private Tempera temp; //propfull 'tab'

        public Tempera MiTempera
        {
            get { return this.tempera; }
           // set { temp = value; }
        }


        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.tempera = new Tempera((ConsoleColor)this.cbx_Color.SelectedItem,txtb_Marca.Text,int.Parse(txtb_Cantidad.Text));
            MessageBox.Show(temp);
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
