using NicolasCanavese;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoService
    {
        public int Id { get; set; }
        public static List<ProductoVendido> ListarProductoVendidos()
        {
            return ProductoVendidoData.ListarProductoVendidos();
        }
        public static bool EliminarProductoVendido(int Id)
        {
            return true;
        }

        public static bool CrearProductoVendido(ProductoVendido productoVendido)
        {
            return true;
        }

        public static bool ModificarProductoVendido(ProductoVendido productoVendido)
        {
            return true;
        }

        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            return ProductoVendidoData.ObtenerProductoVendido(id);
        }
    }
}
