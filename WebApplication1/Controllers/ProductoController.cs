using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProducto")]
        public IEnumerable<Producto> Productos()
        {
            return ProductoService.GetProductos();
        }
        [HttpGet("{id}")]
        public IActionResult GetProductoById (int id)
        {
            Producto producto = ProductoService.GetProductById(id);
            return Ok(producto);
        }
        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] int id)
        {
            ProductoService.EliminarProducto(id);
        }
        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] Producto producto)
        {
            ProductoService.ModificarProducto(producto);
        }
        [HttpPost(Name = "AgregarProducto")]
        public void Post([FromBody] Producto producto)
        {
            ProductoService.CrearProducto(producto);
        }
    }
}
