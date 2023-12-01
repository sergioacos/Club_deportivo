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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Form pagar = new Pagar();
            pagar.ShowDialog();
            CargarCuotas();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form cuota = new Cuota();
            cuota.ShowDialog();
            CargarCuotas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCuotas()
        {
            DataTable dt = new DataTable();
            try
            {
                dgvCuotas.Rows.Clear();
                dt = Datos.Cuotas.ObtenerCuotas();

                foreach (DataRow dr in dt.Rows)
                {
                    int renglon = dgvCuotas.Rows.Add();
                    dgvCuotas.Rows[renglon].Cells[0].Value = dr[0];
                    dgvCuotas.Rows[renglon].Cells[1].Value = dr[1];
                    dgvCuotas.Rows[renglon].Cells[2].Value = dr[2];
                    dgvCuotas.Rows[renglon].Cells[3].Value = dr[3];
                    dgvCuotas.Rows[renglon].Cells[4].Value = dr[4];
                    dgvCuotas.Rows[renglon].Cells[5].Value = dr[5];
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            CargarCuotas();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text.Length == 0)
                return;

            DataTable dt = new DataTable();
            try
            {
                dgvCuotas.Rows.Clear();
                dt = Datos.Cuotas.BuscarCuotas(txtBusqueda.Text);

                foreach (DataRow dr in dt.Rows)
                {
                    int renglon = dgvCuotas.Rows.Add();
                    dgvCuotas.Rows[renglon].Cells[0].Value = dr[0];
                    dgvCuotas.Rows[renglon].Cells[1].Value = dr[1];
                    dgvCuotas.Rows[renglon].Cells[2].Value = dr[2];
                    dgvCuotas.Rows[renglon].Cells[3].Value = dr[3];
                    dgvCuotas.Rows[renglon].Cells[4].Value = dr[4];
                    dgvCuotas.Rows[renglon].Cells[5].Value = dr[5];
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void dgvCuotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int64 dni;
            if (this.dgvCuotas.Columns[e.ColumnIndex].Name == "acciones")
            {
                Form pagar = new Pagar();
                pagar.ShowDialog();
                //dgvClientes.Rows.Remove(dgvClientes.CurrentRow);
               // dni = (Int64)dgvCuotas.CurrentRow.Cells[2].Value;
               // MessageBox.Show("Listo " + dni);

            }
     }   }
}
