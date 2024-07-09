using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> Venta()
        {
            return VentaService.ListarVentas();
        }
        [HttpGet("{id}")]
        public IActionResult GetProductoById(int id)
        {
            Venta venta = VentaService.ObtenerVenta(id);
            return Ok(venta);
        }
        [HttpDelete(Name = "EliminarVenta")]
        public void Delete([FromBody] int id)
        {
            VentaService.EliminarVenta(id);
        }
        [HttpPut(Name = "ModificarVenta")]
        public void Put([FromBody] Venta venta)
        {
            VentaService.ModificarVenta(venta);
        }
        [HttpPost(Name = "AgregarVenta")]
        public void Post([FromBody] Venta venta)
        {
            VentaService.CrearVenta(venta);
        }
    }
}
