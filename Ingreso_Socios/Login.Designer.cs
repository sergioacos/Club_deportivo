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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            picLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(244, 140);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(241, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(318, 40);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(167, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(226, 40);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Cursor = Cursors.SizeAll;
            lblContrasena.Location = new Point(226, 86);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 5;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(318, 83);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(167, 23);
            txtContrasena.TabIndex = 4;
            txtContrasena.Enter += txtContrasena_Enter;
            // 
            // picLogin
            // 
            pbLogin.Image = (Image)resources.GetObject("pbLogin.Image");
            pbLogin.Location = new Point(12, 12);
            pbLogin.Name = "pbLogin";
            pbLogin.Size = new Size(208, 174);
            pbLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogin.TabIndex = 6;
            pbLogin.TabStop = false;
            pbLogin.Click += pbLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 214);
            Controls.Add(picLogin);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Name = "frmLogin";
            Text = "Ingreso Club Deportivo";
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
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
        private PictureBox picLogin;
    }
}