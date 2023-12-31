﻿namespace Ingreso_Socios
{
    partial class PagoSocio
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
            lblNombre = new Label();
            lblDni = new Label();
            btnAgregar = new Button();
            fechaVencimiento = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            pagado = new DataGridViewCheckBoxColumn();
            medioPago = new DataGridViewTextBoxColumn();
            fechaEmision = new DataGridViewTextBoxColumn();
            fechaPago = new DataGridViewTextBoxColumn();
            acciones = new DataGridViewButtonColumn();
            idCuota = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCuotas).BeginInit();
            SuspendLayout();
            // 
            // dgvCuotas
            // 
            dgvCuotas.AllowUserToAddRows = false;
            dgvCuotas.AllowUserToDeleteRows = false;
            dgvCuotas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuotas.Columns.AddRange(new DataGridViewColumn[] { fechaVencimiento, monto, pagado, medioPago, fechaEmision, fechaPago, acciones, idCuota });
            dgvCuotas.Location = new Point(12, 61);
            dgvCuotas.Name = "dgvCuotas";
            dgvCuotas.ReadOnly = true;
            dgvCuotas.RowTemplate.Height = 25;
            dgvCuotas.Size = new Size(764, 262);
            dgvCuotas.TabIndex = 1;
            dgvCuotas.CellContentClick += dgvCuotas_CellContentClick;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(12, 24);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 6;
            lblDni.Text = "DNI";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(583, 16);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(193, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar Cuota";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
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
            // fechaPago
            // 
            fechaPago.HeaderText = "Fecha de Pago";
            fechaPago.Name = "fechaPago";
            fechaPago.ReadOnly = true;
            // 
            // acciones
            // 
            acciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            acciones.HeaderText = "Acciones";
            acciones.Name = "acciones";
            acciones.ReadOnly = true;
            acciones.Text = "Pagar";
            acciones.UseColumnTextForButtonValue = true;
            acciones.Width = 61;
            // 
            // idCuota
            // 
            idCuota.HeaderText = "Id Cuota";
            idCuota.Name = "idCuota";
            idCuota.ReadOnly = true;
            idCuota.Visible = false;
            // 
            // PagoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 335);
            Controls.Add(btnAgregar);
            Controls.Add(lblDni);
            Controls.Add(lblNombre);
            Controls.Add(dgvCuotas);
            Name = "PagoSocio";
            Text = "PagoSocio";
            Load += frmPagos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCuotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCuotas;
        private Label lblNombre;
        private Label lblDni;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn fechaVencimiento;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewCheckBoxColumn pagado;
        private DataGridViewTextBoxColumn medioPago;
        private DataGridViewTextBoxColumn fechaEmision;
        private DataGridViewTextBoxColumn fechaPago;
        private DataGridViewButtonColumn acciones;
        private DataGridViewTextBoxColumn idCuota;
    }
}