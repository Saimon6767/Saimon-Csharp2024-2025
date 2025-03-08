namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Sumar_Click(object sender, EventArgs e)
        {
            try
            {

                double numero1 = Convert.ToDouble(num1.Text);
                double numero2 = Convert.ToDouble(num2.Text);


                double suma = numero1 + numero2;
                double restas = numero1 - numero2;
                double multis = numero1 * numero2;
                resultados.Text = suma.ToString();
                resta.Text = restas.ToString();
                mostrarmulti.Text = multis.ToString();
            }
            catch (FormatException)
            {

                MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void resta_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
