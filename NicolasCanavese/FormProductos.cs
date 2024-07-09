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
    public partial class FormProductos : Form
    {
        public void Limpiar()
        {
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtIdUsuario.Text = "";
            txtId.Text = "";
        }
        public FormProductos()
        {
            InitializeComponent();
            Limpiar();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            int costo = int.Parse(txtCosto.Text);
            int precioVenta = int.Parse(txtPrecioVenta.Text);
            int stock = int.Parse(txtStock.Text);
            int idUsuario = int.Parse(txtIdUsuario.Text);

            int idProducto = Program.form1.idProducto;
            Producto productoModificado = new Producto(descripcion, costo, precioVenta, stock, idUsuario);

            if (idProducto > 0)
            {
                ProductoData.ModificarProducto(idProducto, productoModificado);
                MessageBox.Show("Se modifico el producto");
            }
            else
            {
                ProductoData.CrearProducto(productoModificado);
                MessageBox.Show("Se creo un nuevo producto");
            }
            Program.form1.idProducto = 0;
            Limpiar();
            this.Close();
            Program.form1.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.idProducto = 0;
            Limpiar();
            Program.form1.Show();
        }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            int idProducto = Program.form1.idProducto;
            if (idProducto > 0)
            {
                Producto txtData = ProductoData.ObtenerProducto(idProducto);

                txtDescripcion.Text = txtData.Descripcion;
                txtCosto.Text = txtData.Costo.ToString();
                txtPrecioVenta.Text = txtData.PrecioVenta.ToString();
                txtStock.Text = txtData.Stock.ToString();
                txtIdUsuario.Text = txtData.IdUsuario.ToString();
                txtId.Text = idProducto.ToString();
            }
            else
            {
                Limpiar();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
