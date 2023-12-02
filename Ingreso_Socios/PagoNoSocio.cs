using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingreso_Socios
{
    public partial class PagoNoSocio : Form
    {
        private int idNoSocio;
        private int dni;
        private string nombreApellido;


        public PagoNoSocio(string nombre, string apellido, int dni)
        {
            InitializeComponent();
            this.nombreApellido = apellido + ", " + nombre;
            this.dni = dni;
            lblDni.Text = "DNI: " + dni.ToString();
            lblNombre.Text = this.nombreApellido;
            this.idNoSocio = Datos.NoSocios.ObtenerIdPorDni(this.dni);
        }

        private void CargarPagos()
        {
            DataTable dt = new DataTable();
            try
            {
                dgvPagos.Rows.Clear();
                dt = Datos.NoSocios.ObtenerPagos(this.dni);

                foreach (DataRow dr in dt.Rows)
                {
                    int renglon = dgvPagos.Rows.Add();
                    dgvPagos.Rows[renglon].Cells[0].Value = dr[0];
                    dgvPagos.Rows[renglon].Cells[1].Value = dr[1];
                    dgvPagos.Rows[renglon].Cells[2].Value = dr[2];
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PagoNoSocio_Load(object sender, EventArgs e)
        {
            if (this.idNoSocio == -1)
            {
                MessageBox.Show("No se encontro el socio seleccionado.");
                this.Close();
            }

            CargarPagos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Actividades actividades = new Actividades();
            actividades.ShowDialog();

            List<int> idsActividades = actividades.idActividades;
            if (idsActividades != null && idsActividades.Count > 0)
            {
                foreach (int id in idsActividades)
                {
                    Datos.NoSocios.PagarActividad(this.idNoSocio, id);
                }
                CargarPagos();
            }
        }
    }
}
