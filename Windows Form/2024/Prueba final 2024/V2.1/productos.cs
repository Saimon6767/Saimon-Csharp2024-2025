using System;
using System.Windows.Forms;

namespace V2._1
{
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }

        private void productos_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(text_nombre.Text);
            int precio = Convert.ToInt32(txt_precio.Text);
            string stock = Convert.ToString(txt_stock);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_nombre.Clear();
            txt_precio.Clear();
            txt_stock.Clear();
            cbox_categoria.Text = "";

            MessageBox.Show("Has limpiado el formulario exitosamente", "realizado");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (txt_precio.Text.Length > 0 && txt_stock.Text.Length > 0 && cbox_categoria.Text.Length > 0 && text_nombre.Text.Length > 0)
            {

                string precio = Convert.ToString(txt_precio.Text);
                string stock = Convert.ToString(txt_stock.Text);
                string nombre = Convert.ToString(text_nombre.Text);
                string categoria = Convert.ToString(cbox_categoria.SelectedItem);

                DialogResult pregunta = MessageBox.Show("¿Deseas guardar estos datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             
                if (pregunta == DialogResult.Yes)
                {
                    DGV_PRODUCTOS.Rows.Add(nombre, categoria, precio, stock);

                }





                else if (pregunta == DialogResult.No)
                {
                    MessageBox.Show("Se cancelo la operacion", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }













            else { MessageBox.Show("Los campos no pueden estar vacios", "errorr", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button3_Click(object sender, EventArgs e)
        {






            if (DGV_PRODUCTOS.Rows.Count > 0)
            {

                int fila = DGV_PRODUCTOS.Rows.Count - 1;

                DGV_PRODUCTOS.Rows.RemoveAt(fila);
                DialogResult eliminar = MessageBox.Show($"Has eliminado un registro ", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("No hay filas para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void btn_salirr_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DGV_PRODUCTOS.ReadOnly = false;
            DGV_PRODUCTOS.AllowUserToDeleteRows = true;
            DGV_PRODUCTOS.AllowUserToAddRows = true;
            DGV_PRODUCTOS.AllowUserToAddRows = true;

            MessageBox.Show("Has activado la edicion de el DataGridView", "Opcion activada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DGV_PRODUCTOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
