using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NicolasCanavese.Modelos
{
    internal class Productos
    { 
        public int id { get; set; }
        public string? descripciones { get; set; }
        public int costo { get; set; }
        public int precioVenta { get; set; }
        public int stock { get; set; }
        public int idUsuario { get; set; }
    }
}
