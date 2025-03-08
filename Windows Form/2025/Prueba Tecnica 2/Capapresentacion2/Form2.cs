using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;

namespace Capapresentacion2
{
    public partial class Form2 : Form
    {

        private CN_Facturas objNegocioFacturas = new CN_Facturas();
        private int idProductoSeleccionado;

        public Form2()
        {
            InitializeComponent();
            dgv_verfacturas.DataSource = objNegocioFacturas.ObtenerFacturasActivas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
