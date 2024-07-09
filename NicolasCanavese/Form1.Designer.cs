namespace NicolasCanavese
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btEliminarProdcuto = new Button();
            btModificarProducto = new Button();
            button3 = new Button();
            button4 = new Button();
            dgvPrincipal = new DataGridView();
            comboBox1 = new ComboBox();
            btCrearProducto = new Button();
            button1 = new Button();
            button2 = new Button();
            btnCrearVenta = new Button();
            btnModificarVenta = new Button();
            btnEliminarVenta = new Button();
            btnCrearProductoV = new Button();
            btnModificarProductoV = new Button();
            btnEliminarProductoV = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            SuspendLayout();
            // 
            // btEliminarProdcuto
            // 
            btEliminarProdcuto.Location = new Point(432, 1);
            btEliminarProdcuto.Name = "btEliminarProdcuto";
            btEliminarProdcuto.Size = new Size(127, 23);
            btEliminarProdcuto.TabIndex = 2;
            btEliminarProdcuto.Text = "Eliminar Producto";
            btEliminarProdcuto.UseVisualStyleBackColor = true;
            btEliminarProdcuto.Click += btEliminarProducto_Click;
            // 
            // btModificarProducto
            // 
            btModificarProducto.Location = new Point(299, 1);
            btModificarProducto.Name = "btModificarProducto";
            btModificarProducto.Size = new Size(127, 23);
            btModificarProducto.TabIndex = 3;
            btModificarProducto.Text = "Modificar Producto";
            btModificarProducto.UseVisualStyleBackColor = true;
            btModificarProducto.Click += btModificarProducto_Click;
            // 
            // button3
            // 
            button3.Location = new Point(432, 1);
            button3.Name = "button3";
            button3.Size = new Size(127, 23);
            button3.TabIndex = 4;
            button3.Text = "Eliminar Usuario";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(166, 1);
            button4.Name = "button4";
            button4.Size = new Size(127, 23);
            button4.TabIndex = 5;
            button4.Text = "Crear Usuario";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Location = new Point(12, 63);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.RowTemplate.Height = 25;
            dgvPrincipal.Size = new Size(776, 375);
            dgvPrincipal.TabIndex = 7;
            dgvPrincipal.CellClick += dgvPrincipal_CellClick;
            dgvPrincipal.CellContentClick += dgvPrincipal_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Productos\t", "Usuarios", "Producto Vendido", "Ventas" });
            comboBox1.Location = new Point(3, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btCrearProducto
            // 
            btCrearProducto.Location = new Point(166, 1);
            btCrearProducto.Name = "btCrearProducto";
            btCrearProducto.Size = new Size(127, 23);
            btCrearProducto.TabIndex = 9;
            btCrearProducto.Text = "Crear Producto";
            btCrearProducto.UseVisualStyleBackColor = true;
            btCrearProducto.Click += btCrearProducto_Click;
            // 
            // button1
            // 
            button1.Location = new Point(299, 1);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 10;
            button1.Text = "Modificar Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(723, 1);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCrearVenta
            // 
            btnCrearVenta.Location = new Point(166, 1);
            btnCrearVenta.Name = "btnCrearVenta";
            btnCrearVenta.Size = new Size(127, 23);
            btnCrearVenta.TabIndex = 12;
            btnCrearVenta.Text = "Crear Venta";
            btnCrearVenta.UseVisualStyleBackColor = true;
            btnCrearVenta.Click += btnCrearVenta_Click;
            // 
            // btnModificarVenta
            // 
            btnModificarVenta.Location = new Point(299, 1);
            btnModificarVenta.Name = "btnModificarVenta";
            btnModificarVenta.Size = new Size(127, 23);
            btnModificarVenta.TabIndex = 13;
            btnModificarVenta.Text = "Modificar Venta";
            btnModificarVenta.UseVisualStyleBackColor = true;
            btnModificarVenta.Click += btnModificarVenta_Click;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(432, 1);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(127, 23);
            btnEliminarVenta.TabIndex = 14;
            btnEliminarVenta.Text = "Eliminar Venta";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // btnCrearProductoV
            // 
            btnCrearProductoV.Location = new Point(138, 1);
            btnCrearProductoV.Name = "btnCrearProductoV";
            btnCrearProductoV.Size = new Size(155, 23);
            btnCrearProductoV.TabIndex = 15;
            btnCrearProductoV.Text = "Crear Producto Vendido";
            btnCrearProductoV.UseVisualStyleBackColor = true;
            btnCrearProductoV.Click += btnCrearProductoV_Click;
            // 
            // btnModificarProductoV
            // 
            btnModificarProductoV.Location = new Point(299, 1);
            btnModificarProductoV.Name = "btnModificarProductoV";
            btnModificarProductoV.Size = new Size(167, 23);
            btnModificarProductoV.TabIndex = 16;
            btnModificarProductoV.Text = "Modificar Producto Vendido";
            btnModificarProductoV.UseVisualStyleBackColor = true;
            btnModificarProductoV.Click += btnModificarProductoV_Click;
            // 
            // btnEliminarProductoV
            // 
            btnEliminarProductoV.Location = new Point(472, 1);
            btnEliminarProductoV.Name = "btnEliminarProductoV";
            btnEliminarProductoV.Size = new Size(167, 23);
            btnEliminarProductoV.TabIndex = 17;
            btnEliminarProductoV.Text = "Eliminar Producto Vendido";
            btnEliminarProductoV.UseVisualStyleBackColor = true;
            btnEliminarProductoV.Click += btnEliminarProductoV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarProductoV);
            Controls.Add(btnModificarProductoV);
            Controls.Add(btnCrearProductoV);
            Controls.Add(btnEliminarVenta);
            Controls.Add(btnModificarVenta);
            Controls.Add(btnCrearVenta);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btCrearProducto);
            Controls.Add(comboBox1);
            Controls.Add(dgvPrincipal);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btModificarProducto);
            Controls.Add(btEliminarProdcuto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btEliminarProdcuto;
        private Button btModificarProducto;
        private Button button3;
        private Button button4;
        private DataGridView dgvPrincipal;
        private ComboBox comboBox1;
        private Button btCrearProducto;
        private Button button1;
        private Button button2;
        private Button btnCrearVenta;
        private Button btnModificarVenta;
        private Button btnEliminarVenta;
        private Button btnCrearProductoV;
        private Button btnModificarProductoV;
        private Button btnEliminarProductoV;
    }
}
