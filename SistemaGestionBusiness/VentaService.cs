using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    internal class VentaService
    {
        public int Id { get; set; }
        public static List<Sell> ListarVentas()
        {
            return new List<Sell>();
        }
        public static bool EliminarVenta(int Id)
        {
            return true;
        }

        public static bool CrearVenta(Sell venta)
        {
            return true;
        }

        public static bool ModificarVenta(int Id, Sell venta)
        {
            return true;
        }

        public static Sell ObtenerVenta(int Id)
        {
            return new Sell();
        }
    }
}
