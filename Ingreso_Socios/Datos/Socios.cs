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
        public string Nuevo_Socio(Socio socio)
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
    }
}
