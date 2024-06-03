using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NicolasCanavese.Modelos;

namespace NicolasCanavese
{
    internal class UsuarioData
    {
        private string? connectionString;

        public static List<_Usuarios> ObtenerUsuario(int Id)
        {
            List<_Usuarios> lista = new List<_Usuarios>();
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "SELECT Id,Nombre,Apellido,NombreUsuario,Constraseña,Mail FROM Usuario WHERE Id=@Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "Id";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = Id;

                    comando.Parameters.Add(parametro);
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new _Usuarios();
                                usuario.Id = Convert.ToInt32(dr["ID"]);
                                usuario.Nombre = dr["Nombres"].ToString();
                                usuario.Apellido = dr["Apellidos"].ToString();
                                usuario.NombreUsuario = dr["NombreUsuarios"].ToString();
                                usuario.Password = dr["Contraseña"].ToString();
                                usuario.Email = dr["Mail"].ToString();
                                lista.Add(usuario);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static List<_Usuarios> ListarUsuarios()
        {
            List<_Usuarios> lista = new List<_Usuarios>();
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario";


            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new _Usuarios();
                                usuario.Id = Convert.ToInt32(dr["Id"]);
                                usuario.Nombre = dr["Nombre"].ToString();
                                usuario.Apellido = dr["Apellido"].ToString();
                                usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                usuario.Password = dr["Contraseña"].ToString();
                                usuario.Email = dr["Mail"].ToString();
                                lista.Add(usuario);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static void CrearUsuario(_Usuarios usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail)" +
                        "VALUES (@Nombre,@Apellido,@NombreUsuario,@Contraseña,@Mail)";

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
                }
                conexion.Close();
            }
        }

        public static void ModificarUsuario(_Usuarios usuario)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "UPDATE Usuario" +
                        "SET Nombre =@Nombre" +
                        ", Apellido = @Apellido" +
                        ", NombreUsuario = @NombreUsuario" +
                        ", Contraseña = @Contraseña" +
                        ", Mail = @Mail" +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
                    comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.Int) { Value = usuario.Password });
                    comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Email });
                }
                conexion.Close();
            }
        }

        public static void EliminarUsuario(_Usuarios usuario)
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
        public _Usuarios GetUserById(int id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuario WHERE id = @id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader[0]);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string nombreUsuario = reader.GetString(3);
                    string password = reader.GetString(4);
                    string email = reader.GetString(5);

                    _Usuarios usuario = new _Usuarios(userId, nombre, apellido, nombreUsuario, password, email);

                    return usuario;
                }
                throw new Exception("Id no fue encontrado");
            }
        }
    }
}

