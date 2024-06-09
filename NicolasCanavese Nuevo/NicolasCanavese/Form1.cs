using System.Data.SqlClient;
using System.Windows.Forms;
using static NicolasCanavese.ProductoData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NicolasCanavese
{
    public partial class Form1 : Form
    {
        public int idUsuario;
        private void HideAll()
        {
            btEliminarProdcuto.Hide();
            btModificarProducto.Hide();
            btCrearProducto.Hide();
            button3.Hide();
            button4.Hide();
            button1.Hide();
        }
        private void BotonesProducto()
        {
            btEliminarProdcuto.Show();
            btModificarProducto.Show();
            btCrearProducto.Show();
            button3.Hide();
            button4.Hide();
            button1.Hide();
        }

        private void BotonesUsuarios()
        {
            btEliminarProdcuto.Hide();
            btModificarProducto.Hide();
            btCrearProducto.Hide();
            button3.Show();
            button4.Show();
            button1.Show();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            idUsuario = 0;
            HideAll();
        }
        private void btEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPrincipal.SelectedRows)
                {
                    Productos producto = row.DataBoundItem as Productos;
                    EliminarProducto(producto);
                }
                dgvPrincipal.DataSource = null;
                dgvPrincipal.DataSource = ListarProductos();
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
            Productos producto = new Productos
            {
                Id = 1,
                Descripcion = "remera premium",
                Costo = 5500,
                PrecioVenta = 32000,
                Stock = 2,
                IdUsuario = 1,
            };
            try
            {
                ModificarProducto(producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modificando el producto: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvPrincipal.SelectedRows)
                {
                    Usuarios usuario = row.DataBoundItem as Usuarios;
                    UsuarioData.EliminarUsuario(usuario);
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
                dgvPrincipal.DataSource = ListarProductos();
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
                HideAll();
            }
            else if (selectValue == "Producto Vendido")
            {
                ProductoVendidoData productoVendido = new ProductoVendidoData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = ProductoVendidoData.ListarProductoVendidos();
                HideAll();
            }
            else
            {
                ProductoData productos = new ProductoData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = ListarProductos();
                BotonesProducto();
            }
        }

        private void btCrearProducto_Click(object sender, EventArgs e)
        { 
            Productos producto = new Productos
            {
                Id = 1,
                Descripcion = "remera",
                Costo = 2500,
                PrecioVenta = 3000,
                Stock = 5,
                IdUsuario = 1,
            };
            CrearProducto(producto);
            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = ListarProductos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios
            {
                Id = 1,
                Nombre = "remera",
                Apellido = "manga larga",
                NombreUsuario = "majisuzz",
                Password = "123321aa",
                Email = "juancito12@gmail.com",
            };
            UsuarioData.CrearUsuario(usuario);
            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = UsuarioData.ListarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrincipal.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvPrincipal.SelectedRows[0];
                    Usuarios usuario = new Usuarios
                    {
                        Id = 1,
                        Nombre = "remera premium",
                        Apellido = "5500",
                        NombreUsuario = "32000",
                        Password = "22",
                        Email = "2322",
                    };
                    UsuarioData.ModificarUsuario(usuario);
                }
                else
                {
                    MessageBox.Show("No hay fila seleccionada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error modificando el usuario: " + ex.Message);
            }
        }
    }
}
