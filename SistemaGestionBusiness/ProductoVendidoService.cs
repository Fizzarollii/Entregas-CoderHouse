using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    internal class ProductoVendidoService
    {
        public int Id { get; set; }
        public static List<PR> ListarProductoVendidos()
        {
            return new List<PR>();
        }
        public static bool EliminarProductoVendido(int Id)
        {
            return true;
        }

        public static bool CrearProductoVendido(PR productoVendido)
        {
            return true;
        }

        public static bool ModificarProductoVendido(int Id, PR productoVendido)
        {
            return true;
        }

        public static PR ObtenerProductoVendido(int Id)
        {
            return new PR();
        }
    }
}
