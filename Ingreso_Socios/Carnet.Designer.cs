namespace Ingreso_Socios
{
    partial class Carnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carnet));
            lblNombre = new Label();
            lblIdSocio = new Label();
            lblFechaNac = new Label();
            lblDni = new Label();
            lblTitulo = new Label();
            pbFoto = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(189, 86);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(197, 32);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre Apellido";
            // 
            // lblIdSocio
            // 
            lblIdSocio.AutoSize = true;
            lblIdSocio.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdSocio.Location = new Point(189, 54);
            lblIdSocio.Name = "lblIdSocio";
            lblIdSocio.Size = new Size(112, 32);
            lblIdSocio.TabIndex = 2;
            lblIdSocio.Text = "Socio Nº:";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNac.Location = new Point(189, 118);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(87, 21);
            lblFechaNac.TabIndex = 3;
            lblFechaNac.Text = "Fecha Nac.:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(189, 139);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(33, 15);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI: ";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(189, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(226, 42);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Club Deportivo";
            // 
            // pbFoto
            // 
            pbFoto.Image = Properties.Resources.foto_carnet;
            pbFoto.Location = new Point(12, 12);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(171, 172);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 6;
            pbFoto.TabStop = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(332, 161);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // Carnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 196);
            Controls.Add(btnImprimir);
            Controls.Add(pbFoto);
            Controls.Add(lblTitulo);
            Controls.Add(lblDni);
            Controls.Add(lblFechaNac);
            Controls.Add(lblIdSocio);
            Controls.Add(lblNombre);
            Name = "Carnet";
            Text = "Carnet";
            Load += Carnet_Load;
            Shown += Carnet_Shown;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombre;
        private Label lblIdSocio;
        private Label lblFechaNac;
        private Label lblDni;
        private Label lblTitulo;
        private PictureBox pbFoto;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnImprimir;
    }
}