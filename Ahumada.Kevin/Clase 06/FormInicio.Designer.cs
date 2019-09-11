namespace Clase_06
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_Paleta = new System.Windows.Forms.GroupBox();
            this.listBox_Paleta = new System.Windows.Forms.ListBox();
            this.btn_Mas = new System.Windows.Forms.Button();
            this.btn_Menos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbx_Paleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paletaToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // paletaToolStripMenuItem
            // 
            this.paletaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaToolStripMenuItem});
            this.paletaToolStripMenuItem.Name = "paletaToolStripMenuItem";
            this.paletaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.paletaToolStripMenuItem.Text = "Paleta";
            this.paletaToolStripMenuItem.Click += new System.EventHandler(this.paletaToolStripMenuItem_Click);
            // 
            // temperaToolStripMenuItem
            // 
            this.temperaToolStripMenuItem.Name = "temperaToolStripMenuItem";
            this.temperaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.temperaToolStripMenuItem.Text = "Tempera";
            this.temperaToolStripMenuItem.Click += new System.EventHandler(this.temperaToolStripMenuItem_Click);
            // 
            // gbx_Paleta
            // 
            this.gbx_Paleta.BackColor = System.Drawing.SystemColors.Control;
            this.gbx_Paleta.Controls.Add(this.listBox_Paleta);
            this.gbx_Paleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_Paleta.Location = new System.Drawing.Point(12, 27);
            this.gbx_Paleta.Name = "gbx_Paleta";
            this.gbx_Paleta.Size = new System.Drawing.Size(776, 186);
            this.gbx_Paleta.TabIndex = 1;
            this.gbx_Paleta.TabStop = false;
            this.gbx_Paleta.Text = "Paleta";
            // 
            // listBox_Paleta
            // 
            this.listBox_Paleta.FormattingEnabled = true;
            this.listBox_Paleta.Location = new System.Drawing.Point(7, 20);
            this.listBox_Paleta.Name = "listBox_Paleta";
            this.listBox_Paleta.Size = new System.Drawing.Size(763, 160);
            this.listBox_Paleta.TabIndex = 0;
            // 
            // btn_Mas
            // 
            this.btn_Mas.BackColor = System.Drawing.Color.Silver;
            this.btn_Mas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Mas.Location = new System.Drawing.Point(12, 213);
            this.btn_Mas.Name = "btn_Mas";
            this.btn_Mas.Size = new System.Drawing.Size(385, 33);
            this.btn_Mas.TabIndex = 2;
            this.btn_Mas.Text = "+";
            this.btn_Mas.UseVisualStyleBackColor = false;
            // 
            // btn_Menos
            // 
            this.btn_Menos.BackColor = System.Drawing.Color.Brown;
            this.btn_Menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Menos.Location = new System.Drawing.Point(403, 213);
            this.btn_Menos.Name = "btn_Menos";
            this.btn_Menos.Size = new System.Drawing.Size(385, 33);
            this.btn_Menos.TabIndex = 3;
            this.btn_Menos.Text = "-";
            this.btn_Menos.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Menos);
            this.Controls.Add(this.btn_Mas);
            this.Controls.Add(this.gbx_Paleta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInicio";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbx_Paleta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbx_Paleta;
        private System.Windows.Forms.ListBox listBox_Paleta;
        private System.Windows.Forms.Button btn_Mas;
        private System.Windows.Forms.Button btn_Menos;
        private System.Windows.Forms.Button button1;
    }
}

