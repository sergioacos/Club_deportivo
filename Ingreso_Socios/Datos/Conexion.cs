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

        public Conexion() // asignamos valores a las variables de la conexion
        {
// variables usadas para larepetición de líneas de código
            bool correcto = false;
            int mensaje;    /* creamos las variables para recibir los datos desde el teclado
//
============================================================*/
            string T_servidor = "Servidor" ;
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave"; // se antepuso la T para indicar que vienen desde TECLADO
/*
____________________________________________________________
_
* ciclo while para volver a repetir el ingreso de datos
* la variable correcto la inicializamos para ingresar al
ciclo
*
___________________________________________________________*/
        while (correcto != true)
        {
// Armamos los cuadros de dialogo para el ingreso de datos
            T_servidor = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
            T_puerto = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
            T_usuario = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
            T_clave = Microsoft.VisualBasic.Interaction.InputBox
                ("ingrese clave", "DATOS DE INSTALACIÓN MySQL");
                /*
________________________________________________________
________________
* controlamos que los datos ingresados para acceder a
MySQL sean correctos
*
________________________________________________________
__________________ */
             mensaje = (int)MessageBox.Show("su ingreso: SERVIDOR = " +
                T_servidor + " PUERTO= " + T_puerto + " USUARIO: " +
                                T_usuario + " CLAVE: " + T_clave,
                "AVISO DEL SISTEMA", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
            else
                {
                    correcto = true;
                }
            }

            // reemplazamos los datos concretos que teniamos por las variables


            this.baseDatos = "proyecto";
            this.servidor = T_servidor;
            this.puerto = T_puerto;
            this.usuario = T_usuario;
            this.clave = T_clave;
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
