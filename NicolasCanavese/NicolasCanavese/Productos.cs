using NicolasCanavese.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicolasCanavese
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtIdUsuario.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.idUsuario = 0;
            Program.form1.Show();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.form1.idUsuario;
            if (idUsuario > 0)
            {
                ProductoData productos = new ProductoData();
                _Productos txtProductos = productos.GetProductById(idUsuario);

                txtId.Text = txtProductos.id.ToString();
                txtDescripcion.Text = txtProductos.descripciones;
                txtCosto.Text = txtProductos.costo.ToString();
                txtPrecioVenta.Text = txtProductos.precioVenta.ToString();
                txtStock.Text = txtProductos.stock.ToString();
                txtIdUsuario.Text = txtProductos.idUsuario.ToString();
            }
            else
            {
                Limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idText = txtId.Text;
            if (!string.IsNullOrEmpty(idText) && int.TryParse(idText, out int id))
            {
                _Productos producto = new _Productos { Id = id };
                ProductoData.EliminarProducto(producto);
            }
        }
    }
}

