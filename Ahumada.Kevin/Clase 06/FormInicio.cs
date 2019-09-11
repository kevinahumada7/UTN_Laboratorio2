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
    public partial class FormInicio : Form
    {
        Paleta paleta = 5;

        public FormInicio()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            gbx_Paleta.Visible = false;
            
        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //paletaToolStripMenuItem.Enabled = false;
            gbx_Paleta.Visible = true;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTemperas formTemp = new FormTemperas();
            //formTemp.MdiParent = this;
            formTemp.ShowDialog();

            if (formTemp.DialogResult == DialogResult.OK)
            {
                paleta += formTemp.MiTempera;
                listBox_Paleta.Items.Add((string)formTemp.MiTempera);
            }
        }
    }
}
