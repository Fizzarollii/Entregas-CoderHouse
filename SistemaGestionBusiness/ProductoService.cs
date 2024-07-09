using NicolasCanavese;
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
        public static List<Producto> GetProductos()
        {
            return ProductoData.ListarProductos();
        }
        public static bool EliminarProducto(int Id)
        {
            return true;
        }

        public static bool CrearProducto(Producto producto)
        {
            return true;
        }

        public static bool ModificarProducto(Producto producto)
        {
            return true;
        }

        public static Producto GetProductById(int id)
        {
            return ProductoData.ObtenerProducto(id);
        }
    }
}
