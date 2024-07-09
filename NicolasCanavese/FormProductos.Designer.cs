namespace ClassUi
{
    partial class FormProductos
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
            label1 = new Label();
            txtId = new TextBox();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtCosto = new TextBox();
            label3 = new Label();
            txtPrecioVenta = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            txtIdUsuario = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 195);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnVolver_Click;
            // 
            // button2
            // 
            button2.Location = new Point(177, 195);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(93, 6);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(156, 23);
            txtId.TabIndex = 4;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(93, 35);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(156, 23);
            txtDescripcion.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 38);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Descripcion";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(93, 64);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(156, 23);
            txtCosto.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 67);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Costo";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(93, 93);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(156, 23);
            txtPrecioVenta.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 96);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 9;
            label4.Text = "Precio Venta";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(93, 122);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(156, 23);
            txtStock.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 125);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Stock";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(93, 149);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(156, 23);
            txtIdUsuario.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 152);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 13;
            label6.Text = "Id Usuario";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 230);
            Controls.Add(txtIdUsuario);
            Controls.Add(label6);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(txtPrecioVenta);
            Controls.Add(label4);
            Controls.Add(txtCosto);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox txtId;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtCosto;
        private Label label3;
        private TextBox txtPrecioVenta;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private TextBox txtIdUsuario;
        private Label label6;
    }
}