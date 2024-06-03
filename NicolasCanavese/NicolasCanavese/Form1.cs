using System.Data.SqlClient;
using System.Windows.Forms;
using static NicolasCanavese.ProductoData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NicolasCanavese
{
    public partial class Form1 : Form
    {
        public int idUsuario;
        public int idUsuario2;
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

        private void dgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoData productos = new ProductoData();
            dgvPrincipal.AutoGenerateColumns = true;
            dgvPrincipal.DataSource = ProductoData.ListarProductos();

            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idUsuario = int.Parse(dgvPrincipal[0, filaSeleccionada].Value.ToString());
            }
            Productos productos2 = new Productos();
            Program.form1.Hide();
            productos2.Show();
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
        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UsuarioData usuarios = new UsuarioData();
            dgvUsuarios.AutoGenerateColumns = true;
            dgvUsuarios.DataSource = UsuarioData.ListarUsuarios();
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idUsuario2 = int.Parse(dgvPrincipal[0, filaSeleccionada].Value.ToString());
            }
            Usuarios usuarios2 = new Usuarios();
            Program.form1.Hide();
            usuarios2.Show();
        }
    }
}
