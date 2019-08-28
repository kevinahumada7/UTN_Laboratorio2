using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_4.Entidades;

namespace Clase_04.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Crear_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            string cadena = textBox2.Text;
            DateTime fecha = Convert.ToDateTime(textBox3.Text);

            Cosa coso = new Cosa(numero, cadena, fecha);

            MessageBox.Show(coso.Mostrar());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
