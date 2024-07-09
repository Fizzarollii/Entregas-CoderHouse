namespace ClassUi
{
    partial class FormVentas
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
            txtComentario = new TextBox();
            label2 = new Label();
            txtIdUsuario = new TextBox();
            label3 = new Label();
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
            txtId.Location = new Point(85, 1);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(158, 23);
            txtId.TabIndex = 1;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(85, 30);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(158, 23);
            txtComentario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Comentario";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(85, 59);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(158, 23);
            txtIdUsuario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Id Usuario";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(7, 95);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(168, 95);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 130);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(txtIdUsuario);
            Controls.Add(label3);
            Controls.Add(txtComentario);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormVentas";
            Text = "FormVentas";
            Load += FormVentas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtComentario;
        private Label label2;
        private TextBox txtIdUsuario;
        private Label label3;
        private Button btnVolver;
        private Button btnGuardar;
    }
}