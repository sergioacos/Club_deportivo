namespace Ingreso_Socios
{
    partial class Actividades
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
            dgvActividades = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewCheckBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // dgvActividades
            // 
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.AllowUserToDeleteRows = false;
            dgvActividades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Columns.AddRange(new DataGridViewColumn[] { Nombre, Column1, Column2 });
            dgvActividades.Location = new Point(12, 41);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowTemplate.Height = 25;
            dgvActividades.Size = new Size(474, 177);
            dgvActividades.TabIndex = 0;
            dgvActividades.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Resizable = DataGridViewTriState.True;
            // 
            // Column1
            // 
            Column1.HeaderText = "Costo";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Acciones";
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 1;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(329, 12);
            button2.Name = "button2";
            button2.Size = new Size(137, 23);
            button2.TabIndex = 2;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Actividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 230);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvActividades);
            Name = "Actividades";
            Text = "Actividades";
            Load += frmActividad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvActividades;
        private Button button1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewCheckBoxColumn Column2;
        private Button button2;
    }
}