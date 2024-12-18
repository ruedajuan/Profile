namespace Santa_Ana_Sistema
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.iconButtoncontra = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 337);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(64, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "SISTEMA DE VENTAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(379, 97);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(267, 20);
            this.textUsuario.TabIndex = 3;
            // 
            // textClave
            // 
            this.textClave.Location = new System.Drawing.Point(379, 172);
            this.textClave.Name = "textClave";
            this.textClave.PasswordChar = '*';
            this.textClave.Size = new System.Drawing.Size(267, 20);
            this.textClave.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(379, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(376, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnIngresar.FlatAppearance.BorderSize = 2;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnIngresar.IconColor = System.Drawing.Color.PapayaWhip;
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.IconSize = 35;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIngresar.Location = new System.Drawing.Point(379, 239);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(118, 41);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnSalir.IconColor = System.Drawing.Color.PapayaWhip;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 35;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalir.Location = new System.Drawing.Point(528, 239);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 41);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // iconButtoncontra
            // 
            this.iconButtoncontra.BackColor = System.Drawing.Color.PapayaWhip;
            this.iconButtoncontra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtoncontra.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip;
            this.iconButtoncontra.FlatAppearance.BorderSize = 2;
            this.iconButtoncontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtoncontra.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtoncontra.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.iconButtoncontra.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButtoncontra.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconButtoncontra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtoncontra.IconSize = 30;
            this.iconButtoncontra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButtoncontra.Location = new System.Drawing.Point(379, 195);
            this.iconButtoncontra.Name = "iconButtoncontra";
            this.iconButtoncontra.Size = new System.Drawing.Size(157, 39);
            this.iconButtoncontra.TabIndex = 9;
            this.iconButtoncontra.Text = "Mostrar contraseña";
            this.iconButtoncontra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtoncontra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtoncontra.UseVisualStyleBackColor = false;
            this.iconButtoncontra.Click += new System.EventHandler(this.iconButtoncontra_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(717, 337);
            this.Controls.Add(this.iconButtoncontra);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton iconButtoncontra;
    }
}