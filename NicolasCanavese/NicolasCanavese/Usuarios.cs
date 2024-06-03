﻿using NicolasCanavese.Modelos;
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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombreUsuario.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.form1.idUsuario;
            if (idUsuario > 0)
            {
                UsuarioData usuarios = new UsuarioData();
                _Usuarios txtusuarios = usuarios.GetUserById(idUsuario);

                txtNombre.Text = txtusuarios.Nombre;
                txtApellido.Text = txtusuarios.Apellido;
                txtNombreUsuario.Text = txtusuarios.NombreUsuario;
                txtPassword.Text = txtusuarios.Password;
                txtEmail.Text = txtusuarios.Email;
            }
            else
            {
                Limpiar();
            }
        }
    }
}