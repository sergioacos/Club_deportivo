namespace Ingreso_Socios
{
    partial class frmLogin
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
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pbLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogin).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(193, 140);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(241, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(267, 54);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(167, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(193, 57);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Cursor = Cursors.SizeAll;
            lblContrasena.Location = new Point(193, 86);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 5;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(267, 83);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(167, 23);
            txtContrasena.TabIndex = 4;
            txtContrasena.Enter += txtContrasena_Enter;
            // 
            // pbLogin
            // 
            pbLogin.Image = Properties.Resources.Discord_qBNOSAYkkA;
            pbLogin.Location = new Point(12, 12);
            pbLogin.Name = "pbLogin";
            pbLogin.Size = new Size(166, 174);
            pbLogin.TabIndex = 6;
            pbLogin.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 214);
            Controls.Add(pbLogin);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Name = "frmLogin";
            Text = "Ingreso Club Deportivo";
            ((System.ComponentModel.ISupportInitialize)pbLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pbLogin;
    }
}