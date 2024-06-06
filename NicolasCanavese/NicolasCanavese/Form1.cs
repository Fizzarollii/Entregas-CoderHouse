using System.Data.SqlClient;
using System.Windows.Forms;
using static NicolasCanavese.ProductoData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NicolasCanavese
{
    public partial class Form1 : Form
    {
        public int idUsuario;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            idUsuario = 0;
            ProductoData productos = new ProductoData();
            dgvPrincipal.AutoGenerateColumns = true;
            dgvPrincipal.DataSource = ProductoData.ListarProductos();
        }
        private void btEliminarProdcuto_Click(object sender, EventArgs e)
        {
        }

        private void dgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btModificarProducto_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();
            if (selectValue == "Productos")
            {
                ProductoData productos = new ProductoData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = ProductoData.ListarProductos();
            }
            else if (selectValue == "Usuarios")
            {
                UsuarioData usuarios = new UsuarioData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = UsuarioData.ListarUsuarios();
            }
            else
            {
                ProductoData productos = new ProductoData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = ProductoData.ListarProductos();
            }
        }
    }
}
