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
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtIdUsuario.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.form1.idUsuario;
            if (idUsuario == 0)
            {
                ProductoData productos = new ProductoData();
                _Productos txtProductos = productos.GetProductById(idUsuario);

                txtDescripcion.Text = txtProductos.Descripciones;
                txtCosto.Text = txtProductos.Costo.ToString();
                txtPrecioVenta.Text = txtProductos.PrecioVenta.ToString();
                txtStock.Text = txtProductos.Stock.ToString();
                txtIdUsuario.Text = txtProductos.IdUsuario.ToString();
            }
            else
            {
                Limpiar();   
            }
        }
    }
}
