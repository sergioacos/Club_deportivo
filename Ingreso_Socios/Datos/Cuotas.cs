using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso_Socios.Datos
{
    internal class Cuotas
    {
        public DataTable CrearCuota(int idSocio, double monto, DateOnly fechaVencimiento, string periodo)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            MySqlConnection sqlConn = new MySqlConnection();
            try
            {

                sqlConn = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("CrearCuota", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idSocio", MySqlDbType.Int64).Value = idSocio;
                comando.Parameters.Add("monto", MySqlDbType.Float).Value = monto;
                comando.Parameters.Add("fechaVencimiento", MySqlDbType.Date).Value = fechaVencimiento;
                comando.Parameters.Add("periodo", MySqlDbType.VarChar).Value = periodo;

                sqlConn.Open();
                resultado = comando.ExecuteReader();

                tabla.Load(resultado);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }
    }
}
