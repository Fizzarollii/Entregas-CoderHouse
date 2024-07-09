namespace ClassUi
{
    partial class FormUsuarios
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
            label1 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            btnVolver = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(142, 6);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(177, 23);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(142, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(142, 64);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(177, 23);
            txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(142, 93);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(177, 23);
            txtNombreUsuario.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 6;
            label4.Text = "Nombre Usuario";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(142, 122);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 125);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "Contraseña";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(142, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 23);
            txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 154);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 10;
            label6.Text = "Mail";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 191);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(244, 191);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 226);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNombreUsuario;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private Button btnVolver;
        private Button btnGuardar;
    }
}