namespace Santa_Ana_Sistema
{
    partial class FormReportes
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
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonBuscar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nroVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            this.iconMenuItem1.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(363, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.iconButtonBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 100);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButtonBuscar
            // 
            this.iconButtonBuscar.BackColor = System.Drawing.Color.PapayaWhip;
            this.iconButtonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.iconButtonBuscar.FlatAppearance.BorderSize = 2;
            this.iconButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBuscar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.iconButtonBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconButtonBuscar.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconButtonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBuscar.IconSize = 20;
            this.iconButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBuscar.Location = new System.Drawing.Point(497, 50);
            this.iconButtonBuscar.Name = "iconButtonBuscar";
            this.iconButtonBuscar.Size = new System.Drawing.Size(111, 25);
            this.iconButtonBuscar.TabIndex = 6;
            this.iconButtonBuscar.Text = "Buscar";
            this.iconButtonBuscar.UseVisualStyleBackColor = false;
            this.iconButtonBuscar.Click += new System.EventHandler(this.iconButtonBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(272, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha fin:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label4.Location = new System.Drawing.Point(16, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha inicio:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label10.Location = new System.Drawing.Point(15, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Registro de Ventas";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroVentaDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.modalidadPagoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.montoTotalDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ventaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1047, 286);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nroVentaDataGridViewTextBoxColumn
            // 
            this.nroVentaDataGridViewTextBoxColumn.DataPropertyName = "NroVenta";
            this.nroVentaDataGridViewTextBoxColumn.HeaderText = "NroVenta";
            this.nroVentaDataGridViewTextBoxColumn.Name = "nroVentaDataGridViewTextBoxColumn";
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // modalidadPagoDataGridViewTextBoxColumn
            // 
            this.modalidadPagoDataGridViewTextBoxColumn.DataPropertyName = "ModalidadPago";
            this.modalidadPagoDataGridViewTextBoxColumn.HeaderText = "ModalidadPago";
            this.modalidadPagoDataGridViewTextBoxColumn.Name = "modalidadPagoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // montoTotalDataGridViewTextBoxColumn
            // 
            this.montoTotalDataGridViewTextBoxColumn.DataPropertyName = "MontoTotal";
            this.montoTotalDataGridViewTextBoxColumn.HeaderText = "MontoTotal";
            this.montoTotalDataGridViewTextBoxColumn.Name = "montoTotalDataGridViewTextBoxColumn";
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(CapaEntidad.Venta);
            this.ventaBindingSource.CurrentChanged += new System.EventHandler(this.ventaBindingSource_CurrentChanged);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1047, 559);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconButtonBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidadPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ventaBindingSource;
    }
}