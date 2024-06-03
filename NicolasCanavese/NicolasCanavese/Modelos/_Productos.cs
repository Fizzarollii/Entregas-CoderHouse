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
        public int costo;
        public int precioVenta;
        public int stock;
        public int idUsuario;

        public _Productos() { }
        public _Productos(int id, string descripciones, int costo, int precioVenta, int stock, int idUsuario)
        {
            this.id = id;
            this.descripciones = descripciones;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }

        public _Productos(string descripciones, int costo, int precioVenta, int stock, int idUsuario)
        {
            this.descripciones = descripciones;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }

        public int Id { get => id; set => id = value; }
        public string Descripciones { get => descripciones; set => descripciones = value; }
        public int Costo { get => costo; set => costo = value; }
        public int PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Stock { get => stock; set => stock = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        
    }
}
