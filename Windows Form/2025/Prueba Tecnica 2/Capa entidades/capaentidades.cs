using System;

namespace CapaEntidades
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Descripcion Descripcion { get; set; }
        public int Stock { get; set; }
        public bool Estado { get; set; } 
    }

   
    public class Descripcion
    {
        public int ID_Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public string Medida { get; set; }
        public bool Estado { get; set; } // 1 = Activo, 0 = Inactivo
    }
}
