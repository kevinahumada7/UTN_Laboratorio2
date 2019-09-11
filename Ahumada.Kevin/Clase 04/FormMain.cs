using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_04
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Registro usuario1 = new Registro("Kevin7", 21, new DateTime(2018,12,9,17,45,00));

        private void Txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt_Usuario_Click(object sender, EventArgs e)
        {
            txt_Usuario.Clear();
            txt_Usuario.ForeColor = Color.Black;
        }

        private void Txt_Edad_Click(object sender, EventArgs e)
        {
            txt_Edad.Clear();
            txt_Edad.ForeColor = Color.Black;
        }

        private void Txt_Fecha_Click(object sender, EventArgs e)
        {
            txt_Fecha.Clear();
            txt_Fecha.ForeColor = Color.Black;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Registro usuario2 = new Registro(txt_Usuario.Text, int.Parse(txt_Edad.Text), DateTime.Parse(txt_Fecha.Text));

            lst_Log.Items.Add(usuario2.Mostrar());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txt_Usuario.Text = usuario1.usuario;
            txt_Edad.Text = usuario1.edad.ToString();
            txt_Fecha.Text = usuario1.datoRegistro.ToString();
        }
    }
}
