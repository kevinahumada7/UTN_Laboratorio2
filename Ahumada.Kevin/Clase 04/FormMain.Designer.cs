namespace Clase_04
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lst_Log = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 306);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "EDAD";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Usuario.Location = new System.Drawing.Point(100, 6);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Usuario.MaxLength = 51;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(265, 29);
            this.txt_Usuario.TabIndex = 3;
            this.txt_Usuario.TabStop = false;
            this.txt_Usuario.Text = "Ingresar Usuario";
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Usuario.Click += new System.EventHandler(this.Txt_Usuario_Click);
            this.txt_Usuario.TextChanged += new System.EventHandler(this.Txt_Usuario_TextChanged);
            // 
            // txt_Edad
            // 
            this.txt_Edad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Edad.Location = new System.Drawing.Point(100, 45);
            this.txt_Edad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Edad.MaxLength = 51;
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(265, 29);
            this.txt_Edad.TabIndex = 4;
            this.txt_Edad.TabStop = false;
            this.txt_Edad.Text = "Ingresar Edad";
            this.txt_Edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Edad.Click += new System.EventHandler(this.Txt_Edad_Click);
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Fecha.Location = new System.Drawing.Point(100, 84);
            this.txt_Fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Fecha.MaxLength = 51;
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(265, 29);
            this.txt_Fecha.TabIndex = 5;
            this.txt_Fecha.TabStop = false;
            this.txt_Fecha.Text = "Ingresar Fecha";
            this.txt_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Fecha.Click += new System.EventHandler(this.Txt_Fecha_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lst_Log);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 185);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 121);
            this.panel3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 36);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Crear Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 36);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "Auto Log";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 2);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(93, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 2);
            this.panel5.TabIndex = 4;
            // 
            // lst_Log
            // 
            this.lst_Log.FormattingEnabled = true;
            this.lst_Log.ItemHeight = 21;
            this.lst_Log.Location = new System.Drawing.Point(4, 49);
            this.lst_Log.Name = "lst_Log";
            this.lst_Log.Size = new System.Drawing.Size(368, 130);
            this.lst_Log.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(375, 306);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lst_Log;
    }
}

