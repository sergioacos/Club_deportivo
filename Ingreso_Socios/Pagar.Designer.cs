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
            lblNSocio = new Label();
            btnComprobante = new Button();
            btnCancelar = new Button();
            btnPagar = new Button();
            grbFormaPago = new GroupBox();
            chkTarjeta = new CheckBox();
            chkEfectivo = new CheckBox();
            txtNSocio = new TextBox();
            nudFactura = new NumericUpDown();
            label1 = new Label();
            grbFormaPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFactura).BeginInit();
            SuspendLayout();
            // 
            // lblNSocio
            // 
            lblNSocio.AutoSize = true;
            lblNSocio.Location = new Point(38, 43);
            lblNSocio.Name = "lblNSocio";
            lblNSocio.Size = new Size(99, 15);
            lblNSocio.TabIndex = 0;
            lblNSocio.Text = "Numero de Socio";
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.Location = new Point(399, 222);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(149, 44);
            btnComprobante.TabIndex = 1;
            btnComprobante.Text = "Generar Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(215, 222);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 44);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(38, 222);
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
            grbFormaPago.Location = new Point(379, 43);
            grbFormaPago.Name = "grbFormaPago";
            grbFormaPago.Size = new Size(169, 140);
            grbFormaPago.TabIndex = 4;
            grbFormaPago.TabStop = false;
            grbFormaPago.Text = "Formas de Pago";
            // 
            // chkTarjeta
            // 
            chkTarjeta.AutoSize = true;
            chkTarjeta.Location = new Point(37, 77);
            chkTarjeta.Name = "chkTarjeta";
            chkTarjeta.Size = new Size(60, 19);
            chkTarjeta.TabIndex = 1;
            chkTarjeta.Text = "Tarjeta";
            chkTarjeta.UseVisualStyleBackColor = true;
            // 
            // chkEfectivo
            // 
            chkEfectivo.AutoSize = true;
            chkEfectivo.Location = new Point(37, 40);
            chkEfectivo.Name = "chkEfectivo";
            chkEfectivo.Size = new Size(68, 19);
            chkEfectivo.TabIndex = 0;
            chkEfectivo.Text = "Efectivo";
            chkEfectivo.UseVisualStyleBackColor = true;
            // 
            // txtNSocio
            // 
            txtNSocio.Location = new Point(38, 82);
            txtNSocio.Name = "txtNSocio";
            txtNSocio.Size = new Size(156, 23);
            txtNSocio.TabIndex = 5;
            txtNSocio.Text = "Ingrese N° Socio";
            // 
            // nudFactura
            // 
            nudFactura.Location = new Point(237, 82);
            nudFactura.Name = "nudFactura";
            nudFactura.Size = new Size(98, 23);
            nudFactura.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 43);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 7;
            label1.Text = "Numero de Factura";
            // 
            // Pagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 297);
            Controls.Add(label1);
            Controls.Add(nudFactura);
            Controls.Add(txtNSocio);
            Controls.Add(grbFormaPago);
            Controls.Add(btnPagar);
            Controls.Add(btnCancelar);
            Controls.Add(btnComprobante);
            Controls.Add(lblNSocio);
            Name = "Pagar";
            Text = "Pagar";
            Load += Pagar_Load;
            grbFormaPago.ResumeLayout(false);
            grbFormaPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNSocio;
        private Button btnComprobante;
        private Button btnCancelar;
        private Button btnPagar;
        private GroupBox grbFormaPago;
        private CheckBox chkTarjeta;
        private CheckBox chkEfectivo;
        private TextBox txtNSocio;
        private NumericUpDown nudFactura;
        private Label label1;
    }
}