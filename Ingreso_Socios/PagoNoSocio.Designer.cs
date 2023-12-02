namespace Ingreso_Socios
{
    partial class PagoNoSocio
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
            lblDni = new Label();
            lblNombre = new Label();
            dgvPagos = new DataGridView();
            btnCrear = new Button();
            actividad = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            fechaEmision = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(12, 24);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(33, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre: ";
            // 
            // dgvPagos
            // 
            dgvPagos.AllowUserToAddRows = false;
            dgvPagos.AllowUserToDeleteRows = false;
            dgvPagos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Columns.AddRange(new DataGridViewColumn[] { actividad, monto, fechaEmision });
            dgvPagos.Location = new Point(12, 42);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.RowTemplate.Height = 25;
            dgvPagos.Size = new Size(570, 284);
            dgvPagos.TabIndex = 2;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(460, 9);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(122, 23);
            btnCrear.TabIndex = 3;
            btnCrear.Text = "Registrar Pago";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // actividad
            // 
            actividad.HeaderText = "Actividad";
            actividad.Name = "actividad";
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            // 
            // fechaEmision
            // 
            fechaEmision.HeaderText = "Fecha de Emisión";
            fechaEmision.Name = "fechaEmision";
            // 
            // PagoNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 338);
            Controls.Add(btnCrear);
            Controls.Add(dgvPagos);
            Controls.Add(lblNombre);
            Controls.Add(lblDni);
            Name = "PagoNoSocio";
            Text = "PagoNoSocio";
            Load += PagoNoSocio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDni;
        private Label lblNombre;
        private DataGridView dgvPagos;
        private Button btnCrear;
        private DataGridViewTextBoxColumn actividad;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn fechaEmision;
    }
}