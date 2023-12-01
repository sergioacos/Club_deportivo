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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        public string? socio;
        public string? periodo;
        public string? pago_f;
        public float montoFactura;
        public int numeroFactura;
        public DateTime fechaFactura;
        public string? formaFactura;
    }
}
