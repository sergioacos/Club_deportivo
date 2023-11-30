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
    internal class Socios
    {
        public static string NuevoSocio(Socio socio)
        {
            string? salida;
            MySqlConnection sqlConn = new MySqlConnection();
            try
            {
                sqlConn = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoSocio", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idP", MySqlDbType.VarChar).Value =
                    0;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value =
                    socio.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value =
                    socio.Apellido;
                comando.Parameters.Add("Dni", MySqlDbType.Int32).Value =
                    socio.Dni;
                comando.Parameters.Add("Fnac", MySqlDbType.Date).Value =
                   socio.FechaNac;
                comando.Parameters.Add("Afis", MySqlDbType.Bit).Value =
                   socio.AptoFisico;

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

                MySqlCommand comando = new MySqlCommand("ObtenerSocioPorId", sqlConn);
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

        public static Socio? ObtenerPorId(int idSocio) {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            MySqlConnection sqlConn = new MySqlConnection();
            try
            {
                sqlConn = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("ObtenerSocioPorId", sqlConn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idSocio", MySqlDbType.Int64).Value = idSocio;

                sqlConn.Open();
                resultado = comando.ExecuteReader();

                tabla.Load(resultado);
                if (tabla.Rows.Count == 1)
                {
                    Socio socio  = new Socio();
                    socio.Nombre = tabla.Rows[0]["nombre"].ToString();
                    socio.Apellido = tabla.Rows[0]["apellido"].ToString();
                    socio.Dni = Convert.ToInt32(tabla.Rows[0]["dni"].ToString());
                    socio.FechaNac = Convert.ToDateTime(tabla.Rows[0]["fechaNac"].ToString());
                    socio.AptoFisico = Convert.ToBoolean(tabla.Rows[0]["aptoFisico"].ToString());
                    socio.IdSocio = Convert.ToInt32(tabla.Rows[0]["idSocio"].ToString());
                    socio.IdPersona = Convert.ToInt32(tabla.Rows[0]["idPersona"].ToString());

                    return socio;
                }
                else
                    return null;
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
