
namespace NicolasCanavese
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNombreUsuario = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 401);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(93, 401);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(174, 401);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 44);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 168);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 226);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 6;
            label4.Text = "Nombre de usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 283);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 7;
            label5.Text = "Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 330);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 8;
            label6.Text = "Mail";
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 44);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(100, 168);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 11;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(129, 223);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 280);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 322);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 14;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 436);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNombreUsuario;
        private TextBox txtPassword;
        private TextBox txtEmail;
    }
}