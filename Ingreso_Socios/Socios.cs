namespace Ingreso_Socios
{
    public partial class Socios : Form
    {
        public Socios()
        {
            InitializeComponent();
        }

        private void lblNomSocio_Click(object sender, EventArgs e)
        {

        }

        private void lblDNI_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFechaN_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "")
            {
                MessageBox.Show("Debe comletar los datos requeridos(*)",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Datos.Conexion conexion1 = new Datos.Conexion();
                conexion1.CrearConexion();

                String respuesta;
                Socio socio = new Socio();
                socio.Nombre = txtNombre.Text;
                socio.Apellido = txtApellido.Text;
                socio.Dni = Convert.ToInt32(txtDni.Text);
                socio.FechaNac = Convert.ToDateTime(dateTimePickerFechaN.Text);
                socio.AptoFisico = chkAptoFisico.Checked;
                //socio.Cuotas = Convert.cboCuota.Text;
                Datos.Socios socios = new Datos.Socios();
                respuesta = socios.Nuevo_Socio(socio);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 0)
                    {
                        MessageBox.Show("SOCIO YA EXISTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se almaceno con exito el socio Nro " + respuesta, "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Form pagos = new Pagos();
                        pagos.ShowDialog();
                        //this.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Socios_Load(object sender, EventArgs e)
        {

        }
    }
}