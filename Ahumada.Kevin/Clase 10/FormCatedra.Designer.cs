namespace Clase_10
{
    partial class FormCatedra
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grp_Alumnos = new System.Windows.Forms.GroupBox();
            this.lst_Alumnos = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_Ordenamiento = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Calificar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.grp_AlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.lst_AlumnosCalificados = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grp_Alumnos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grp_AlumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grp_Alumnos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grp_AlumnosCalificados, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.04607F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.95393F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 531);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grp_Alumnos
            // 
            this.grp_Alumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Alumnos.Controls.Add(this.lst_Alumnos);
            this.grp_Alumnos.Controls.Add(this.panel1);
            this.grp_Alumnos.Controls.Add(this.tableLayoutPanel2);
            this.grp_Alumnos.Location = new System.Drawing.Point(8, 8);
            this.grp_Alumnos.Name = "grp_Alumnos";
            this.grp_Alumnos.Size = new System.Drawing.Size(798, 286);
            this.grp_Alumnos.TabIndex = 0;
            this.grp_Alumnos.TabStop = false;
            this.grp_Alumnos.Text = "Alumnos";
            // 
            // lst_Alumnos
            // 
            this.lst_Alumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Alumnos.FormattingEnabled = true;
            this.lst_Alumnos.ItemHeight = 17;
            this.lst_Alumnos.Location = new System.Drawing.Point(6, 65);
            this.lst_Alumnos.Name = "lst_Alumnos";
            this.lst_Alumnos.Size = new System.Drawing.Size(786, 174);
            this.lst_Alumnos.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbo_Ordenamiento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 40);
            this.panel1.TabIndex = 1;
            // 
            // cbo_Ordenamiento
            // 
            this.cbo_Ordenamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Ordenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Ordenamiento.FormattingEnabled = true;
            this.cbo_Ordenamiento.Location = new System.Drawing.Point(3, 3);
            this.cbo_Ordenamiento.Name = "cbo_Ordenamiento";
            this.cbo_Ordenamiento.Size = new System.Drawing.Size(786, 25);
            this.cbo_Ordenamiento.TabIndex = 0;
            this.cbo_Ordenamiento.SelectedIndexChanged += new System.EventHandler(this.Cbo_Ordenamiento_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Agregar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Calificar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Modificar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Agregar.Location = new System.Drawing.Point(3, 3);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(258, 35);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // btn_Calificar
            // 
            this.btn_Calificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Calificar.Location = new System.Drawing.Point(267, 3);
            this.btn_Calificar.Name = "btn_Calificar";
            this.btn_Calificar.Size = new System.Drawing.Size(258, 35);
            this.btn_Calificar.TabIndex = 1;
            this.btn_Calificar.Text = "Calificar";
            this.btn_Calificar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Modificar.Location = new System.Drawing.Point(531, 3);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(258, 35);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // grp_AlumnosCalificados
            // 
            this.grp_AlumnosCalificados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_AlumnosCalificados.Controls.Add(this.lst_AlumnosCalificados);
            this.grp_AlumnosCalificados.Location = new System.Drawing.Point(8, 300);
            this.grp_AlumnosCalificados.Name = "grp_AlumnosCalificados";
            this.grp_AlumnosCalificados.Size = new System.Drawing.Size(798, 223);
            this.grp_AlumnosCalificados.TabIndex = 1;
            this.grp_AlumnosCalificados.TabStop = false;
            this.grp_AlumnosCalificados.Text = "Alumnos Calificados";
            // 
            // lst_AlumnosCalificados
            // 
            this.lst_AlumnosCalificados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_AlumnosCalificados.FormattingEnabled = true;
            this.lst_AlumnosCalificados.ItemHeight = 17;
            this.lst_AlumnosCalificados.Location = new System.Drawing.Point(6, 20);
            this.lst_AlumnosCalificados.Name = "lst_AlumnosCalificados";
            this.lst_AlumnosCalificados.Size = new System.Drawing.Size(786, 191);
            this.lst_AlumnosCalificados.TabIndex = 4;
            // 
            // FormCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FormCatedra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCatedra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grp_Alumnos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grp_AlumnosCalificados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grp_Alumnos;
        private System.Windows.Forms.GroupBox grp_AlumnosCalificados;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Calificar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.ListBox lst_Alumnos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_Ordenamiento;
        private System.Windows.Forms.ListBox lst_AlumnosCalificados;
    }
}