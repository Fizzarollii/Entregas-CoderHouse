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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.form1.idUsuario;
            if (idUsuario > 0)
            {
                Usuario txtData = UsuarioData.ObtenerUsuario(idUsuario);

                txtNombre.Text = txtData.Nombre;
                txtApellido.Text = txtData.Apellido;
                txtNombreUsuario.Text = txtData.NombreUsuario;
                txtPassword.Text = txtData.Password;
                txtEmail.Text = txtData.Email;
                txtId.Text = idUsuario.ToString();
            }
            else
            {
                Limpiar();
            }
        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombreUsuario.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtId.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string usuario = txtNombreUsuario.Text;
            string pass = txtPassword.Text;
            string mail = txtEmail.Text;

            int idUsuario = Program.form1.idUsuario;

            Usuario newUser = new Usuario(nombre, apellido, usuario, pass, mail);

            UsuarioData usuarioData = new UsuarioData();

            if (idUsuario > 0)
            {
                UsuarioData.ModificarUsuario(idUsuario, newUser);
                MessageBox.Show("se actualizo el usuario");
            }
            else
            {
                UsuarioData.CrearUsuario(newUser);
                MessageBox.Show("se creo el usuario");
            }

            Limpiar();
            this.Close();
            Program.form1.idUsuario = 0;
            Program.form1.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.idUsuario = 0;
            Limpiar();
            Program.form1.Show();
        }
    }
}
