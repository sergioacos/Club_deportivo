using Ingreso_Socios.Datos;
using MySqlConnector;
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
    public partial class Pagar : Form
    {
        private int idCuota;
        private DateTime vencimiento;
        private double monto;
        private string periodo;

        public Factura doc = new Factura();
        public Pagar()
        {
            InitializeComponent();
        }

        public Pagar(int idCuota, DateTime vencimiento, double monto, string periodo)
        {
            InitializeComponent();
            this.idCuota = idCuota;
            txtVencimiento.Text = vencimiento.ToShortDateString();
            txtMonto.Text = monto.ToString();
            txtPeriodo.Text = periodo.ToString();
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            string medioPago = rdbEfectivo.Checked ? "Efectivo" : "Tarjeta";
            Datos.Cuotas.PagarCuota(this.idCuota, medioPago);
            this.Close();
            return;

            //MySqlConnection sqlCon = new MySqlConnection();
            //try
            //{
            //    if (rdbEfectivo.Checked == true) // Evaluamos que opcion es la seleccionada
            //    {
            //        doc.formaFactura = "Efectivo";
            //        /* ---------------------------------
            //        * Pago en efvo se descuenta 10%
            //        * --------------------------------- */
            //        doc.montoFactura = (float)(doc.montoFactura * 0.90);
            //    }
            //    else
            //    {
            //        doc.formaFactura = "Tarjeta";
            //    }
            //    sqlCon = Conexion.getInstancia().CrearConexion();

            //    MySqlCommand comando = new MySqlCommand("CrearCuota", sqlCon);

            //    sqlCon.Open();

            //    MySqlDataReader reader;
            //    reader = comando.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        reader.Read(); // En este caso sabemos que si tiene datos es UNA SOLA FILA
            //        doc.numeroFactura = Convert.ToInt32(reader.GetString(0));
            //        doc.periodo = reader.GetString(1);
            //        doc.socio = reader.GetString(2);
            //        doc.montoFactura = (float)Convert.ToDouble
            //        (reader.GetString(3));
            //        doc.fechaFactura = (DateTime)Convert.ToDateTime
            //        (reader.GetString(4));
            //        if (rdbEfectivo.Checked == true) // Evaluamos que opcion es la seleccionada
            //        {
            //            doc.formaFactura = "Efectivo";
            //            /* ---------------------------------
            //            * Pago en efvo se descuenta 10%
            //            * --------------------------------- */
            //            doc.montoFactura = (float)(doc.montoFactura * 0.90);
            //        }
            //        else
            //        {
            //            doc.formaFactura = "Tarjeta";
            //        }
            //        btnComprobante.Enabled = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Número de socio inexistente", "AVISO DEL SISTEMA",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    if (sqlCon.State == ConnectionState.Open)
            //    {
            //        sqlCon.Close();
            //    }
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
