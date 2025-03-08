namespace desafio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RA3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            int totalnotas;
            int n1 = (Convert.ToInt32(RA1.Text));
            int n2 = (Convert.ToInt32(RA2.Text));
            int n3 = (Convert.ToInt32(RA3.Text));
            int n4 = (Convert.ToInt32(RA4.Text));

            totalnotas = n1 + n2 + n3 + n4;
            int je = 4;
            int totalnotas2 = totalnotas / je;

            txt_total.Text = totalnotas2.ToString();

            if (totalnotas2 > 70)
            {
                txt_estado.BackColor = Color.Green;
                txt_estado.Text = "El estudiante aprobo";

            }

            else
            {
                txt_estado.BackColor = Color.Red;
                txt_estado.Text = "El estudiante no aprobo";
            }

        }

        private void borrartodo_Click(object sender, EventArgs e)
        {
            txt_estado.Clear();
            RA1.Clear();
            RA2.Clear();
            RA3.Clear();
            RA4.Clear();
            textBox1.Clear();
            txt_total.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
