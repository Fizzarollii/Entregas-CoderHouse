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
    public class VentaData
    {
        public static Venta ObtenerVenta(int Id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Venta WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int ventaId = Convert.ToInt32(reader["Id"]);
                    string comentarios = reader["Comentarios"].ToString();
                    int idUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    Venta venta = new Venta(ventaId, comentarios, idUsuario);
                    return venta;
                }
                throw new Exception("Id no encontrado");
            }
        }

        public static List<Venta> ListarVentas()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            List<Venta> listaVentas = new List<Venta>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Venta";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venta venta = new Venta();
                            venta.Id = Convert.ToInt32(reader["Id"]);
                            venta.Comentarios = reader["Comentarios"].ToString();
                            venta.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                            listaVentas.Add(venta);
                        }
                    }
                }
                return listaVentas;
            }
        }

        public static bool CrearVenta(Venta venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "INSERT INTO Venta (Comentarios,IdUsuario)" +
                        "VALUES (@Comentarios,@IdUsuario)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });
                        int rowsAffected = comando.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creando venta: " + ex.Message);
                return false;
            }
        }

        public static bool ModificarVenta(int idVenta, Venta venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Venta SET Comentarios = @Comentarios, IdUsuario = @IdUsuario WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("Comentarios", venta.Comentarios);
                command.Parameters.AddWithValue("IdUsuario", venta.IdUsuario);
                command.Parameters.AddWithValue("Id", idVenta);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static void EliminarVenta(Venta venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "DELETE FROM Venta WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }
    }
}