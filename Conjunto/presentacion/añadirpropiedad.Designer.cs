namespace presentacion
{
    partial class añadirpropiedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(añadirpropiedad));
            this.txtestado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbaños = new System.Windows.Forms.TextBox();
            this.txthabitaciones = new System.Windows.Forms.TextBox();
            this.txttamaño = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txttipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtestado
            // 
            this.txtestado.FormattingEnabled = true;
            this.txtestado.Items.AddRange(new object[] {
            "Alquilado",
            "Desocupado",
            "Mantenimiento"});
            this.txtestado.Location = new System.Drawing.Point(464, 188);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(122, 21);
            this.txtestado.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(378, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 38;
            this.button1.Text = "REGISTRAR PROPIEDAD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbaños
            // 
            this.txtbaños.Location = new System.Drawing.Point(464, 308);
            this.txtbaños.Name = "txtbaños";
            this.txtbaños.Size = new System.Drawing.Size(122, 20);
            this.txtbaños.TabIndex = 37;
            this.txtbaños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbaños_KeyPress);
            // 
            // txthabitaciones
            // 
            this.txthabitaciones.Location = new System.Drawing.Point(464, 228);
            this.txthabitaciones.Name = "txthabitaciones";
            this.txthabitaciones.Size = new System.Drawing.Size(122, 20);
            this.txthabitaciones.TabIndex = 36;
            this.txthabitaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthabitaciones_KeyPress);
            // 
            // txttamaño
            // 
            this.txttamaño.Location = new System.Drawing.Point(464, 148);
            this.txttamaño.Name = "txttamaño";
            this.txttamaño.Size = new System.Drawing.Size(122, 20);
            this.txttamaño.TabIndex = 35;
            this.txttamaño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttamaño_KeyPress);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(464, 268);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(122, 20);
            this.txtprecio.TabIndex = 33;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(464, 68);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(122, 20);
            this.txtdireccion.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(343, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(347, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(351, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Baños";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(294, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Habitaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(338, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tamaño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(366, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(324, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(335, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Registro de propiedad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txttipo
            // 
            this.txttipo.FormattingEnabled = true;
            this.txttipo.Items.AddRange(new object[] {
            "Casa",
            "Apartamento"});
            this.txttipo.Location = new System.Drawing.Point(464, 108);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(122, 21);
            this.txttipo.TabIndex = 40;
            // 
            // añadirpropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(708, 468);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbaños);
            this.Controls.Add(this.txthabitaciones);
            this.Controls.Add(this.txttamaño);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "añadirpropiedad";
            this.Text = "añadirpropiedad";
            this.Load += new System.EventHandler(this.añadirpropiedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtestado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbaños;
        private System.Windows.Forms.TextBox txthabitaciones;
        private System.Windows.Forms.TextBox txttamaño;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txttipo;
    }
}