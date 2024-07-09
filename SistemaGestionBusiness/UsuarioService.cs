using NicolasCanavese;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class UsuarioService
    {
        public int Id { get; set; }
        public static List<Usuario> GetUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }
        public static bool EliminarUsuario(int Id)
        {
            return true;
        }

        public static bool CrearUsuario(Usuario usuario)
        {
            return true;
        }

        public static bool ModificarUsuario(Usuario usuario)
        {
            return true;
        }

        public static Usuario GetUsuarioById(int id)
        {
            return UsuarioData.ObtenerUsuario(id);
        }
    }
}