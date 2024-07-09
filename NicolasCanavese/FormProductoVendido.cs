using NicolasCanavese;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassUi
{
    public partial class FormProductoVendido : Form
    {
        public FormProductoVendido()
        {
            InitializeComponent();
        }

        private void FormProductoVendido_Load(object sender, EventArgs e)
        {
            int idProductoVendido = Program.form1.idProductoVendido;
            if (idProductoVendido > 0)
            {
                ProductoVendido txtData = ProductoVendidoData.ObtenerProductoVendido(idProductoVendido);

                txtId.Text = idProductoVendido.ToString();
                txtIdProducto.Text = txtData.IdProducto.ToString();
                txtStock.Text = txtData.Stock.ToString();
                txtIdVenta.Text = txtData.IdVenta.ToString();
            }
            else
            {
                Limpiar();
            }
        }
        public void Limpiar()
        {
            txtIdProducto.Text = "";
            txtStock.Text = "";
            txtIdVenta.Text = "";
            txtId.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.idProductoVendido = 0;
            Limpiar();
            Program.form1.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idProducto = int.Parse(txtIdProducto.Text);
            int stock = int.Parse(txtStock.Text);
            int idVenta = int.Parse(txtIdVenta.Text);

            int idProductoVendido = Program.form1.idProductoVendido;

            ProductoVendido newUser = new ProductoVendido(idProducto,stock,idVenta);

            ProductoVendidoData productoVendidoData = new ProductoVendidoData();

            if (idProductoVendido > 0)
            {
                ProductoVendidoData.ModificarProductoVendido(idProductoVendido, newUser);
                MessageBox.Show("se actualizo el producto vendido");
            }
            else
            {
                ProductoVendidoData.CrearProductoVendido(newUser);
                MessageBox.Show("se creo el producto vendido");
            }

            Limpiar();
            this.Close();
            Program.form1.idProductoVendido = 0;
            Program.form1.Show();
        }
    }
}
