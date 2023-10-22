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
            btnClientes = new Button();
            btnPagos = new Button();
            btnActividades = new Button();
            btnSalir = new Button();
            lblUsuario = new Label();
            pictureBox1 = new PictureBox();
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
            btnClientes.Click += button1_Click;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(12, 82);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(148, 23);
            btnPagos.TabIndex = 1;
            btnPagos.Text = "Gestionar Pagos";
            btnPagos.UseVisualStyleBackColor = true;
            // 
            // btnActividades
            // 
            btnActividades.Location = new Point(12, 111);
            btnActividades.Name = "btnActividades";
            btnActividades.Size = new Size(148, 23);
            btnActividades.TabIndex = 2;
            btnActividades.Text = "Gestionar Actividades";
            btnActividades.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(317, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(208, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario: Ignacio Fiora (Administrador)";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(186, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 116);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 188);
            Controls.Add(pictureBox1);
            Controls.Add(lblUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnActividades);
            Controls.Add(btnPagos);
            Controls.Add(btnClientes);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Button btnPagos;
        private Button btnActividades;
        private Button btnSalir;
        private Label lblUsuario;
        private PictureBox pictureBox1;
    }
}