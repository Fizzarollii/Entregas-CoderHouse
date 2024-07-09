using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Usuario() { }

        public Usuario(string nombre, string apellido, string nombreUsuario, string password, string email)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Password = password;
            this.Email = email;
        }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string password, string email)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Password = password;
            this.Email = email;
        }

        public override string ToString()
        {
            return $"ID = {this.Id} - Nombre = {this.Nombre} - Apellido = {this.Apellido} - NombreUsuario = {this.NombreUsuario} - Password = {this.Password} - Email = {this.Email}";
        }
    }
}
