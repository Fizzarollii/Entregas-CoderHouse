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
            Productos formProductos = new Productos();
            Program.form1.Hide();
            formProductos.Show();

        }

        private void cbCambios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = cbCambios.SelectedItem.ToString();
            if (selectValue == "Clientes")
            {
                UsuarioData usuarios = new UsuarioData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = UsuarioData.ListarUsuarios();
            }
            else if (selectValue == "Productos")
            {
                ProductoData productos = new ProductoData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = ProductoData.ListarProductos();
            }
            else
            {
                UsuarioData usuarios = new UsuarioData();
                dgvPrincipal.AutoGenerateColumns = true;
                dgvPrincipal.DataSource = UsuarioData.ListarUsuarios();
            }
        }

        private void dgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idUsuario = int.Parse(dgvPrincipal[0, filaSeleccionada].Value.ToString());
            }
            Productos productos = new Productos();
            Program.form1.Hide();
            productos.Show();
        }

        private void btModificarProducto_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuarios formUsuarios = new Usuarios();
            Program.form1.Hide();
            formUsuarios.Show();
        }
    }
}
