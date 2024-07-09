using NicolasCanavese;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaService
    {
        public int Id { get; set; }
        public static List<Venta> ListarVentas()
        {
            return VentaData.ListarVentas();
        }
        public static bool EliminarVenta(int Id)
        {
            return true;
        }

        public static bool CrearVenta(Venta venta)
        {
            return true;
        }

        public static bool ModificarVenta(Venta venta)
        {
            return true;
        }

        public static Venta ObtenerVenta(int id)
        {
            return VentaData.ObtenerVenta(id);
        }
    }
}
