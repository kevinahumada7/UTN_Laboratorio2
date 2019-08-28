namespace Clase_04.WindowsForm
{
    partial class Form1
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
            this.label_Int = new System.Windows.Forms.Label();
            this.label_Cadena = new System.Windows.Forms.Label();
            this.label_Fecha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_Crear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Int
            // 
            this.label_Int.AutoSize = true;
            this.label_Int.Location = new System.Drawing.Point(9, 9);
            this.label_Int.Name = "label_Int";
            this.label_Int.Size = new System.Drawing.Size(38, 13);
            this.label_Int.TabIndex = 0;
            this.label_Int.Text = "Entero";
            // 
            // label_Cadena
            // 
            this.label_Cadena.AutoSize = true;
            this.label_Cadena.Location = new System.Drawing.Point(9, 44);
            this.label_Cadena.Name = "label_Cadena";
            this.label_Cadena.Size = new System.Drawing.Size(44, 13);
            this.label_Cadena.TabIndex = 1;
            this.label_Cadena.Text = "Cadena";
            // 
            // label_Fecha
            // 
            this.label_Fecha.AutoSize = true;
            this.label_Fecha.Location = new System.Drawing.Point(9, 79);
            this.label_Fecha.Name = "label_Fecha";
            this.label_Fecha.Size = new System.Drawing.Size(37, 13);
            this.label_Fecha.TabIndex = 2;
            this.label_Fecha.Text = "Fecha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(59, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button_Crear
            // 
            this.button_Crear.Location = new System.Drawing.Point(12, 235);
            this.button_Crear.Name = "button_Crear";
            this.button_Crear.Size = new System.Drawing.Size(261, 23);
            this.button_Crear.TabIndex = 6;
            this.button_Crear.Text = "Crear";
            this.button_Crear.UseVisualStyleBackColor = true;
            this.button_Crear.Click += new System.EventHandler(this.button_Crear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 270);
            this.Controls.Add(this.button_Crear);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Fecha);
            this.Controls.Add(this.label_Cadena);
            this.Controls.Add(this.label_Int);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Int;
        private System.Windows.Forms.Label label_Cadena;
        private System.Windows.Forms.Label label_Fecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_Crear;
    }
}

