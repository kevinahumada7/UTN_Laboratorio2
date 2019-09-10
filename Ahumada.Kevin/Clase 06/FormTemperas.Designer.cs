namespace Clase_06
{
    partial class FormTemperas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txtb_Marca = new System.Windows.Forms.TextBox();
            this.txtb_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.cbx_Color = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Aceptar.Location = new System.Drawing.Point(12, 260);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(258, 33);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Brown;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancelar.Location = new System.Drawing.Point(263, 260);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(258, 33);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(12, 14);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_Marca.TabIndex = 2;
            this.lbl_Marca.Text = "Marca";
            // 
            // txtb_Marca
            // 
            this.txtb_Marca.Location = new System.Drawing.Point(15, 30);
            this.txtb_Marca.Name = "txtb_Marca";
            this.txtb_Marca.Size = new System.Drawing.Size(508, 20);
            this.txtb_Marca.TabIndex = 3;
            // 
            // txtb_Cantidad
            // 
            this.txtb_Cantidad.Location = new System.Drawing.Point(15, 69);
            this.txtb_Cantidad.Name = "txtb_Cantidad";
            this.txtb_Cantidad.Size = new System.Drawing.Size(508, 20);
            this.txtb_Cantidad.TabIndex = 5;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(12, 53);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_Cantidad.TabIndex = 4;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(12, 92);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(31, 13);
            this.lbl_Color.TabIndex = 6;
            this.lbl_Color.Text = "Color";
            // 
            // cbx_Color
            // 
            this.cbx_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Color.FormattingEnabled = true;
            this.cbx_Color.Location = new System.Drawing.Point(15, 109);
            this.cbx_Color.Name = "cbx_Color";
            this.cbx_Color.Size = new System.Drawing.Size(508, 21);
            this.cbx_Color.TabIndex = 7;
            // 
            // FormTemperas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 305);
            this.Controls.Add(this.cbx_Color);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.txtb_Cantidad);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.txtb_Marca);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTemperas";
            this.Text = "FormTemperas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.TextBox txtb_Marca;
        private System.Windows.Forms.TextBox txtb_Cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.ComboBox cbx_Color;
    }
}