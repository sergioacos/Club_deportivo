namespace Ingreso_Socios
{
    partial class Pagar
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
            btnComprobante = new Button();
            btnCancelar = new Button();
            btnPagar = new Button();
            grbFormaPago = new GroupBox();
            chkTarjeta = new CheckBox();
            chkEfectivo = new CheckBox();
            txtMonto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPeriodo = new TextBox();
            label1 = new Label();
            txtVencimiento = new TextBox();
            grbFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.Location = new Point(350, 231);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(149, 44);
            btnComprobante.TabIndex = 1;
            btnComprobante.Text = "Generar Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(181, 231);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 44);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(12, 231);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(149, 44);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // grbFormaPago
            // 
            grbFormaPago.Controls.Add(chkTarjeta);
            grbFormaPago.Controls.Add(chkEfectivo);
            grbFormaPago.Location = new Point(350, 59);
            grbFormaPago.Name = "grbFormaPago";
            grbFormaPago.Size = new Size(169, 140);
            grbFormaPago.TabIndex = 4;
            grbFormaPago.TabStop = false;
            grbFormaPago.Text = "Formas de Pago";
            // 
            // chkTarjeta
            // 
            chkTarjeta.AutoSize = true;
            chkTarjeta.Location = new Point(29, 77);
            chkTarjeta.Name = "chkTarjeta";
            chkTarjeta.Size = new Size(60, 19);
            chkTarjeta.TabIndex = 1;
            chkTarjeta.Text = "Tarjeta";
            chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // chkEfectivo
            // 
            chkEfectivo.AutoSize = true;
            chkEfectivo.Location = new Point(29, 37);
            chkEfectivo.Name = "chkEfectivo";
            chkEfectivo.Size = new Size(68, 19);
            chkEfectivo.TabIndex = 0;
            chkEfectivo.Text = "Efectivo";
            chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(72, 136);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Monto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 34);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 12;
            label3.Text = "Fecha de Vencimiento:";
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(72, 77);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(100, 23);
            txtPeriodo.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 14;
            label1.Text = "Periodo: ";
            // 
            // txtVencimiento
            // 
            txtVencimiento.Location = new Point(163, 31);
            txtVencimiento.Name = "txtVencimiento";
            txtVencimiento.Size = new Size(356, 23);
            txtVencimiento.TabIndex = 15;
            // 
            // Pagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 324);
            Controls.Add(txtVencimiento);
            Controls.Add(label1);
            Controls.Add(txtPeriodo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMonto);
            Controls.Add(grbFormaPago);
            Controls.Add(btnPagar);
            Controls.Add(btnCancelar);
            Controls.Add(btnComprobante);
            Name = "Pagar";
            Text = "Pagar";
            grbFormaPago.ResumeLayout(false);
            grbFormaPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnComprobante;
        private Button btnCancelar;
        private Button btnPagar;
        private GroupBox grbFormaPago;
        private CheckBox chkTarjeta;
        private CheckBox chkEfectivo;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
        public TextBox txtVencimiento;
        public TextBox txtMonto;
        public TextBox txtPeriodo;
    }
}