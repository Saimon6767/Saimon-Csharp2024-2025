using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Windows.Forms;

namespace Textos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        class Objeto
        {
            public string hola { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {


       


            TextWriter archivo = new StreamWriter("C:/Users/Ainz/Documents/Archivos de texto de wf/miprimerarchivo.txt");
       
            archivo.WriteLine(textBox1.Text);
        
            archivo.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string libox = textBox2.Text;
            listBox1.Items.Add($"se agrego el anime: {libox}");
            listBox1.Items.Add($"");
        }
    }
}
