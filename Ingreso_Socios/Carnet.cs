using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingreso_Socios
{
    public partial class Carnet : Form
    {
        int idSocio;
        Bitmap memoryImage;
        public Carnet(int idSocio)
        {
            InitializeComponent();
            this.idSocio = idSocio;
        }

        private void Carnet_Load(object sender, EventArgs e)
        {
            CargarCarnet();
        }

        private void Carnet_Shown(object sender, EventArgs e)
        {
        }

        private void CargarCarnet()
        {
            Socio? socio = Datos.Socios.ObtenerPorId(idSocio);
            if (socio != null)
            {
                lblNombre.Text = socio.Apellido + ", " + socio.Nombre;
                lblFechaNac.Text = "Fecha Nac.: " + socio.FechaNac.ToShortDateString();
                lblDni.Text = "DNI: " + socio.Dni.ToString();
                lblIdSocio.Text = "Socio Nº: " + socio.IdSocio.ToString();
            }
            else
            {
                MessageBox.Show("No se encontro el socio seleccionado.");
                this.Close();
            }
        }

        private void CapturarPantalla()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }


        private void Imprimir()
        {
            CapturarPantalla();

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            Imprimir();
            btnImprimir.Visible = true;
        }
    }
}
