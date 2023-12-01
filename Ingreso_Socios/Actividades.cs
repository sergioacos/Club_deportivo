using Ingreso_Socios.Datos;
using MySqlConnector;
using MySqlX.XDevAPI.Relational;
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
    public partial class Actividades : Form
    {
        public Actividades()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmActividad_Load(object sender, EventArgs e)
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
                query = "select nombre,costo from actividad order by nombre";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dgvActividades.Rows.Add();
                        dgvActividades.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dgvActividades.Rows[renglon].Cells[1].Value = reader.GetString(1);


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

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> actividades = new List<string>();
            foreach (DataGridViewRow row in dgvActividades.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells[2].Value);
                if (isChecked)
                {

                    actividades.Add(row.Cells["Nombre"].Value.ToString());
                    //MessageBox.Show(row.Cells["Nombre"].Value.ToString());
                }
                //MessageBox.Show("Listo");

            }
            string act = "";
           
            for (int i = 0; i < actividades.Count; i++)
            {
                act= act+ actividades[i].ToString()+", ";
            }
            MessageBox.Show("Las actividades a las que se inscribo son: " + act);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form menu = new Menu("TEST");
            menu.ShowDialog();
            //this.Close();


        }
    }
}
