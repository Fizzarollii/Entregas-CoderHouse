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
        public static List<Sell.Venta> ObtenerVenta(int Id)
        {
            List<Sell.Venta> lista = new List<Sell.Venta>();
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "SELECT Id,Comentarios,IdUsuario FROM Venta WHERE Id=@Id";

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
                                var venta = new Sell.Venta();
                                venta.Id = Convert.ToInt32(dr["ID"]);
                                venta.Comentarios = dr["Comentarios"].ToString();
                                venta.IdUsuario = (int)Convert.ToDecimal(dr["IdUsuario"]);
                                lista.Add(venta);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static List<Sell.Venta> ListarVentas()
        {
            List<Sell.Venta> lista = new List<Sell.Venta>();
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "SELECT Id,Comentarios,IdUsuario FROM Venta";


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
                                var venta = new Sell.Venta();
                                venta.Id = Convert.ToInt32(dr["ID"]);
                                venta.Comentarios = dr["Comentarios"].ToString();
                                venta.IdUsuario = (int)Convert.ToDecimal(dr["IdUsuario"]);
                                lista.Add(venta);
                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static void CrearVenta(Sell.Venta venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "INSERT INTO Venta (Comentarios,IdUsuario)" +
                        "VALUES (@Comentarios,@IdUsuario)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = venta.IdUsuario });
                }
                conexion.Close();
            }
        }

        public static void ModificarVenta(Sell.Venta venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "UPDATE Venta" +
                        "SET Comentario =@Comentario" +
                        ", IdUsuario = @IdUsuario" +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                    comando.Parameters.Add(new SqlParameter("Comentario", SqlDbType.VarChar) { Value = venta.Comentarios });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = venta.IdUsuario });
                }
                conexion.Close();
            }
        }

        public static void EliminarVenta(Sell.Venta venta)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion2;Trusted_Connection=True;";
            var query = "DELETE FROM Venta WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                }
                conexion.Close();
            }
        }
    }
}