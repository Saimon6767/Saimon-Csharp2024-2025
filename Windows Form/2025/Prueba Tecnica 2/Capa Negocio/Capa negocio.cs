using System;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{


























    public class CN_Facturas
    {
        private CD_Facturas objDatos = new CD_Facturas();

     


        public DataTable ObtenerFacturasActivas()
        {
            return objDatos.ObtenerFacturasActivas();
        }

    
      


    }




























































    public class CN_Productos
    {
        private CD_Productos objDatos = new CD_Productos();

        public DataTable BuscarProductos(string nombre)
        {
            return objDatos.BuscarProductos(nombre);
        }

        public string MarcarProductoInactivo(int idProducto)
        {
            objDatos.MarcarProductoInactivo(idProducto);
            return "Producto marcado como inactivo exitosamente";
        }

        public DataTable ObtenerProductosPorCategoria()
        {
            return objDatos.ObtenerProductosPorCategoria();
        }

        public string AgregarProducto(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre) || !char.IsUpper(producto.Nombre[0]))
                return "El nombre debe comenzar con mayúscula.";

            if (producto.Descripcion.Precio <= 0)
                return "El precio debe ser un número válido.";

            if (producto.Stock < 0)
                return "El stock debe ser un número entero válido.";

            objDatos.InsertarProducto(producto);
            return "Producto agregado correctamente.";
        }

        public string AgregarProducto(string nombre, decimal precio, int stock, string medida, string categoria)
        {
            if (string.IsNullOrWhiteSpace(nombre) || !char.IsUpper(nombre[0]))
                return "El nombre debe comenzar con mayúscula.";

            if (precio <= 0)
                return "El precio debe ser un número válido.";

            if (stock < 0)
                return "El stock debe ser un número entero válido.";

            objDatos.InsertarProducto(nombre, precio, stock, medida, categoria);
            return "Producto agregado correctamente.";
        }
    }
}
