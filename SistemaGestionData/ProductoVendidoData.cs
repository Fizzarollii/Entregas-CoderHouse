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
            public static List<PR.ProductoVendido> ObtenerProductoVendido(int Id)
            {
                List<PR.ProductoVendido> lista = new List<PR.ProductoVendido>();
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
                var query = "SELECT Id,IdProducto,Stock,IdVenta FROM ProductoVendido WHERE Id=@Id";

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
                                    var productoVendido = new PR.ProductoVendido();
                                    productoVendido.Id = Convert.ToInt32(dr["ID"]);
                                    productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productoVendido.Stock = (int)Convert.ToDecimal(dr["Stock"]);
                                    productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                    lista.Add(productoVendido);
                                }
                            }
                        }
                    }
                }
                return lista;
            }

            public static List<PR.ProductoVendido> ListarProductoVendidos()
            {
                List<PR.ProductoVendido> lista = new List<PR.ProductoVendido>();
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
                var query = "SELECT Id,IdProducto,Stock,IdVenta FROM ProductoVendido";


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
                                    var productoVendido = new PR.ProductoVendido();
                                    productoVendido.Id = Convert.ToInt32(dr["ID"]);
                                    productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productoVendido.Stock = (int)Convert.ToDecimal(dr["Stock"]);
                                    productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                    lista.Add(productoVendido);
                                }
                            }
                        }
                    }
                }
                return lista;
            }

            public static void CrearProductoVendido(PR.ProductoVendido productoVendido)
            {
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
                var query = "INSERT INTO ProductoVendido (IdProducto,Stock,IdVenta)" +
                            "VALUES (@IdProducto,@Stock,@IdVenta)";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = productoVendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.VarChar) { Value = productoVendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.VarChar) { Value = productoVendido.IdVenta });
                    }
                    conexion.Close();
                }
            }

            public static void ModificarProductoVendido(PR.ProductoVendido productoVendido)
            {
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
                var query = "UPDATE ProductoVendido" +
                            "SET IdProducto =@IdProducto" +
                            ", Stock = @Stock" +
                            ", IdVenta = @IdVenta" +
                            "WHERE Id = @Id";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido.Id });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = productoVendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productoVendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.VarChar) { Value = productoVendido.IdVenta });
                    }
                    conexion.Close();
                }
            }

            public static void EliminarProductoVendido(PR.ProductoVendido productoVendido)
            {
                string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
                var query = "DELETE FROM ProductoVendido WHERE Id = @Id";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido.Id });
                    }
                    conexion.Close();
                }
            }
        }
    }
