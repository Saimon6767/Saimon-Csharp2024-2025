using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Windows.Forms;

namespace desafio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CalculateColumnMultiplication()
        {



        }





        private void button1_Click(object sender, EventArgs e)
        {


            double total1 = 0;



            total1 = 0;


            foreach (DataGridViewRow row in dgv_productos.Rows)
            {


                if (row.Cells["Precio"].Value != null && row.Cells["Cantidad"].Value != null &&
                    double.TryParse(row.Cells["Precio"].Value.ToString(), out double value1) &&
                    double.TryParse(row.Cells["Cantidad"].Value.ToString(), out double value2))
                {

                    total1 += value1 * value2;
                }

                else
                {

                    double valor1 = Convert.ToInt32(row.Cells["Precio"].Value);



                    total1 += valor1;
                }

            }


            labelTotal.Text = $"{total1}";



            dgv_productos.Rows.Add(cbox_productos.Text, txt_precioproducto.Text, txt_cantidadproducto.Text, txt_ID_Poducto.Text);





        }

        private void cbox_productos_SelectedIndexChanged(object sender, EventArgs e)
        {









            string itemseleccionado = cbox_productos.SelectedItem.ToString();


            if (itemseleccionado == "refresco de piña")
            {
                int prex = 400;
                int id = 3345654;
                txt_precioproducto.Text = $"{prex}";
                txt_ID_Poducto.Text = $"{id}";
            }

            if (itemseleccionado == "botella de agua")
            {
                int prex = 100;
                int id = 5645655;
                txt_precioproducto.Text = $"{prex}";
                txt_ID_Poducto.Text = $"{id}";
            }

            if (itemseleccionado == "malta morena")
            {
                int prex = 350;
                int id = 1112654;
                txt_precioproducto.Text = $"{prex}";
                txt_ID_Poducto.Text = $"{id}";
            }

            if (itemseleccionado == "cerveza presidente")
            {

                int prex = 700;
                int id = 88812654;
                txt_precioproducto.Text = $"{prex}";
                txt_ID_Poducto.Text = $"{id}";
            }

        }

        private void txt_cantidadproducto_TextChanged(object sender, EventArgs e)
        {

        }



        private void btn_facturar_Click(object sender, EventArgs e)
        {




            int laide = int.Parse(txt_nfactura.Text);


            for (int i = 0; i < 1; i++)
            {
                laide++;
            }


            txt_nfactura.Text = laide.ToString();
        }

     

        private void btn_guardarfactura_Click(object sender, EventArgs e)
        {
            string datos = dgv_productos.Columns.ToString();
            TextWriter archi = new StreamWriter("C:\\Users\\Ainz\\Documents\\Windows Forms\\ factura.txt");
            archi.WriteLine(txt_nfactura.Text);
            archi.WriteLine($"Fecha de la factura:{dateTimePicker1.Text}");
            archi.WriteLine($"{datos}");

        }
    }
}
