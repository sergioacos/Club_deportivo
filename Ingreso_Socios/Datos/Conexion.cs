﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Ingreso_Socios.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        public Conexion() 
        {
            this.baseDatos = "proyecto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "proyecto";
            this.clave = "1234";
        }
        // proceso de interacción
        public MySqlConnection CrearConexion()
            {
                
                MySqlConnection? cadena = new MySqlConnection();
                
                try
                {
                    cadena.ConnectionString = "datasource=" + this.servidor +
                    ";port=" + this.puerto +
                    ";username=" + this.usuario +
                    ";password=" + this.clave +
                    ";Database=" + this.baseDatos;
            }
                catch (MySqlException ex)
                {
                MessageBox.Show("no sepudo conectar"+ex.ToString());/*agregue*/
                    cadena = null;
                    throw;
                }
                return cadena;
            }
            // para evaluar la instancia de la conectividad
            public static Conexion getInstancia()
            {
                if (con == null) // quiere decir que la conexion esta cerrada
                {
                    con = new Conexion(); // se crea una nueva
                }
                return con;
            }
       

}
}
