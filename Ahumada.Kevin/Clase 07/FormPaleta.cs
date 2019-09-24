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
    public partial class FormPaleta : Form
    {
        Paleta paleta;

        public FormPaleta()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
            this.grp_Paleta.Visible = false;
            this.temperaToolStripMenuItem.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void CrearPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.paleta = 5;
            this.crearPaletaToolStripMenuItem.Enabled = false;
            this.temperaToolStripMenuItem.Enabled = true;
            this.grp_Paleta.Visible = true;
        }

        private void TemperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTempera frmTemp = new FormTempera();
            frmTemp.ShowDialog();
            
            if(DialogResult.OK == frmTemp.DialogResult)
            {
                paleta += frmTemp.GetTempera;
                MostrarPaleta();
            }
            
        }
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if(this.lst_Paleta.SelectedIndex >= 0)
            {
                FormTempera frmTemp = new FormTempera(paleta[lst_Paleta.SelectedIndex]);
                frmTemp.ShowDialog();

                if(DialogResult.OK == frmTemp.DialogResult)
                {
                    paleta += frmTemp.GetTempera;
                    MostrarPaleta();
                }
            }
            else
            {
                this.TemperaToolStripMenuItem_Click(sender, e);
            }
        }

        private void MostrarPaleta()
        {
            lst_Paleta.Items.Clear();
            
            foreach(Tempera temp in paleta.colores)
            {
                if(!Object.Equals(temp,null))
                {
                    lst_Paleta.Items.Add((string)temp);
                }
            }
        }
    }
}
