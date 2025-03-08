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
using CapaNegocio;

namespace Capapresentacion2
{
    public partial class Capapresentacion : Form
    {
        private CN_Productos objNegocio = new CN_Productos();
        public Capapresentacion()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_precio.Clear();
            txt_stock.Clear();
            cbox_categoria.Text = "";
            cbox_medida.Text = "";
            txt_buscar.Clear();
        }

        private void btn_guardadmedicamento_Click_1(object sender, EventArgs e)
        {

            Producto nuevoProducto = new Producto()
            {
                Nombre = txt_nombre.Text.Trim(),
                Descripcion = new Descripcion()
                {
                    Precio = decimal.Parse(txt_precio.Text.Trim()),
                    Categoria = cbox_categoria.Text,
                    Medida = cbox_medida.Text
                },
                Stock = int.Parse(txt_stock.Text.Trim()),
                Estado = true
            };

            string resultado = objNegocio.AgregarProducto(nuevoProducto);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_buscados.DataSource = objNegocio.BuscarProductos("");
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_buscados.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dgv_buscados.SelectedRows[0].Cells["ID"].Value);
                string resultado = objNegocio.MarcarProductoInactivo(idProducto);
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_buscados.DataSource = objNegocio.BuscarProductos("");
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_actualiza_Click_1(object sender, EventArgs e)
        {
            dgv_buscados.DataSource = objNegocio.BuscarProductos("");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ordenarpor_Click_1(object sender, EventArgs e)
        {
            label3.Visible = false;
            btn_actualiza.Visible = false;
            btn_ordenarpor.Visible = false;
            btn_ordenarporcategoria.Visible = true;
            btn_ordenarporid.Visible = true;
        }

        private void btn_ordenarporcategoria_Click(object sender, EventArgs e)
        {




            label3.Visible = true;
            btn_actualiza.Visible = true;
            btn_ordenarporid.Visible = false;
            btn_ordenarpor.Visible = true;
            btn_ordenarporcategoria.Visible = false;
            dgv_buscados.DataSource = objNegocio.ObtenerProductosPorCategoria();
        }

        private void btn_ordenarporid_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            btn_actualiza.Visible = true;
            btn_ordenarporid.Visible = false;
            btn_ordenarpor.Visible = true;
            btn_ordenarporcategoria.Visible = false;
            dgv_buscados.DataSource = objNegocio.BuscarProductos("");
        }

        private void Capapresentacion_Load(object sender, EventArgs e)
        {
          
        }

        private void txt_buscar_TextChanged_2(object sender, EventArgs e)
        {
            string texto = txt_buscar.Text.Trim();
            dgv_buscados.DataSource = objNegocio.BuscarProductos(texto);
        }
    }
}
