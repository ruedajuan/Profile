namespace Santa_Ana_Sistema
{
    partial class VentanaProductos
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
            this.components = new System.ComponentModel.Container();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel23 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNombreBuscador = new System.Windows.Forms.TextBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel13.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.panel24.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(319, 29);
            this.panel11.TabIndex = 9;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label9);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 29);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(319, 35);
            this.panel13.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label9.Location = new System.Drawing.Point(35, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Buscar producto";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.iconButtonBuscar);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(0, 163);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(319, 40);
            this.panel22.TabIndex = 20;
            // 
            // iconButtonBuscar
            // 
            this.iconButtonBuscar.BackColor = System.Drawing.Color.PapayaWhip;
            this.iconButtonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.iconButtonBuscar.FlatAppearance.BorderSize = 2;
            this.iconButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBuscar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.iconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.iconButtonBuscar.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBuscar.IconSize = 20;
            this.iconButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBuscar.Location = new System.Drawing.Point(40, 2);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Size = new System.Drawing.Size(175, 35);
            this.iconButtonBuscar.TabIndex = 5;
            this.iconButtonBuscar.Text = "Buscar";
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "PrecioVenta";
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.DataPropertyName = "PrecioCompra";
            this.PrecioCompra.HeaderText = "PrecioCompra";
            this.PrecioCompra.Name = "PrecioCompra";
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // IdCategoria
            // 
            this.IdCategoria.DataPropertyName = "IdCategoria";
            this.IdCategoria.FillWeight = 80F;
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA DE PRODUCTOS";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.FillWeight = 200F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 200;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.GhostWhite;
            this.panel23.Controls.Add(this.dataGridView1);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(319, 67);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(686, 548);
            this.panel23.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Nombre,
            this.Presentacion,
            this.Descripcion,
            this.IdCategoria,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta,
            this.fechaRegistroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 548);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.FillWeight = 80F;
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Presentacion
            // 
            this.Presentacion.DataPropertyName = "Presentacion";
            this.Presentacion.HeaderText = "Presentacion";
            this.Presentacion.Name = "Presentacion";
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            this.fechaRegistroDataGridViewTextBoxColumn.Width = 200;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CapaEntidad.Producto);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label11.Location = new System.Drawing.Point(36, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nombre del producto:";
            // 
            // textBoxNombreBuscador
            // 
            this.textBoxNombreBuscador.Location = new System.Drawing.Point(40, 6);
            this.textBoxNombreBuscador.Name = "textBoxNombreBuscador";
            this.textBoxNombreBuscador.Size = new System.Drawing.Size(171, 20);
            this.textBoxNombreBuscador.TabIndex = 1;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel24.Controls.Add(this.label1);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(319, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(686, 67);
            this.panel24.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel22);
            this.panel1.Controls.Add(this.panel21);
            this.panel1.Controls.Add(this.panel20);
            this.panel1.Controls.Add(this.panel19);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 615);
            this.panel1.TabIndex = 7;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.textBoxNombreBuscador);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 126);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(319, 37);
            this.panel21.TabIndex = 19;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label11);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 91);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(319, 35);
            this.panel20.TabIndex = 18;
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 64);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(319, 27);
            this.panel19.TabIndex = 17;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(CapaEntidad.Usuario);
            // 
            // VentanaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1005, 615);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.panel24);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaProductos";
            this.Text = "VentanaProductos";
            this.Load += new System.EventHandler(this.VentanaProductos_Load);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Panel panel23;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNombreBuscador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
    }
}