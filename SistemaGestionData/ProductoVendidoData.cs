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
    public class ProductoVendidoData
    {
        public static ProductoVendido ObtenerProductoVendido(int Id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ProductoVendido WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    int idProducto = Convert.ToInt32(reader["IdProducto"]);
                    int stock = Convert.ToInt32(reader["Stock"]);
                    int idVenta = Convert.ToInt32(reader["IdVenta"]);
                    ProductoVendido productoVendido = new ProductoVendido(id, idProducto, stock, idVenta);
                    return productoVendido;
                }
                throw new Exception("Id no encontrado");
            }
        }

        public static List<ProductoVendido> ListarProductoVendidos()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            List<ProductoVendido> listaProductoVendidos = new List<ProductoVendido>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ProductoVendido";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductoVendido productoVendido = new ProductoVendido();
                            productoVendido.Id = Convert.ToInt32(reader["Id"]);
                            productoVendido.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                            productoVendido.Stock = Convert.ToInt32(reader["Stock"]);
                            productoVendido.IdVenta = Convert.ToInt32(reader["IdVenta"]);
                            listaProductoVendidos.Add(productoVendido);
                        }
                    }
                }
                return listaProductoVendidos;
            }
        }

        public static bool CrearProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "INSERT INTO ProductoVendido (IdProducto,Stock,IdVenta)" +
                        "VALUES (@IdProducto,@Stock,@IdVenta)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productoVendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });
                        int rowsAffected = comando.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creando producto vendido: " + ex.Message);
                return false;
            }
        }

        public static bool ModificarProductoVendido(int idProductoVendido, ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ProductoVendido SET IdProducto = @IdProducto, Stock = @Stock, IdVenta = @IdVenta WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("IdProducto", productoVendido.IdProducto);
                command.Parameters.AddWithValue("Stock", productoVendido.Stock);
                command.Parameters.AddWithValue("IdVenta", productoVendido.IdVenta);
                command.Parameters.AddWithValue("Id", idProductoVendido);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static void EliminarProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "DELETE FROM ProductoVendido WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido.Id });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }
    }
}
