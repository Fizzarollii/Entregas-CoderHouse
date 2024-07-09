using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductoVendido")]
        public IEnumerable<ProductoVendido> ProductoVendido()
        {
            return ProductoVendidoService.ListarProductoVendidos();
        }
        [HttpGet("{id}")]
        public IActionResult GetProductoById(int id)
        {
            ProductoVendido productoVendido = ProductoVendidoService.ObtenerProductoVendido(id);
            return Ok(productoVendido);
        }
        [HttpDelete(Name = "EliminarProductoVendido")]
        public void Delete([FromBody] int id)
        {
            ProductoVendidoService.EliminarProductoVendido(id);
        }
        [HttpPut(Name = "ModificarProductoVendido")]
        public void Put([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoService.ModificarProductoVendido(productoVendido);
        }
        [HttpPost(Name = "AgregarProductoVendido")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoService.CrearProductoVendido(productoVendido);
        }
    }
}
