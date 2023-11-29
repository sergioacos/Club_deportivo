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
            textBox2 = new TextBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            lblNSocio = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            // textBox2
            // 
            textBox2.Location = new Point(14, 159);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 21;
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 27);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 18;
            label2.Text = "Monto";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(12, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 16;
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
            // 
            // Cuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 235);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(lblNSocio);
            Name = "Cuota";
            Text = "Cuota";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label lblNSocio;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}