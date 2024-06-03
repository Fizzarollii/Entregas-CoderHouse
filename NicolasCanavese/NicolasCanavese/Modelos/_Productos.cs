using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NicolasCanavese.Modelos
{
    internal class _Productos
    {
        public int id;
        public string? descripciones;
        public double costo;
        public double precioVenta;
        public int stock;
        public int idUsuario;

        public _Productos() { }
        public _Productos(int id, string descripciones, double costo, double precioVenta, int stock, int idUsuario)
        {
            this.id = id;
            this.descripciones = descripciones;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }

        public _Productos(string descripciones, double costo, double precioVenta, int stock, int idUsuario)
        {
            this.descripciones = descripciones;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }

        public int Id { get => id; set => id = value; }
        public string Descripciones { get => descripciones; set => descripciones = value; }
        public double Costo { get => costo; set => costo = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Stock { get => stock; set => stock = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public override string ToString()
        {
            return $"Id = {this.id} - descripciones = {this.descripciones} - costo = {this.costo} - Precio de la venta = {this.precioVenta}  - stock = {this.stock} - id usuario = {this.idUsuario}";
        }
    }
}
