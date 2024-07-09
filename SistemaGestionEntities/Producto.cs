using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Costo { get; set; }
        public int PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
        public Producto() { }

        public Producto(string descripcion, int costo, int precioVenta, int stock, int idUsuario)
        {
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }

        public Producto(int id, string descripcion, int costo, int precioVenta, int stock, int idUsuario)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }
        public override string ToString()
        {
            return $"ID = {this.Id} - Descripcion = {this.Descripcion} - Costo = {this.Costo} - PrecioVenta = {this.PrecioVenta} - Stock = {this.Stock} - IdUsuario = {this.IdUsuario}";
        }
    }
}
