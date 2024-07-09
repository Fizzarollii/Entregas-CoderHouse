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
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            int idVenta = Program.form1.idVenta;
            if (idVenta > 0)
            {
                Venta txtData = VentaData.ObtenerVenta(idVenta);

                txtId.Text = idVenta.ToString();
                txtComentario.Text = txtData.Comentarios;
                txtIdUsuario.Text = txtData.IdUsuario.ToString();
            }
            else
            {
                Limpiar();
            }
        }
        public void Limpiar()
        {
            txtId.Text = "";
            txtComentario.Text = "";
            txtIdUsuario.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.idVenta = 0;
            Limpiar();
            Program.form1.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string comentario = txtComentario.Text;
            int idUsuario = int.Parse(txtIdUsuario.Text);

            int idVenta = Program.form1.idVenta;

            Venta newUser = new Venta(comentario,idVenta);

            VentaData ventaData = new VentaData();

            if (idVenta > 0)
            {
                VentaData.ModificarVenta(idVenta, newUser);
                MessageBox.Show("se actualizo la venta");
            }
            else
            {
                VentaData.CrearVenta(newUser);
                MessageBox.Show("se creo una nueva venta");
            }

            Limpiar();
            this.Close();
            Program.form1.idVenta = 0;
            Program.form1.Show();
        }
    }
}
