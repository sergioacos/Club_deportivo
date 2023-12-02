namespace Ingreso_Socios
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnClientes = new Button();
            btnActividades = new Button();
            btnSalir = new Button();
            lblUsuario = new Label();
            pictureBox1 = new PictureBox();
            btnASocio = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(12, 53);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(148, 23);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Gestionar Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnActividades
            // 
            btnActividades.Location = new Point(12, 82);
            btnActividades.Name = "btnActividades";
            btnActividades.Size = new Size(148, 23);
            btnActividades.TabIndex = 2;
            btnActividades.Text = "Gestionar Actividades";
            btnActividades.UseVisualStyleBackColor = true;
            btnActividades.Click += btnActividades_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(85, 140);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(53, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(191, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnASocio
            // 
            btnASocio.Location = new Point(12, 111);
            btnASocio.Name = "btnASocio";
            btnASocio.Size = new Size(148, 23);
            btnASocio.TabIndex = 6;
            btnASocio.Text = "Agregar Socio";
            btnASocio.UseVisualStyleBackColor = true;
            btnASocio.Click += btnASocio_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 221);
            Controls.Add(btnASocio);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnActividades);
            Controls.Add(btnClientes);
            Name = "Menu";
            Text = "Menu";
            FormClosed += Menu_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Button btnActividades;
        private Button btnSalir;
        private Label lblUsuario;
        private PictureBox pictureBox1;
        private Button btnASocio;
    }
}