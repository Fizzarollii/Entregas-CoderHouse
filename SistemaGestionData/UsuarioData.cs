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

        public static List<Usuario.Usuarios> ObtenerUsuario(int Id)
        {
            List<Usuario.Usuarios> lista = new List<Usuario.Usuarios>();
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
                                var usuario = new Usuario.Usuarios();
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

        public static List<Usuario.Usuarios> ListarUsuarios()
        {
            List<Usuario.Usuarios> lista = new List<Usuario.Usuarios>();
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
                                var usuario = new Usuario.Usuarios();
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

        public static void CrearUsuario(Usuario.Usuarios usuario)
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
                    comando.ExecuteNonQuery();
                }
            }
        }

        public static void ModificarUsuario(Usuario.Usuarios usuario)
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
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        public static void EliminarUsuario(Usuario.Usuarios usuario)
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

