using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoService
    {
        public int Id { get; set; }
        public static List<Producto> ListarProductos()
        {
            return new List<Producto>();
        }
        public static bool EliminarProducto(int Id)
        {
            return true;
        }

        public static bool CrearProducto(Producto producto)
        {
            return true;
        }

        public static bool ModificarProducto(int Id, Producto producto)
        {
            return true;
        }

        public static Producto ObtenerProducto(int Id)
        {
            return new Producto();
        }
    }
}
