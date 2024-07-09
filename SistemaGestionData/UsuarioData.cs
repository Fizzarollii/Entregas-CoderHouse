using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace NicolasCanavese
{
    public class UsuarioData
    {

        public static Usuario ObtenerUsuario(int Id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuario WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["Id"]);
                    string nombre = reader["Nombre"].ToString();
                    string apellido = reader["Apellido"].ToString();
                    string nombreUsuario = reader["NombreUsuario"].ToString();
                    string contraseña = reader["Contraseña"].ToString();
                    string mail = reader["Mail"].ToString();
                    Usuario usuario = new Usuario(userId, nombre, apellido, nombreUsuario, contraseña, mail);
                    return usuario;
                }
                throw new Exception("Id no encontrado");
            }
        }

        public static List<Usuario> ListarUsuarios()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            List<Usuario> listaUsuarios = new List<Usuario>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuario";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.Id = Convert.ToInt32(reader["Id"]);
                            usuario.Nombre = reader["Nombre"].ToString();
                            usuario.Apellido = reader["Apellido"].ToString();
                            usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                            usuario.Password = reader["Contraseña"].ToString();
                            usuario.Email = reader["Mail"].ToString();
                            listaUsuarios.Add(usuario);
                        }
                    }
                }
                return listaUsuarios;
            }
        }

        public static bool CrearUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail)" +
                        "VALUES (@Nombre,@Apellido,@NombreUsuario,@Contraseña,@Mail)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Password });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Email });
                        int rowsAffected = comando.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating user: " + ex.Message);
                return false;
            }
        }

        public static bool ModificarUsuario(int idUsuario , Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Usuario SET Nombre = @Nombre, Apellido = @Apellido, NombreUsuario = @NombreUsuario, Contraseña = @Contraseña, Mail = @Mail WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("Nombre", usuario.Nombre);
                command.Parameters.AddWithValue("Apellido", usuario.Apellido);
                command.Parameters.AddWithValue("NombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("Contraseña", usuario.Password);
                command.Parameters.AddWithValue("Mail", usuario.Email);
                command.Parameters.AddWithValue("Id", idUsuario);


                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static void EliminarUsuario(Usuario usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "DELETE FROM Usuario WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }
    }
}

