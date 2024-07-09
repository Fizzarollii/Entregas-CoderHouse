using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuario")]
        public IEnumerable<Usuario> Usuarios()
        {
            return UsuarioService.GetUsuarios();
        }
        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            Usuario usuario = UsuarioService.GetUsuarioById(id);
            return Ok(usuario);
        }
        [HttpDelete(Name = "EliminarCliente")]
        public void Delete([FromBody] int id)
        {
            UsuarioService.EliminarUsuario(id);
        }
        [HttpPut(Name = "ModificarCliente")]
        public void Put([FromBody] Usuario usuario)
        {
            UsuarioService.ModificarUsuario(usuario);
        }
        [HttpPost(Name = "AgregarCliente")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioService.CrearUsuario(usuario);
        }
    }
}
