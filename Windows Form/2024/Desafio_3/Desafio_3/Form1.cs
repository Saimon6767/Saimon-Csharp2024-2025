using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desafio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        class reserva
        {

            public string cliente { get; set; }

            public string desde { get; set; }

            public string hasta { get; set; }

            public string tipohabitacion { get; set; }

            public int precio { get; set; }



        }

        reserva Reserva = new reserva();



        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {


            Reserva.cliente = txt_nombre.Text;
            Reserva.desde = dtmpkr_desde.Text;
            Reserva.hasta = txxt_hasta.Text;
            Reserva.tipohabitacion = cbox_TipoHabitacion.Text;
            int precio = (Convert.ToInt32(txt_precio.Text));
            Reserva.precio = precio;

            lbox_reserva.Items.Add($"El cliente es:{Reserva.cliente}");
            lbox_reserva.Items.Add($"El Reservo el:{Reserva.desde}");
            lbox_reserva.Items.Add($"El reservo hasta:{Reserva.hasta}");
            lbox_reserva.Items.Add($"El cliente reservo una habitacion tipo:{Reserva.tipohabitacion}");
            lbox_reserva.Items.Add($"El monto a pagar es:{Reserva.precio}");

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_precio.Clear();

            txt_nombre.Clear();
          
            cbox_TipoHabitacion.Items.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbox_reserva.Items.Clear();
        }
    }
}
