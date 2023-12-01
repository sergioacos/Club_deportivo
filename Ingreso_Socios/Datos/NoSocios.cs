using Ingreso_Socios.Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso_Socios.Datos
{
    internal class NoSocios
    {
        public static string NuevoNoSocio(NoSocio nosocio)
        {
            string? salida;
            MySqlConnection sqlConn = new MySqlConnection();
            try
            {
                sqlConn = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoNoSocio", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idP", MySqlDbType.VarChar).Value =
                    0;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value =
                    nosocio.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value =
                    nosocio.Apellido;
                comando.Parameters.Add("Dni", MySqlDbType.Int32).Value =
                    nosocio.Dni;
                comando.Parameters.Add("Fnac", MySqlDbType.Date).Value =
                   nosocio.FechaNac;
                comando.Parameters.Add("Afis", MySqlDbType.Bit).Value =
                   nosocio.AptoFisico;

                MySqlParameter ParCodigo = new MySqlParameter();

                ParCodigo.ParameterName = "rta";

                ParCodigo.MySqlDbType = MySqlDbType.Int32;

                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlConn.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                { sqlConn.Close(); };
            }
            return salida;
        }

        public static bool ValidarIdSocio(int idSocio)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            MySqlConnection sqlConn = new MySqlConnection();
            try
            {
                sqlConn = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("ValidarIdSocio", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idSocio", MySqlDbType.Int64).Value = idSocio;

                sqlConn.Open();
                resultado = comando.ExecuteReader();

                tabla.Load(resultado);
                if (tabla.Rows.Count > 0)
                    return true;
                else
                    return false;
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

        public static DataTable ObtenerSocios()
        {

            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            MySqlConnection sqlConn = new MySqlConnection();
            try
            {
                sqlConn = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("ObtenerSocios", sqlConn);
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

    }
}
