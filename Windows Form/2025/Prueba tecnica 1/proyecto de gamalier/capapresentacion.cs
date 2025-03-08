using Capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_de_gamalier
{
    public partial class capapresentacion : Form
    {
        public capapresentacion()
        {
            InitializeComponent();
        }
        private NegocioProductos negocioProductos = new NegocioProductos(); // <-- Agrega esta línea


        private void capapresentacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'libreriaDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.libreriaDataSet.Libros);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_descripcion.Enabled = true;
            txt_precio.Enabled = true;
            txt_stock.Enabled = true;
            cbox_categoria.Enabled = true;
            cbox_medida.Enabled = true;
            btn_agregar.Enabled = false;
            btn_cancelar.Enabled = true;
            btn_guardar.Enabled = true;
            btn_eliminar.Enabled = false;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_descripcion.Enabled = false;
            txt_precio.Enabled = false;
            txt_stock.Enabled = false;
            cbox_categoria.Enabled = false;
            cbox_medida.Enabled = false;
            btn_agregar.Enabled = true;
            btn_cancelar.Enabled = false;
            btn_guardar .Enabled = false;
            btn_eliminar .Enabled = true;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
         







        }
    }
    }

