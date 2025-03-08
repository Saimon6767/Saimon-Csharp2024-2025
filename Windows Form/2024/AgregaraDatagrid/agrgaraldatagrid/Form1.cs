namespace Vorm_badelyn
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int idp = (Convert.ToInt32(cmbox_idcodigo.Text));
            string alim = (cmbox_alimentos.Text.Trim());
            string coms = (cmbox_comestibles.Text.Trim());
           
            dtgw_tabla.Rows.Add(idp, alim, coms);    
        }
    }
}
