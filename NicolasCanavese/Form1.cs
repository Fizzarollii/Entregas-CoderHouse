using ClassUi;
using SistemaGestionEntities;
using System.Data.SqlClient;
using System.Windows.Forms;
using static SistemaGestionEntities.Usuario;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace NicolasCanavese
{
    public partial class Form1 : Form
    {
        public int idProducto;
        public int idProductoVendido;
        public int idUsuario;
        public int idVenta;
        public string datosCargados;
        private void HideAll()
        {
            btEliminarProdcuto.Hide();
            btModificarProducto.Hide();
            btCrearProducto.Hide();
            button3.Hide();
            button4.Hide();
            button1.Hide();
            btnCrearVenta.Hide();
            btnEliminarVenta.Hide();
            btnModificarVenta.Hide();
            btnCrearProductoV.Hide();
            btnModificarProductoV.Hide();
            btnEliminarProductoV.Hide();
        }
        private void BotonesProducto()
        {
            btEliminarProdcuto.Show();
            btModificarProducto.Show();
            btCrearProducto.Show();
            button3.Hide();
            button4.Hide();
            button1.Hide();
            btnCrearVenta.Hide();
            btnEliminarVenta.Hide();
            btnModificarVenta.Hide();
            btnCrearProductoV.Hide();
            btnModificarProductoV.Hide();
            btnEliminarProductoV.Hide();
        }
        private void BotonesVentas()
        {
            btEliminarProdcuto.Hide();
            btModificarProducto.Hide();
            btCrearProducto.Hide();
            button3.Hide();
            button4.Hide();
            button1.Hide();
            btnCrearVenta.Show();
            btnEliminarVenta.Show();
            btnModificarVenta.Show();
            btnCrearProductoV.Hide();
            btnModificarProductoV.Hide();
            btnEliminarProductoV.Hide();
        }
        private void BotonesUsuarios()
        {
            btEliminarProdcuto.Hide();
            btModificarProducto.Hide();
            btCrearProducto.Hide();
            button3.Show();
            button4.Show();
            button1.Show();
            btnCrearVenta.Hide();
            btnEliminarVenta.Hide();
            btnModificarVenta.Hide();
            btnCrearProductoV.Hide();
            btnModificarProductoV.Hide();
            btnEliminarProductoV.Hide();
        }
        private void BotonesProductoVendido()
        {
            btEliminarProdcuto.Hide();
            btModificarProducto.Hide();
            btCrearProducto.Hide();
            button3.Hide();
            button4.Hide();
            button1.Hide();
            btnCrearVenta.Hide();
            btnEliminarVenta.Hide();
            btnModificarVenta.Hide();
            btnCrearProductoV.Show();
            btnModificarProductoV.Show();
            btnEliminarProductoV.Show();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            idUsuario = 0;
            idVenta = 0;
            idProducto = 0;
            idProductoVendido = 0;
            HideAll();
        }
        private void btEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPrincipal.SelectedRows)
                {
                    Producto producto = row.DataBoundItem as Producto;
                    ProductoData.EliminarProducto(producto);
                    MessageBox.Show("Se elimino el producto");
                }
                dgvPrincipal.DataSource = null;
                dgvPrincipal.DataSource = ProductoData.ListarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvPrincipal.SelectedRows[0].Index;
                idProducto = int.Parse(dgvPrincipal[0, filaSeleccionada].Value.ToString());

                FormProductos formProductos = new FormProductos();
                Program.form1.Hide();
                formProductos.Show();
            }
            else
            {
                MessageBox.Show("No hay fila seleccionada");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPrincipal.SelectedRows)
                {
                    Usuario usuario = row.DataBoundItem as Usuario;
                    UsuarioData.EliminarUsuario(usuario);
                    MessageBox.Show("Se elimino el usuario");
                }
                dgvPrincipal.DataSource = null;
                dgvPrincipal.DataSource = UsuarioData.ListarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();
            if (selectValue == "Productos")
            {
                ProductoData productos = new ProductoData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = ProductoData.ListarProductos();
                BotonesProducto();

            }
            else if (selectValue == "Usuarios")
            {
                UsuarioData usuarios = new UsuarioData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = UsuarioData.ListarUsuarios();
                BotonesUsuarios();
            }
            else if (selectValue == "Ventas")
            {
                VentaData venta = new VentaData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = VentaData.ListarVentas();
                BotonesVentas();
            }
            else if (selectValue == "Producto Vendido")
            {
                ProductoVendidoData productoVendido = new ProductoVendidoData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = ProductoVendidoData.ListarProductoVendidos();
                BotonesProductoVendido();
            }
            else
            {
                ProductoData productos = new ProductoData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = ProductoData.ListarProductos();
                BotonesProducto();
            }
        }

        private void btCrearProducto_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            Program.form1.Hide();
            formProductos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            Program.form1.Hide();
            formUsuarios.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvPrincipal.SelectedRows[0].Index;
                idUsuario = int.Parse(dgvPrincipal[0, filaSeleccionada].Value.ToString());

                FormUsuarios formUsuarios = new FormUsuarios();
                Program.form1.Hide();
                formUsuarios.Show();
            }
            else
            {
                MessageBox.Show("No hay fila seleccionada");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvPrincipal.DataSource = null;
            dgvPrincipal.Refresh();
            string selectValue = comboBox1.SelectedItem.ToString();
            if (selectValue == "Productos")
            {
                ProductoData productos = new ProductoData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = ProductoData.ListarProductos();
                BotonesProducto();

            }
            else if (selectValue == "Usuarios")
            {
                UsuarioData usuarios = new UsuarioData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = UsuarioData.ListarUsuarios();
                BotonesUsuarios();
            }
            else if (selectValue == "Ventas")
            {
                VentaData venta = new VentaData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = VentaData.ListarVentas();
                BotonesVentas();
            }
            else if (selectValue == "Producto Vendido")
            {
                ProductoVendidoData productoVendido = new ProductoVendidoData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = ProductoVendidoData.ListarProductoVendidos();
                BotonesProductoVendido();
            }
            else
            {
                ProductoData productos = new ProductoData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = ProductoData.ListarProductos();
                BotonesProducto();
            }
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            Program.form1.Hide();
            formVentas.Show();
        }

        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvPrincipal.SelectedRows[0].Index;
                idVenta = int.Parse(dgvPrincipal[0, filaSeleccionada].Value.ToString());

                FormVentas formVentas = new FormVentas();
                Program.form1.Hide();
                formVentas.Show();
            }
            else
            {
                MessageBox.Show("No hay fila seleccionada");
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPrincipal.SelectedRows)
                {
                    Venta venta = row.DataBoundItem as Venta;
                    VentaData.EliminarVenta(venta);
                    MessageBox.Show("Se elimino la venta");
                }
                dgvPrincipal.DataSource = null;
                dgvPrincipal.DataSource = VentaData.ListarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearProductoV_Click(object sender, EventArgs e)
        {
            FormProductoVendido formProductoVendido = new FormProductoVendido();
            Program.form1.Hide();
            formProductoVendido.Show();
        }

        private void btnModificarProductoV_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dgvPrincipal.SelectedRows[0].Index;
                idProductoVendido = int.Parse(dgvPrincipal[0, filaSeleccionada].Value.ToString());

                FormProductoVendido formProductoVendido = new FormProductoVendido();
                Program.form1.Hide();
                formProductoVendido.Show();
            }
            else
            {
                MessageBox.Show("No hay fila seleccionada");
            }
        }

        private void btnEliminarProductoV_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPrincipal.SelectedRows)
                {
                    ProductoVendido productoVendido = row.DataBoundItem as ProductoVendido;
                    ProductoVendidoData.EliminarProductoVendido(productoVendido);
                    MessageBox.Show("Se elimino el producto vendido");
                }
                dgvPrincipal.DataSource = null;
                dgvPrincipal.DataSource = ProductoVendidoData.ListarProductoVendidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
