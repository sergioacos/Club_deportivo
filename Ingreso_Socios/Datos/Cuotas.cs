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
        public static bool CrearCuota(int idSocio, double monto, DateOnly fechaVencimiento, string periodo)
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
                int cantModificaciones = comando.ExecuteNonQuery();

                return cantModificaciones > 0;
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

        public static DataTable ObtenerCuotas()
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            MySqlConnection sqlConn = new MySqlConnection();
            try
            {
                sqlConn = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("ObtenerCuotas", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;

                sqlConn.Open();
                resultado = comando.ExecuteReader();

                tabla.Load(resultado);

                return tabla;
            }
            catch (Exception ex)
            {

                throw;
            }finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }

        public static DataTable BuscarCuotas(string busqueda)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            MySqlConnection sqlConn = new MySqlConnection();
            try
            {
                sqlConn = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("ObtenerCuotas", sqlConn);
                comando.Parameters.Add("busqueda", MySqlDbType.VarChar).Value = busqueda;
                comando.CommandType = CommandType.StoredProcedure;

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

        public static bool PagarCuota(int idCuota, string medioPago)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            MySqlConnection sqlConn = new MySqlConnection();
            try
            {

                sqlConn = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("PagarCuota", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idCuota", MySqlDbType.Int64).Value = idCuota;
                comando.Parameters.Add("medioPago", MySqlDbType.VarChar).Value = medioPago;

                sqlConn.Open();
                int cantModificaciones = comando.ExecuteNonQuery();

                return cantModificaciones > 0;
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
