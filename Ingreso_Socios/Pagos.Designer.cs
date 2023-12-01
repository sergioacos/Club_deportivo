namespace Ingreso_Socios
{
    partial class Pagos
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
            dgvCuotas = new DataGridView();
            cliente = new DataGridViewTextBoxColumn();
            fechaVencimiento = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            pagado = new DataGridViewCheckBoxColumn();
            medioPago = new DataGridViewTextBoxColumn();
            fechaEmision = new DataGridViewTextBoxColumn();
            acciones = new DataGridViewButtonColumn();
            label2 = new Label();
            txtBusqueda = new TextBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCuotas).BeginInit();
            SuspendLayout();
            // 
            // dgvCuotas
            // 
            dgvCuotas.AllowUserToAddRows = false;
            dgvCuotas.AllowUserToDeleteRows = false;
            dgvCuotas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuotas.Columns.AddRange(new DataGridViewColumn[] { cliente, fechaVencimiento, monto, pagado, medioPago, fechaEmision, acciones });
            dgvCuotas.Location = new Point(10, 70);
            dgvCuotas.Name = "dgvCuotas";
            dgvCuotas.ReadOnly = true;
            dgvCuotas.RowTemplate.Height = 25;
            dgvCuotas.Size = new Size(794, 250);
            dgvCuotas.TabIndex = 0;
            dgvCuotas.CellClick += dgvCuotas_CellClick;
            dgvCuotas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cliente
            // 
            cliente.HeaderText = "Cliente";
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            // 
            // fechaVencimiento
            // 
            fechaVencimiento.HeaderText = "Vencimiento";
            fechaVencimiento.Name = "fechaVencimiento";
            fechaVencimiento.ReadOnly = true;
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            monto.ReadOnly = true;
            // 
            // pagado
            // 
            pagado.HeaderText = "Pagado";
            pagado.Name = "pagado";
            pagado.ReadOnly = true;
            // 
            // medioPago
            // 
            medioPago.HeaderText = "Medio de Pago";
            medioPago.Name = "medioPago";
            medioPago.ReadOnly = true;
            // 
            // fechaEmision
            // 
            fechaEmision.HeaderText = "Fecha de Emision";
            fechaEmision.Name = "fechaEmision";
            fechaEmision.ReadOnly = true;
            // 
            // acciones
            // 
            acciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            acciones.HeaderText = "Acciones";
            acciones.Name = "acciones";
            acciones.ReadOnly = true;
            acciones.Text = "Pagar";
            acciones.Width = 61;
            acciones.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 28);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Buscar:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(63, 25);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(234, 23);
            txtBusqueda.TabIndex = 4;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.Location = new Point(690, 18);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 35);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Right;
            btnAgregar.Location = new Point(570, 18);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = RightToLeft.No;
            btnAgregar.Size = new Size(114, 35);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 332);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(txtBusqueda);
            Controls.Add(label2);
            Controls.Add(dgvCuotas);
            Name = "Pagos";
            Text = "Pagos";
            Load += Pagos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCuotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCuotas;
        private Label label2;
        private TextBox txtBusqueda;
        private Button btnCancelar;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn fechaVencimiento;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewCheckBoxColumn pagado;
        private DataGridViewTextBoxColumn medioPago;
        private DataGridViewTextBoxColumn fechaEmision;
        private DataGridViewButtonColumn acciones;
    }
}