using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_con_base_de_datos
{
    public partial class Form1 : Form
    {
        private readonly LibrosNegocio negocio = new LibrosNegocio();

        public Form1()
        {
            InitializeComponent();
        }

        // Evento para cargar datos al iniciar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void CargarLibros()
        {
            dgvLibros.DataSource = negocio.ObtenerTodos();
        }

        // Evento para agregar un libro
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreLibro.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (negocio.Agregar(txtNombreLibro.Text, txtCategoria.Text))
            {
                MessageBox.Show("Libro agregado correctamente.");
                CargarLibros();
            }
            else
            {
                MessageBox.Show("Error al agregar el libro.");
            }
        }

        // Evento para eliminar un libro
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells["ID"].Value);
                if (negocio.Eliminar(id))
                {
                    MessageBox.Show("Libro eliminado correctamente.");
                    CargarLibros();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el libro.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un libro para eliminar.");
            }
        }

        // Evento para buscar un libro por ID
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                DataTable resultado = negocio.BuscarPorID(id);
                if (resultado.Rows.Count > 0)
                {
                    dgvLibros.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún libro con ese ID.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }
    }
}
