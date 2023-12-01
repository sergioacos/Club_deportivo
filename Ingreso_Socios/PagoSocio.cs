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
        public PagoSocio()
        {
            InitializeComponent();
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
                query = $"select c.fechaVencimiento, c.monto, c.medioPago, c.fechaEmision from cuota c inner join socio s on c.idSocio = s.idSocio inner join persona p on p.idPersona = s.idPersona where p.dni = {txtDni.Text} order by c.fechaVencimiento";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();
                        //btnclm.Name = "Ver pagos";
                        int renglon = dgvCuotas.Rows.Add();
                        dgvCuotas.Rows[renglon].Cells[0].Value = reader.GetDateTime(0);
                        dgvCuotas.Rows[renglon].Cells[1].Value = reader.GetFloat(1);
                        dgvCuotas.Rows[renglon].Cells[3].Value = reader.GetString(2);
                        dgvCuotas.Rows[renglon].Cells[4].Value = reader.GetDateTime(3);
                        

                        

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
    }
}
