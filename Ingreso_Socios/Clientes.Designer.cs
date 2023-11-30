namespace Ingreso_Socios
{
    partial class Clientes
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
            components = new System.ComponentModel.Container();
            dgvClientes = new DataGridView();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            AptoFisico = new DataGridViewCheckBoxColumn();
            Socio = new DataGridViewCheckBoxColumn();
            Acciones = new DataGridViewButtonColumn();
            btnRegistrar = new Button();
            personaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, Column2, Column3, AptoFisico, Socio, Acciones });
            dgvClientes.Location = new Point(12, 51);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(788, 282);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "DNI";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Edad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // AptoFisico
            // 
            AptoFisico.HeaderText = "AptoFisico";
            AptoFisico.Name = "AptoFisico";
            AptoFisico.ReadOnly = true;
            // 
            // Socio
            // 
            Socio.HeaderText = "Socio";
            Socio.Name = "Socio";
            Socio.ReadOnly = true;
            Socio.Resizable = DataGridViewTriState.True;
            // 
            // Acciones
            // 
            Acciones.HeaderText = "Acciones";
            Acciones.Name = "Acciones";
            Acciones.ReadOnly = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(141, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar Cliente";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // personaBindingSource
            // 
            personaBindingSource.DataSource = typeof(Persona);
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 345);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvClientes);
            Name = "Clientes";
            Text = "Clientes";
            Load += frmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnRegistrar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aptoFisicoDataGridViewCheckBoxColumn;
        private BindingSource personaBindingSource;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn AptoFisico;
        private DataGridViewCheckBoxColumn Socio;
        private DataGridViewButtonColumn Acciones;
    }
}