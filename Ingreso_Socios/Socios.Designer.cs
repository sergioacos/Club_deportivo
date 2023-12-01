namespace Ingreso_Socios
{
    partial class Socios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomSocio = new Label();
            lblApSocio = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblDNI = new Label();
            txtDni = new TextBox();
            chkAptoFisico = new CheckBox();
            dateTimePickerFechaN = new DateTimePicker();
            lblFechaNac = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            chkSocio = new CheckBox();
            SuspendLayout();
            // 
            // lblNomSocio
            // 
            lblNomSocio.AutoSize = true;
            lblNomSocio.Location = new Point(71, 27);
            lblNomSocio.Name = "lblNomSocio";
            lblNomSocio.Size = new Size(110, 15);
            lblNomSocio.TabIndex = 1;
            lblNomSocio.Text = "Nombre del Cliente";
            // 
            // lblApSocio
            // 
            lblApSocio.AutoSize = true;
            lblApSocio.Location = new Point(71, 98);
            lblApSocio.Name = "lblApSocio";
            lblApSocio.Size = new Size(110, 15);
            lblApSocio.TabIndex = 2;
            lblApSocio.Text = "Apellido del Cliente";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(71, 116);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(230, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(71, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(230, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(71, 176);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(44, 15);
            lblDNI.TabIndex = 5;
            lblDNI.Text = "DNI N°";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(71, 194);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(230, 23);
            txtDni.TabIndex = 6;
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(216, 248);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(85, 19);
            chkAptoFisico.TabIndex = 7;
            chkAptoFisico.Text = "Apto Fisico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaN
            // 
            dateTimePickerFechaN.CustomFormat = "";
            dateTimePickerFechaN.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaN.ImeMode = ImeMode.NoControl;
            dateTimePickerFechaN.Location = new Point(71, 266);
            dateTimePickerFechaN.Name = "dateTimePickerFechaN";
            dateTimePickerFechaN.Size = new Size(125, 23);
            dateTimePickerFechaN.TabIndex = 8;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(71, 248);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(119, 15);
            lblFechaNac.TabIndex = 9;
            lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(71, 354);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(102, 31);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(196, 354);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 31);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // chkSocio
            // 
            chkSocio.AutoSize = true;
            chkSocio.Location = new Point(216, 273);
            chkSocio.Name = "chkSocio";
            chkSocio.Size = new Size(55, 19);
            chkSocio.TabIndex = 15;
            chkSocio.Text = "Socio";
            chkSocio.UseVisualStyleBackColor = true;
            chkSocio.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Socios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 414);
            Controls.Add(chkSocio);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblFechaNac);
            Controls.Add(dateTimePickerFechaN);
            Controls.Add(chkAptoFisico);
            Controls.Add(txtDni);
            Controls.Add(lblDNI);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblApSocio);
            Controls.Add(lblNomSocio);
            Name = "Socios";
            Text = "Ingreso Socios";
            Load += Socios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNomSocio;
        private Label lblApSocio;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblDNI;
        private TextBox txtDni;
        private CheckBox chkAptoFisico;
        private DateTimePicker dateTimePickerFechaN;
        private Label lblFechaNac;
        //private ComboBox cboCuota;
        private Button btnRegistrar;
        //private Label lblCuota;
        private Button btnCancelar;
        private CheckBox chkSocio;
    }
}