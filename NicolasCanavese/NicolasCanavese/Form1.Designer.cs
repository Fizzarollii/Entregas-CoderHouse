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
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btEliminarProdcuto
            // 
            btEliminarProdcuto.Location = new Point(661, 12);
            btEliminarProdcuto.Name = "btEliminarProdcuto";
            btEliminarProdcuto.Size = new Size(127, 23);
            btEliminarProdcuto.TabIndex = 2;
            btEliminarProdcuto.Text = "Eliminar Producto";
            btEliminarProdcuto.UseVisualStyleBackColor = true;
            btEliminarProdcuto.Click += btEliminarProdcuto_Click;
            // 
            // btModificarProducto
            // 
            btModificarProducto.Location = new Point(661, 41);
            btModificarProducto.Name = "btModificarProducto";
            btModificarProducto.Size = new Size(127, 23);
            btModificarProducto.TabIndex = 3;
            btModificarProducto.Text = "Modificar Producto";
            btModificarProducto.UseVisualStyleBackColor = true;
            btModificarProducto.Click += btModificarProducto_Click;
            // 
            // button3
            // 
            button3.Location = new Point(661, 277);
            button3.Name = "button3";
            button3.Size = new Size(127, 23);
            button3.TabIndex = 4;
            button3.Text = "Eliminar Usuario";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(661, 306);
            button4.Name = "button4";
            button4.Size = new Size(127, 23);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Location = new Point(12, 12);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.RowTemplate.Height = 25;
            dgvPrincipal.Size = new Size(643, 237);
            dgvPrincipal.TabIndex = 7;
            dgvPrincipal.CellClick += dgvPrincipal_CellClick;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 277);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(643, 150);
            dgvUsuarios.TabIndex = 8;
            dgvUsuarios.CellClick += DgvUsuarios_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUsuarios);
            Controls.Add(dgvPrincipal);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btModificarProducto);
            Controls.Add(btEliminarProdcuto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btEliminarProdcuto;
        private Button btModificarProducto;
        private Button button3;
        private Button button4;
        private DataGridView dgvPrincipal;
        private DataGridView dgvUsuarios;
    }
}
