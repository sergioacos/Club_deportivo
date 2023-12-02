using Ingreso_Socios.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySqlConnector;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingreso_Socios
{
    public partial class PagoSocio : Form
    {
        private int dni;
        private string nombre;
        int idSocio;
        string periodo;
        public PagoSocio(string nombre, string apellido, int dni)
        {
            InitializeComponent();
            this.nombre = apellido + ", " + nombre;
            this.dni = dni;
            lblNombre.Text = "Nombre: " + this.nombre;
            lblDni.Text = "DNI: " + this.dni.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = $"select c.fechaVencimiento, c.monto, c.medioPago, c.fechaEmision, c.periodo, s.idSocio from cuota c inner join socio s on c.idSocio = s.idSocio inner join persona p on p.idPersona = s.idPersona where p.dni = {this.dni.ToString()} order by c.fechaVencimiento";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                
                if (reader.HasRows)
                {
                    dgvCuotas.Rows.Clear();
                    while (reader.Read())
                    {
                        //DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();
                        //btnclm.Name = "Ver pagos";
                        int renglon = dgvCuotas.Rows.Add();
                        dgvCuotas.Rows[renglon].Cells[0].Value = reader.GetDateTime(0);
                        dgvCuotas.Rows[renglon].Cells[1].Value = reader.GetFloat(1);
                        dgvCuotas.Rows[renglon].Cells[3].Value = reader.GetString(2);
                        dgvCuotas.Rows[renglon].Cells[4].Value = reader.GetDateTime(3).ToShortDateString();
                        periodo = reader.GetString(4);
                        idSocio = reader.GetInt32(5);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void dgvCuotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgvCuotas.Columns[e.ColumnIndex].Name == "acciones")
            {
                //Form pagar = new Pagar();
                //pagar.ShowDialog();

                DateTime vencimiento = (DateTime)dgvCuotas.Rows[e.RowIndex].Cells[0].Value;
                float monto = (float)dgvCuotas.Rows[e.RowIndex].Cells[1].Value;
                

                Pagar form = new Pagar();
                form.txtVencimiento.Text = vencimiento.ToString();
                form.txtMonto.Text = monto.ToString();
                form.txtPeriodo.Text = periodo.ToString();
                form.ShowDialog();


            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cuota cuota = new Cuota(idSocio);
            //cuota.lblNro.Text = this.idSocio;
            cuota.ShowDialog();
            CargarGrilla();


        }
    }
}
