namespace ClassUi
{
    partial class FormProductoVendido
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
            txtIdProducto = new TextBox();
            label2 = new Label();
            txtStock = new TextBox();
            label3 = new Label();
            txtIdVenta = new TextBox();
            label4 = new Label();
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
            txtId.Location = new Point(87, 6);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(142, 23);
            txtId.TabIndex = 1;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(87, 35);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(142, 23);
            txtIdProducto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Id Producto";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(87, 64);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(142, 23);
            txtStock.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Stock";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(87, 93);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(142, 23);
            txtIdVenta.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Id Venta";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 130);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(154, 130);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 165);
            Controls.Add(btnGuardar);
            Controls.Add(btnVolver);
            Controls.Add(txtIdVenta);
            Controls.Add(label4);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtIdProducto);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormProductoVendido";
            Text = "FormProductoVendido";
            Load += FormProductoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtIdProducto;
        private Label label2;
        private TextBox txtStock;
        private Label label3;
        private TextBox txtIdVenta;
        private Label label4;
        private Button btnVolver;
        private Button btnGuardar;
    }
}