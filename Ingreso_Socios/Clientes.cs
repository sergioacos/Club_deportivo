using Ingreso_Socios.Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingreso_Socios
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form socios = new Socios();
            socios.ShowDialog();
            CargarGrilla();
        }

        private void frmCliente_Load(object sender, EventArgs e)
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
                query = "select p.apellido, p.nombre, p.dni, p.fechaNac, p.aptoFisico, s.idSocio, ns.idNoSocio from persona p left join socio s on p.idPersona = s.idPersona left join nosocio ns on ns.idPersona = p.idPersona order by p.apellido";

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
                        int renglon = dgvClientes.Rows.Add();
                        dgvClientes.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dgvClientes.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dgvClientes.Rows[renglon].Cells[2].Value = reader.GetInt32(2);
                        //dgvClientes.Rows[renglon].Cells[6].Value = btnclm;

                        DateTime fechaNac2 = reader.GetDateTime(3);
                        //string fechaNac = string.Join("/", fecha.Split('-').Reverse());
                        //DateTime fechaSinHora = fechaNac2.Date;
                        DateTime fechaActual = DateTime.Now;
                        //int edad = fechaActual.Year - fechaNac2.Year;
                        TimeSpan diferencia = fechaActual - fechaNac2;
                        double dias = diferencia.TotalDays;
                        double anos = Math.Floor(dias / 365);
                        dgvClientes.Rows[renglon].Cells[3].Value = anos;

                        dgvClientes.Rows[renglon].Cells[4].Value = reader.GetBoolean(4);


                        dgvClientes.Rows[renglon].Cells["id"].Value = reader.IsDBNull(5) ? reader.IsDBNull(6) ? 0 : reader.GetInt32(6) : reader.GetInt32(5);

                        //dgvClientes.Rows[renglon].Cells[5].Value = reader.GetString(5);
                        if (!reader.IsDBNull(5))
                        {
                            dgvClientes.Rows[renglon].Cells[5].Value = true;
                            //socio = true;
                        }
                        else
                        {
                            dgvClientes.Rows[renglon].Cells[5].Value = false;
                            // socio = false;
                        }

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
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvClientes.Columns[e.ColumnIndex].Name == "Acciones")
            {
                bool socio = (bool)dgvClientes.Rows[e.RowIndex].Cells[5].Value;
                string nombre = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                string apellido = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                int dni = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[2].Value);
                int idSocio = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["id"].Value);
                if (socio)
                {
                    Form form = new PagoSocio(nombre, apellido, dni, idSocio);
                    form.ShowDialog();
                }
                else
                {
                    Form detalle = new PagoNoSocio(nombre, apellido, dni);
                    detalle.ShowDialog();
                }

                //dgvClientes.Rows.Remove(dgvClientes.CurrentRow);
                //  dni = (Int64)dgvClientes.CurrentRow.Cells[2].Value;
                //MessageBox.Show("Listo " + dni);

            }
        }
    }
}
