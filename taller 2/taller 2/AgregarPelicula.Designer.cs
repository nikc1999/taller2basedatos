
namespace taller_2
{
    partial class AgregarPelicula
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxDuracion = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxIdioma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSinopsis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAnio = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxDirector = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Agregar Nueva Pelicula";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Duracion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Idioma";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(396, 498);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 13;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxDuracion
            // 
            this.textBoxDuracion.Location = new System.Drawing.Point(316, 262);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.Size = new System.Drawing.Size(254, 20);
            this.textBoxDuracion.TabIndex = 12;
            this.textBoxDuracion.TextChanged += new System.EventHandler(this.textBoxDuracion_TextChanged);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(316, 220);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(254, 20);
            this.textBoxPrecio.TabIndex = 11;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBoxPrecio_TextChanged);
            // 
            // textBoxIdioma
            // 
            this.textBoxIdioma.Location = new System.Drawing.Point(316, 178);
            this.textBoxIdioma.Name = "textBoxIdioma";
            this.textBoxIdioma.Size = new System.Drawing.Size(254, 20);
            this.textBoxIdioma.TabIndex = 10;
            this.textBoxIdioma.TextChanged += new System.EventHandler(this.textBoxIdioma_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Director";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sinopsis";
            // 
            // textBoxSinopsis
            // 
            this.textBoxSinopsis.Location = new System.Drawing.Point(316, 303);
            this.textBoxSinopsis.Multiline = true;
            this.textBoxSinopsis.Name = "textBoxSinopsis";
            this.textBoxSinopsis.Size = new System.Drawing.Size(254, 118);
            this.textBoxSinopsis.TabIndex = 18;
            this.textBoxSinopsis.TextChanged += new System.EventHandler(this.textBoxSinopsis_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Anio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Titulo";
            // 
            // textBoxAnio
            // 
            this.textBoxAnio.Location = new System.Drawing.Point(316, 138);
            this.textBoxAnio.Name = "textBoxAnio";
            this.textBoxAnio.Size = new System.Drawing.Size(254, 20);
            this.textBoxAnio.TabIndex = 25;
            this.textBoxAnio.TextChanged += new System.EventHandler(this.textBoxAnio_TextChanged);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(316, 100);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(254, 20);
            this.textBoxTitulo.TabIndex = 24;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(576, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Formato-> hh:mm:ss";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(576, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Formato-> sin simbolos o puntos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(576, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Max: 255 caracteres";
            // 
            // comboBoxDirector
            // 
            this.comboBoxDirector.FormattingEnabled = true;
            this.comboBoxDirector.Location = new System.Drawing.Point(316, 440);
            this.comboBoxDirector.Name = "comboBoxDirector";
            this.comboBoxDirector.Size = new System.Drawing.Size(254, 21);
            this.comboBoxDirector.TabIndex = 31;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(316, 471);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(254, 21);
            this.comboBoxCategoria.TabIndex = 32;
            // 
            // AgregarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 532);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxDirector);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAnio);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSinopsis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxDuracion);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxIdioma);
            this.Name = "AgregarPelicula";
            this.Text = "AgregarPelicula";
            this.Load += new System.EventHandler(this.AgregarPelicula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxDuracion;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxIdioma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSinopsis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAnio;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxDirector;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
    }
}