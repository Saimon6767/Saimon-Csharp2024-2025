using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_con_base_de_datos
{
    public class CapaDatos
    {
        private readonly string conexionString = "Server=DESKTOP-MQCBPA3;Database=Biblioteca;Trusted_Connection=True;";

        // Método para obtener todos los registros de la tabla Libros
        public DataTable ObtenerLibros()
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string query = "SELECT * FROM Libros";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable tablaLibros = new DataTable();
                adapter.Fill(tablaLibros);
                return tablaLibros;
            }
        }

        // Método para agregar un libro
        public bool AgregarLibro(string nombre, string categoria)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string query = "INSERT INTO Libros (Nombre, Categoria) VALUES (@Nombre, @Categoria)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Categoria", categoria);
                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
            }
        }

        // Método para eliminar un libro por ID
        public bool EliminarLibro(int id)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string query = "DELETE FROM Libros WHERE ID = @ID";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ID", id);
                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
            }
        }

        // Método para buscar un libro por ID
        public DataTable BuscarLibroPorID(int id)
        {
            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                string query = "SELECT * FROM Libros WHERE ID = @ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                adapter.SelectCommand.Parameters.AddWithValue("@ID", id);
                DataTable libroEncontrado = new DataTable();
                adapter.Fill(libroEncontrado);
                return libroEncontrado;
            }
        }
    }
}
