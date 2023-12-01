using Ingreso_Socios.Datos;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            DataTable dt = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            dt = dato.Login(txtUsuario.Text, txtContrasena.Text);

            if (dt.Rows.Count > 0)
            {
                string nUsuario = dt.Rows[0][1] != null ? dt.Rows[0][1].ToString() : "N/A";
                Form menu = new Menu(nUsuario);
                menu.ShowDialog();

            }
            else
            {
                MessageBox.Show("El usuario y/o contaseña incorrecto ");


            }



        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {

            txtContrasena.UseSystemPasswordChar = true;
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnIngresar.PerformClick();
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Form menu = new Menu("N/A");
            //menu.ShowDialog();

            //Form carnet =  new Carnet(3);
            //carnet.ShowDialog();
        }

    }
}
