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
        

        public static List<Producto.Productos> ObtenerProducto(int IdProducto)
        {
            List<Producto.Productos> lista = new List<Producto.Productos>();
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto WHERE Id=@IdProducto";

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
                            while (dr.Read())
                            {
                                var producto = new Producto.Productos();
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

        public static List<Producto.Productos> ListarProductos()
        {
            List<Producto.Productos> lista = new List<Producto.Productos>();
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
                                var producto = new Producto.Productos();
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
            
        public static void CrearProducto(Producto.Productos producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "INSERT INTO Producto (Descripciones,Costo,PrecioVenta,Stock,IdUsuario)" +
                        "VALUES (@Descripciones,@Costo,@PrecioVenta,@Stock,@IdUsuario)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripcion });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });
                    comando.ExecuteNonQuery();
                }
            }
        }

       

        public static void ModificarProducto(Producto.Productos producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            string query = "UPDATE Producto SET Descripciones = @Descripciones, Costo = @Costo, PrecioVenta = @PrecioVenta, Stock = @Stock, IdUsuario = @IdUsuario WHERE Id = @id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = producto.Id });
                    comando.Parameters.Add(new SqlParameter("@Descripciones", SqlDbType.VarChar) { Value = producto.Descripcion });
                    comando.Parameters.Add(new SqlParameter("@Costo", SqlDbType.Decimal) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("@PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });
                    comando.ExecuteNonQuery();
                }
            }
        }
        public static void EliminarProducto(Producto.Productos producto)
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

