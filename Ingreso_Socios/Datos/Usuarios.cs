using Ingreso_Socios.BD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso_Socios.Datos
{
    internal class Usuarios
    {
        public DataTable Login(string nombre, string contrasena)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            
            MySqlConnection sqlConn = new MySqlConnection();
            try
            {

                sqlConn = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlConn);

                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = contrasena;

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
