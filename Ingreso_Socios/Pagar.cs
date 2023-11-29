﻿using Ingreso_Socios.Datos;
using MySql.Data.MySqlClient;
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
        public Factura doc = new Factura();
        public Pagar()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
               // query = "select p.apellido, p.nombre, p.dni, p.fechaNac, p.aptoFisico, s.idSocio from persona p left join socio s on p.idPersona = s.idPersona order by p.apellido";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // En este caso sabemos que si tiene datos es UNA SOLA FILA
                    doc.numeroFactura = Convert.ToInt32(reader.GetString(0));
                    doc.periodo = reader.GetString(1);
                    doc.socio = reader.GetString(2);
                    doc.montoFactura = (float)Convert.ToDouble
                    (reader.GetString(3));
                    doc.fechaFactura = (DateTime)Convert.ToDateTime
                    (reader.GetString(4));
                    if (chkEfectivo.Checked == true) // Evaluamos que opcion es la seleccionada
                    {
                        doc.formaFactura = "Efectivo";
                        /* ---------------------------------
                        * Pago en efvo se descuenta 10%
                        * --------------------------------- */
                        doc.montoFactura = (float)(doc.montoFactura * 0.90);
                    }
                    else
                    {
                        doc.formaFactura = "Tarjeta";
                    }
                    btnComprobante.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Número de socio inexistente", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Pagar_Load(object sender, EventArgs e)
        {

        }
    }
}