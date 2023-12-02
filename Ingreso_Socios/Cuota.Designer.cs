namespace Ingreso_Socios
{
    partial class Cuota
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
            label1 = new Label();
            txtPeriodo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtFechaVencimiento = new DateTimePicker();
            txtMonto = new TextBox();
            lblNSocio = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblNro = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 141);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 22;
            label1.Text = "Periodo: ";
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(14, 159);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.ReadOnly = true;
            txtPeriodo.Size = new Size(198, 23);
            txtPeriodo.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 20;
            label3.Text = "Fecha de Vencimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 18;
            label2.Text = "Monto";
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.Format = DateTimePickerFormat.Short;
            txtFechaVencimiento.Location = new Point(12, 115);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.Size = new Size(200, 23);
            txtFechaVencimiento.TabIndex = 17;
            txtFechaVencimiento.ValueChanged += txtFechaVencimiento_ValueChanged;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(12, 53);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(200, 23);
            txtMonto.TabIndex = 16;
            // 
            // lblNSocio
            // 
            lblNSocio.AutoSize = true;
            lblNSocio.Location = new Point(12, 9);
            lblNSocio.Name = "lblNSocio";
            lblNSocio.Size = new Size(99, 15);
            lblNSocio.TabIndex = 15;
            lblNSocio.Text = "Numero de Socio";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAceptar.Location = new Point(12, 200);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.Location = new Point(93, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNro
            // 
            lblNro.AutoSize = true;
            lblNro.Location = new Point(118, 9);
            lblNro.Name = "lblNro";
            lblNro.Size = new Size(27, 15);
            lblNro.TabIndex = 25;
            lblNro.Text = "Nro";
            // 
            // Cuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 235);
            Controls.Add(lblNro);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(txtPeriodo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFechaVencimiento);
            Controls.Add(txtMonto);
            Controls.Add(lblNSocio);
            Name = "Cuota";
            Text = "Cuota";
            Load += Cuota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPeriodo;
        private Label label3;
        private NumericUpDown txtIdSocio;
        private Label label2;
        private DateTimePicker txtFechaVencimiento;
        private TextBox txtMonto;
        private Label lblNSocio;
        private Button btnAceptar;
        private Button btnCancelar;
        public Label lblNro;
    }
}