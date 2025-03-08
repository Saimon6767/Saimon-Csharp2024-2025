using System.Data;

namespace Proyecto_con_base_de_datos
{
    public class LibrosNegocio
    {
        private readonly CapaDatos datos = new CapaDatos(); // Uso de la capa de datos como referencia

        // Método para obtener todos los libros
        public DataTable ObtenerTodos()
        {
            return datos.ObtenerLibros();
        }

        // Método para agregar un libro
        public bool Agregar(string nombre, string categoria)
        {
            return datos.AgregarLibro(nombre, categoria);
        }

        // Método para eliminar un libro por ID
        public bool Eliminar(int id)
        {
            return datos.EliminarLibro(id);
        }

        // Método para buscar un libro por ID
        public DataTable BuscarPorID(int id)
        {
            return datos.BuscarLibroPorID(id);
        }
    }
}
