using System.Web;
using System.IO;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //openFileDialog.HelpRequest += (sender, e) => 
        //  {
        //     MessageBox.Show("Aquí puedes seleccionar un archivo.");
        //  };
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_abrirarchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "seleccionar un archivo",
                Filter = "seleccionar archivos de extencion txt: |*.txt",
                ShowHelp = true,
            };

            openFileDialog.HelpRequest += (Sender, E) =>
            {

                MessageBox.Show("selecciona un archivo de texto");

            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string archivo = openFileDialog.FileName;
                string texto = File.ReadAllText(archivo);

                rtb_texto.Text = texto;
            }


        }

        private void rtb_texto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public class Empleado
        {

            public string nombre { get; set; }
            public string cargo { get; set; }

            public int sueldo { get; set; }

            public int hijos { get; set; }

            public int total { get; set; }

            public double sueldoneto { get; set; }

        };

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            empleado.nombre = txt_nombre.Text;
            empleado.cargo = cbox_cargo.Text;
            empleado.sueldo = Convert.ToInt32(txt_sueldo.Text);
            empleado.hijos = Convert.ToInt32(txt_hijos.Text);


            for (int i = 0; i < Convert.ToInt32(txt_hijos.Text); i++)
            {
                empleado.sueldo = empleado.sueldo + 500;


            }

            txt_total.Text = $"{empleado.sueldo}";



            double palomo = Convert.ToDouble(txt_total.Text);

            double afprte = empleado.sueldo * 0.0287;
            double sfsrte = empleado.sueldo * 0.0304;
            double isrrte = empleado.sueldo * 0.0344;




            txt_isr.Text = afprte.ToString();
            txt_sfs.Text = sfsrte.ToString();
            txt_afp.Text = isrrte.ToString();



            double totalddd = afprte + sfsrte + isrrte;




            txt_tota.Text = totalddd.ToString();

            empleado.sueldoneto = empleado.sueldo - totalddd;

            txt_sueldoneto.Text = $"{empleado.sueldoneto}";



        }

        private void cbox_cargo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbox_cargo.Text == "Limpieza")
            {
                txt_sueldo.Text = "23000";
            }

            else if (cbox_cargo.Text == "Administracion")
            {
                txt_sueldo.Text = "28000";
            }

            else if (cbox_cargo.Text == "Limpieza")
            {
                txt_sueldo.Text = "25000";
            }

            else if (cbox_cargo.Text == "Caja")
            {
                txt_sueldo.Text = "27000";
            }

            else if (cbox_cargo.Text == "Gerente")
            {
                txt_sueldo.Text = "210000";
            };

        }

        private void btn_r_Click(object sender, EventArgs e)
        {


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {





        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();


            dgv_elementos.Rows.Add(txt_nombre.Text, cbox_cargo.Text, txt_hijos.Text, txt_sueldoneto.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string em = cbox_cargo.Text;
            TextWriter teto = new StreamWriter("C:\\Users\\Ainz\\Documents\\Windows Forms\\ registro.txt");
            teto.WriteLine("====================================================");
            teto.WriteLine ("EMPLEADO");
            teto.WriteLine("====================================================");
            teto.WriteLine($"nombre: {txt_nombre.Text} ");
            teto.WriteLine($"Cargo: {em} ");
            teto.WriteLine($"Hijos: {txt_hijos.Text} ");
            teto.WriteLine($"sueldo: {txt_sueldoneto.Text} ");
            teto.Close();
            MessageBox.Show("Has guardado el registro");

        }

        private void txt_tota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
