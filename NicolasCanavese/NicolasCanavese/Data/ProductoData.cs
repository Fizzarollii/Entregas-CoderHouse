using NicolasCanavese.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static NicolasCanavese.UsuarioData;

namespace NicolasCanavese
{
    internal class ProductoData
    {
        private string connectionString;

        public static List<Modelos.Productos> ObtenerProducto(int IdProducto)
        {
            List<Modelos.Productos> lista = new List<Modelos.Productos>();
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
                                var producto = new Modelos.Productos();
                                producto.id = Convert.ToInt32(dr["Id"]);
                                producto.descripciones = dr["Descripciones"].ToString();
                                producto.costo = Convert.ToInt32(dr["Costo"]);
                                producto.precioVenta = Convert.ToInt32(dr["PrecioVenta"]);
                                producto.stock = (int)Convert.ToDecimal(dr["Stock"]);
                                producto.idUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                lista.Add(producto);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static List<Modelos.Productos> ListarProductos()
        {
            List<Modelos.Productos> lista = new List<Productos>();
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
                                var producto = new Modelos.Productos();
                                producto.id = Convert.ToInt32(dr["Id"]);
                                producto.descripciones = dr["Descripciones"].ToString();
                                producto.costo = Convert.ToInt32(dr["Costo"]);
                                producto.precioVenta = Convert.ToInt32(dr["PrecioVenta"]);
                                producto.stock = (int)Convert.ToDecimal(dr["Stock"]);
                                producto.idUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                lista.Add(producto);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static void CrearProducto(Productos producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "INSERT INTO Producto (Descripciones,Costo,PrecioVenta,Stock,IdUsuario)" +
                        "VALUES (@Descripciones,@Costo,@PrecioVenta,@Stock,@IdUsuario)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.descripciones });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.VarChar) { Value = producto.costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.VarChar) { Value = producto.precioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.VarChar) { Value = producto.stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.idUsuario });
                }
                conexion.Close();
            }
        }

        public static void ModificarProducto(Modelos.Productos producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "UPDATE Producto" +
                        "SET Descripciones =@Descripciones" +
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
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.id });
                    comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.descripciones });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.precioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.idUsuario });
                }
                conexion.Close();
            }
        }

        public static void EliminarProducto(Productos producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "DELETE FROM Producto WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.id });
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}

