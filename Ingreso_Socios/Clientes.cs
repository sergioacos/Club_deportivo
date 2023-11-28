﻿using Ingreso_Socios.Datos;
using MySql.Data.MySqlClient;
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
            this.Close();
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
                query = "select p.apellido, p.nombre, p.dni, p.fechaNac, p.aptoFisico, s.idSocio from persona p left join socio s on p.idPersona = s.idPersona order by p.apellido";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dgvClientes.Rows.Add();
                        dgvClientes.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dgvClientes.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dgvClientes.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        
                        string fecha = reader.GetString(3);
                        //string fechaNac = string.Join("/", fecha.Split('-').Reverse());
                        DateTime fechaNac2 = DateTime.ParseExact(fecha, "d/M/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                        //DateTime fechaSinHora = fechaNac2.Date;
                        DateTime fechaActual = DateTime.Now;
                        //int edad = fechaActual.Year - fechaNac2.Year;
                        TimeSpan diferencia = fechaActual - fechaNac2;
                        double dias = diferencia.TotalDays;
                        double anos = Math.Floor(dias / 365);
                        dgvClientes.Rows[renglon].Cells[3].Value = anos;

                        dgvClientes.Rows[renglon].Cells[4].Value = reader.GetString(4);
                        
                        //dgvClientes.Rows[renglon].Cells[5].Value = reader.GetString(5);
                        if(!reader.IsDBNull(5))
                        {
                            dgvClientes.Rows[renglon].Cells[5].Value = true;
                        }
                       else
                        {
                            dgvClientes.Rows[renglon].Cells[5].Value = false;
                         }
                        
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS");
                }
            }
            catch(Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
            finally
            {
                if(sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
