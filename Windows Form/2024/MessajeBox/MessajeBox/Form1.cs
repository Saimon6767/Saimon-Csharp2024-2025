


namespace MessajeBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int nu = Convert.ToInt32(textBox1.Text);

            if (nu > 5)
            {
                MessageBox.Show($"Perfecto, eres inteligente por ingresar el {nu} ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (nu < 5)
            {
                MessageBox.Show($"que bruto desde cuando el {nu} es menor a 5? ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (nu == 5)
            {
                MessageBox.Show($"se te especifico uno mayor pendejo uno mayor a 5 ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            DialogResult resul = MessageBox.Show("¿Quieres escribir Hola en el TextBox?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resul == DialogResult.Yes)
            {
                textBox2.Text = "hola xd";
            }

            else if (resul == DialogResult.No)
            {
                MessageBox.Show("no se mostrara nada", "valla...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();


            string nombredelarchivo = openFileDialog1.FileName;

            string leerarchivo = File.ReadAllText(nombredelarchivo);

            richTextBox1.Text = leerarchivo;

          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
