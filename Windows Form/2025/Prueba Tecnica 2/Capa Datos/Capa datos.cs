using CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{



    public class CD_Facturas
    {
        private string conexion = "Server=DESKTOP-MQCBPA3;Database=ProductosGenerales;Integrated Security=True";

      


        public DataTable ObtenerFacturasActivas()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(conexion))
                    
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("ObtenerFacturasActivas", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las facturas activas: " + ex.Message);
            }
        }

       
    }



















































    public class CD_Productos
    {
        private string conexion = "Server=DESKTOP-MQCBPA3;Database=ProductosGenerales;Integrated Security=True";

        public DataTable BuscarProductos(string nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_BuscarProductosActivos", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", nombre);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar productos: " + ex.Message);
            }
            return dt;
        }

        public DataTable ObtenerProductosPorCategoria()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("ObtenerProductosPorCategoria", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener productos por categoría: " + ex.Message);
            }
        }

        public void MarcarProductoInactivo(int idProducto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("MarcarProductoInactivo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", idProducto);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al marcar el producto como inactivo: " + ex.Message);
            }
        }

        public void InsertarProducto(Producto producto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();

                    string queryDesc = "INSERT INTO Descripcion (Precio, Categoria, Medida, Estado) OUTPUT INSERTED.ID_Descripcion VALUES (@Precio, @Categoria, @Medida, 1)";
                    int idDescripcion;

                    using (SqlCommand cmd = new SqlCommand(queryDesc, con))
                    {
                        cmd.Parameters.AddWithValue("@Precio", producto.Descripcion.Precio);
                        cmd.Parameters.AddWithValue("@Categoria", producto.Descripcion.Categoria);
                        cmd.Parameters.AddWithValue("@Medida", producto.Descripcion.Medida);
                        idDescripcion = (int)cmd.ExecuteScalar();
                    }

                    string queryProd = "INSERT INTO Productos (Nombre, ID_Descripcion, Stock, Estado) VALUES (@Nombre, @ID_Descripcion, @Stock, 1)";
                    using (SqlCommand cmd = new SqlCommand(queryProd, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                        cmd.Parameters.AddWithValue("@ID_Descripcion", idDescripcion);
                        cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar producto: " + ex.Message);
            }
        }

        public void InsertarProducto(string nombre, decimal precio, int stock, string medida, string categoria)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string queryDesc = "INSERT INTO Descripcion (Precio, Categoria, Medida, Estado) OUTPUT INSERTED.ID_Descripcion VALUES (@Precio, @Categoria, @Medida, 1)";
                    int idDescripcion;

                    using (SqlCommand cmd = new SqlCommand(queryDesc, con))
                    {
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@Categoria", categoria);
                        cmd.Parameters.AddWithValue("@Medida", medida);
                        idDescripcion = (int)cmd.ExecuteScalar();
                    }

                    string queryProd = "INSERT INTO Productos (Nombre, ID_Descripcion, Stock, Estado) VALUES (@Nombre, @ID_Descripcion, @Stock, 1)";
                    using (SqlCommand cmd = new SqlCommand(queryProd, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@ID_Descripcion", idDescripcion);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar producto: " + ex.Message);
            }
        }


    }
}