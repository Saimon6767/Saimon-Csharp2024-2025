using System;
using System.Data;
using System.Data.SqlClient;

namespace capadatos { 
public class Conexion
{
    private string Base;
    private string Servidor;
    private string Usuario;
    private string Clave;
    private static Conexion cn = null;

    private Conexion()
    {
        this.Servidor = "DESKTOP-MQCBPA3";
        this.Base = "bd_ventas";
    }

    public static Conexion GetInstance()
    {
        if (cn == null)
        {
            cn = new Conexion();
        }
        return cn;
    }

    public SqlConnection GetSqlConnection()
    {
        SqlConnection cadena = new SqlConnection();
        try
        {

            cadena.ConnectionString = $"Server={this.Servidor};Database={this.Base};Integrated Security=True;";

            cadena.Open();
            Console.WriteLine("Conexión exitosa");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
        }
        return cadena;
    }
}
public class DatosProductos
{
        public string GuardarProducto(int opcion, int idProd, string descripcion, int idCategoria, int idMedida, decimal precio, int stock)
        {
            string respuesta = "";

            try
            {
                using (SqlConnection conn = Conexion.GetInstance().GetSqlConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("guardar_productos", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Opcion", opcion);
                        cmd.Parameters.AddWithValue("@id_prod", idProd);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
                        cmd.Parameters.AddWithValue("@id_medida", idMedida);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@Stock", stock);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        respuesta = filasAfectadas > 0 ? "Operación realizada con éxito." : "No se realizó ninguna modificación.";
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = "Error: " + ex.Message;
            }

            return respuesta;
        }   }
}