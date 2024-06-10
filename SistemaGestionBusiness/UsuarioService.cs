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
        public static List<Usuario> ListarUsuarios()
        {
            return new List<Usuario>();
        }
        public static bool EliminarUsuario(int Id)
        {
            return true;
        }

        public static bool CrearUsuario(Usuario usuario)
        {
            return true;
        }

        public static bool ModificarUsuario(int Id, Usuario usuario)
        {
            return true;
        }

        public static Usuario ObtenerUsuario(int Id)
        {
            return new Usuario();
        }
    }
}