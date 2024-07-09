using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace NicolasCanavese
{       
    public class ProductoData
    {
        public static Producto ObtenerProducto(int Id)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Descripciones, Costo, Stock, PrecioVenta, IdUsuario FROM Producto WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Producto(
                        Convert.ToInt32(reader["Id"]),
                        reader["Descripciones"].ToString(),
                        Convert.ToInt32(reader["Costo"]),
                        Convert.ToInt32(reader["Stock"]),
                        Convert.ToInt32(reader["PrecioVenta"]),
                        Convert.ToInt32(reader["IdUsuario"])
                    );
                }
                throw new Exception("Producto no encontrado");
            }
        }
        public static List<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto";


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
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dr["Id"]);
                                producto.Descripcion = dr["Descripciones"].ToString();
                                producto.Costo = Convert.ToInt32(dr["Costo"]);
                                producto.PrecioVenta = Convert.ToInt32(dr["PrecioVenta"]);
                                producto.Stock = (int)Convert.ToDecimal(dr["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                lista.Add(producto);
                            }
                        }
                    }
                }
            }
            return lista;
        }
        public static bool CrearProducto(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "INSERT INTO Producto (Descripciones,Costo,PrecioVenta,Stock,IdUsuario)" +
                        "VALUES (@Descripciones,@Costo,@PrecioVenta,@Stock,@IdUsuario)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripcion });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Int) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Int) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario });
                        int rowsAffected = comando.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creando producto: " + ex.Message);
                return false;
            }
        }
        public static bool ModificarProducto(int idProducto, Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Producto SET Descripciones = @Descripciones, Costo = @Costo, PrecioVenta = @PrecioVenta, Stock = @Stock, IdUsuario = @IdUsuario WHERE Id = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id", idProducto);
                command.Parameters.AddWithValue("@Descripciones", producto.Descripcion);
                command.Parameters.AddWithValue("@Costo", producto.Costo);
                command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@Stock", producto.Stock);
                command.Parameters.AddWithValue("@IdUsuario", producto.IdUsuario);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        public static void EliminarProducto(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "DELETE FROM Producto WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}

