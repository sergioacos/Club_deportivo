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
    public partial class Menu : Form
    {
        private string nombreUsuario;
        public Menu(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            lblUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void Menu_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form clientes = new Clientes();
            clientes.ShowDialog();
            
            
        }

        private void btnASocio_Click(object sender, EventArgs e)
        {
            Form socios = new Socios();
            socios.ShowDialog();
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            Form actividades = new Actividades();
            actividades.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            Form pagos = new Pagos();
            pagos.ShowDialog();
        }
    }
}
