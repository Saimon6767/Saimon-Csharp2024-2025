using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;

namespace Capa_negocio
{
    public class NegocioProductos
    {
        public string GuardarProducto(int opcion, int idProd, string descripcion, int idCategoria, int idMedida, decimal precio, int stock)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                return "La descripción no puede estar vacía.";
          
            if (precio <= 0)
                return "El precio debe ser mayor a 0.";
            if (stock < 0)
                return "El stock no puede ser negativo.";

            DatosProductos datos = new DatosProductos();
            return datos.GuardarProducto(opcion, idProd, descripcion, idCategoria, idMedida, precio, stock);
        }
    }

}
