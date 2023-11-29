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
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            grbFormaPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            btnComprobante.Location = new Point(322, 460);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(149, 44);
            btnComprobante.TabIndex = 1;
            btnComprobante.Text = "Generar Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(167, 460);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 44);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(12, 460);
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
            grbFormaPago.Location = new Point(386, 268);
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
            // textBox1
            // 
            textBox1.Location = new Point(167, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(35, 216);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 43);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Monto";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(42, 61);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 198);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 12;
            label3.Text = "Fecha de Vencimiento:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 286);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 268);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 14;
            label1.Text = "Periodo: ";
            // 
            // Pagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 516);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(grbFormaPago);
            Controls.Add(btnPagar);
            Controls.Add(btnCancelar);
            Controls.Add(btnComprobante);
            Controls.Add(lblNSocio);
            Name = "Pagar";
            Text = "Pagar";
            grbFormaPago.ResumeLayout(false);
            grbFormaPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
    }
}