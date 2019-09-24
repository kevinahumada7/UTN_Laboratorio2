using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06;

namespace Clase_07
{
    public partial class FormTempera : Form
    {
        Tempera tempera;
        public FormTempera()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            foreach(ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cbo_Color.Items.Add(color);
            }
            this.cbo_Color.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbo_Color.SelectedItem = ConsoleColor.Red;
        }

        public FormTempera(Tempera tempera):this()
        {
            this.txt_Marca.Text = tempera.GetMarca;
            this.txt_Marca.Enabled = false;
            this.lbl_Cantidad.Text = "Agregar Cantidad";
            this.cbo_Color.SelectedItem = tempera.GetColor;
            this.cbo_Color.Enabled = false;
            this.btn_Aceptar.Text = "Agregar";

        }

        public Tempera GetTempera { get { return this.tempera; } }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            string marca = txt_Marca.Text;
            ConsoleColor color = (ConsoleColor)cbo_Color.SelectedItem;
            int cantidad;

            if (int.TryParse(txt_Cantidad.Text, out cantidad)) { }
            else { cantidad = 0; }

            this.tempera = new Tempera(marca, color, cantidad);

            this.DialogResult = DialogResult.OK;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
