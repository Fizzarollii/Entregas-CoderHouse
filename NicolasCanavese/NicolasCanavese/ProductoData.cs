using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NicolasCanavese
{
    public static class ProductoData
    {
        public class Producto
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public double Costo { get; set; }
            public double PrecioVenta { get; set; }
            public int Stock { get; set; }
            public int IdUsuario { get; set; }
        }

        public static List<Producto> ObtenerProducto(int IdProducto)
        {
            List<Producto> lista = new List<Producto>();
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "SELECT Id,Descripcion,Costo,PrecioVenta,Stock,IdUsuario FROM Producto WHERE Id=@IdProducto";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdProducto";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdProducto;

                    comando.Parameters.Add(parametro);
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dr["ID"]);
                                producto.Descripcion = dr["Descripciones"].ToString();
                                producto.Costo = (double)Convert.ToDecimal(dr["Costo"]);
                                producto.PrecioVenta = (double)Convert.ToDecimal(dr["PrecioVenta"]);
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

        public static List<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "SELECT Id,Descripcion,Costo,PrecioVenta,Stock,IdUsuario FROM Producto";


            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            if (dr.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dr["ID"]);
                                producto.Descripcion = dr["Descripciones"].ToString();
                                producto.Costo = (double)Convert.ToDecimal(dr["Costo"]);
                                producto.PrecioVenta = (double)Convert.ToDecimal(dr["PrecioVenta"]);
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

        public static void CrearProducto(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "INSERT INTO Producto (Descripcion,Costo,PrecioVenta,Stock,IdUsuario)" +
                        "VALUES (@Descripcion,@Costo,@PrecioVenta,@Stock,@IdUsuario)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.VarChar) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.VarChar) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.VarChar) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.IdUsuario });
                }
                conexion.Close();
            }
        }

        public static void ModificarProducto(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "UPDATE Producto" +
                        "SET Descripcion =@Descripcion" +
                        ", Costo = @Costo" +
                        ", PrecioVenta = @PrecioVenta" +
                        ", Stock = @Stock" +
                        ", IdUsuario = @IdUsuario" +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                    comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.IdUsuario });
                }
                conexion.Close();
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
                }
                conexion.Close();
            }
        }
    }
}
