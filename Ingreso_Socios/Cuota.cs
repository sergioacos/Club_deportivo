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
    public partial class Cuota : Form
    {
        private int idSocio;
        public Cuota(int idSocio)
        {
            InitializeComponent();
            this.idSocio = idSocio;
            lblNro.Text = idSocio.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            // Validamos los datos de todos los textboxes del formulario.
            //if (txtIdSocio.Value < 1)
            //{
            //    MessageBox.Show("La id del socio debe ser mayor a 0.");
            //    return;
           // }

            if (txtMonto.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un monto.");
                return;
            }

            if (Convert.ToDouble(txtMonto.Text) < 0)
            {
                MessageBox.Show("El monto de la factura debe ser mayor a 0.");
                return;
            }

            if (txtFechaVencimiento.Value < DateTime.Today)
            {
                MessageBox.Show("La fecha de vencimiento debe ser mayor al dia de hoy.");
                return;
            }

            // Validamos si la ID de socio existe.
            //if (!Datos.Socios.ValidarIdSocio(((int)txtIdSocio.Value)))
            //{ 
            //    MessageBox.Show("El numero de socio es invalido.");
            //    return;
            // }

            // Creamos el registro de la base de datos y reportamos el resultado.
            // if (Datos.Cuotas.CrearCuota((int)txtIdSocio.Value, Convert.ToDouble(txtMonto.Text), DateOnly.FromDateTime(txtFechaVencimiento.Value), txtPeriodo.Text))
            // {
            //     MessageBox.Show("La cuota se creó exitosamente.");
            //     this.Close();
            //     return;
            // }
            if (Datos.Cuotas.CrearCuota(Convert.ToInt32(lblNro.Text), Convert.ToDouble(txtMonto.Text), DateOnly.FromDateTime(txtFechaVencimiento.Value), txtPeriodo.Text))
            {
                MessageBox.Show("La cuota se creó exitosamente.");
                
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Error al crear la cuota, intente de nuevo.");
                return;
            }

        }

        private void CargarPeriodo()
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            txtPeriodo.Text = meses[txtFechaVencimiento.Value.Month - 1] + " " + txtFechaVencimiento.Value.Year;
        }

        private void txtFechaVencimiento_ValueChanged(object sender, EventArgs e)
        {
            CargarPeriodo();
        }

        private void Cuota_Load(object sender, EventArgs e)
        {
            CargarPeriodo();
        }
    }
}
