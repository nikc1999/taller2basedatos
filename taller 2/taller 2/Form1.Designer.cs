
namespace taller_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSesionAdmin = new System.Windows.Forms.Button();
            this.buttonArrendarPelicula = new System.Windows.Forms.Button();
            this.buttonBusquedaRut = new System.Windows.Forms.Button();
            this.buttonBuscarTitulo = new System.Windows.Forms.Button();
            this.buttonPeliculasDadoDirector = new System.Windows.Forms.Button();
            this.buttonTitulosDadoAnioCategoria = new System.Windows.Forms.Button();
            this.buttonTop5Arrendadas = new System.Windows.Forms.Button();
            this.buttonListadoClientesPorArriendos = new System.Windows.Forms.Button();
            this.buttonPeliculasSinArrendarAnio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSesionAdmin
            // 
            this.buttonSesionAdmin.Location = new System.Drawing.Point(627, 427);
            this.buttonSesionAdmin.Name = "buttonSesionAdmin";
            this.buttonSesionAdmin.Size = new System.Drawing.Size(75, 23);
            this.buttonSesionAdmin.TabIndex = 1;
            this.buttonSesionAdmin.Text = "Admin";
            this.buttonSesionAdmin.UseVisualStyleBackColor = true;
            this.buttonSesionAdmin.Click += new System.EventHandler(this.buttonSesionAdmin_Click);
            // 
            // buttonArrendarPelicula
            // 
            this.buttonArrendarPelicula.Location = new System.Drawing.Point(55, 245);
            this.buttonArrendarPelicula.Name = "buttonArrendarPelicula";
            this.buttonArrendarPelicula.Size = new System.Drawing.Size(297, 23);
            this.buttonArrendarPelicula.TabIndex = 2;
            this.buttonArrendarPelicula.Text = "Arrendar Pelicula";
            this.buttonArrendarPelicula.UseVisualStyleBackColor = true;
            this.buttonArrendarPelicula.Click += new System.EventHandler(this.buttonArrendarPelicula_Click);
            // 
            // buttonBusquedaRut
            // 
            this.buttonBusquedaRut.Location = new System.Drawing.Point(55, 288);
            this.buttonBusquedaRut.Name = "buttonBusquedaRut";
            this.buttonBusquedaRut.Size = new System.Drawing.Size(297, 23);
            this.buttonBusquedaRut.TabIndex = 3;
            this.buttonBusquedaRut.Text = "Informacion De Cliente Dado Un RUT";
            this.buttonBusquedaRut.UseVisualStyleBackColor = true;
            this.buttonBusquedaRut.Click += new System.EventHandler(this.buttonBusquedaRut_Click);
            // 
            // buttonBuscarTitulo
            // 
            this.buttonBuscarTitulo.Location = new System.Drawing.Point(55, 335);
            this.buttonBuscarTitulo.Name = "buttonBuscarTitulo";
            this.buttonBuscarTitulo.Size = new System.Drawing.Size(297, 23);
            this.buttonBuscarTitulo.TabIndex = 4;
            this.buttonBuscarTitulo.Text = "Informacion De Pelicula Dado Titulo";
            this.buttonBuscarTitulo.UseVisualStyleBackColor = true;
            this.buttonBuscarTitulo.Click += new System.EventHandler(this.buttonBuscarTitulo_Click);
            // 
            // buttonPeliculasDadoDirector
            // 
            this.buttonPeliculasDadoDirector.Location = new System.Drawing.Point(55, 377);
            this.buttonPeliculasDadoDirector.Name = "buttonPeliculasDadoDirector";
            this.buttonPeliculasDadoDirector.Size = new System.Drawing.Size(297, 23);
            this.buttonPeliculasDadoDirector.TabIndex = 5;
            this.buttonPeliculasDadoDirector.Text = "Peliculas Dado Director";
            this.buttonPeliculasDadoDirector.UseVisualStyleBackColor = true;
            this.buttonPeliculasDadoDirector.Click += new System.EventHandler(this.buttonPeliculasDadoDirector_Click);
            // 
            // buttonTitulosDadoAnioCategoria
            // 
            this.buttonTitulosDadoAnioCategoria.Location = new System.Drawing.Point(400, 245);
            this.buttonTitulosDadoAnioCategoria.Name = "buttonTitulosDadoAnioCategoria";
            this.buttonTitulosDadoAnioCategoria.Size = new System.Drawing.Size(297, 23);
            this.buttonTitulosDadoAnioCategoria.TabIndex = 6;
            this.buttonTitulosDadoAnioCategoria.Text = "Titulos Dado Anio Y Categoria";
            this.buttonTitulosDadoAnioCategoria.UseVisualStyleBackColor = true;
            this.buttonTitulosDadoAnioCategoria.Click += new System.EventHandler(this.buttonTitulosDadoAnioCategoria_Click);
            // 
            // buttonTop5Arrendadas
            // 
            this.buttonTop5Arrendadas.Location = new System.Drawing.Point(400, 288);
            this.buttonTop5Arrendadas.Name = "buttonTop5Arrendadas";
            this.buttonTop5Arrendadas.Size = new System.Drawing.Size(297, 23);
            this.buttonTop5Arrendadas.TabIndex = 7;
            this.buttonTop5Arrendadas.Text = "Las Mas Arrendadas";
            this.buttonTop5Arrendadas.UseVisualStyleBackColor = true;
            this.buttonTop5Arrendadas.Click += new System.EventHandler(this.buttonTop5Arrendadas_Click);
            // 
            // buttonListadoClientesPorArriendos
            // 
            this.buttonListadoClientesPorArriendos.Location = new System.Drawing.Point(400, 335);
            this.buttonListadoClientesPorArriendos.Name = "buttonListadoClientesPorArriendos";
            this.buttonListadoClientesPorArriendos.Size = new System.Drawing.Size(297, 23);
            this.buttonListadoClientesPorArriendos.TabIndex = 8;
            this.buttonListadoClientesPorArriendos.Text = "Listado Cliente Por Arriendos";
            this.buttonListadoClientesPorArriendos.UseVisualStyleBackColor = true;
            this.buttonListadoClientesPorArriendos.Click += new System.EventHandler(this.buttonListadoClientesPorArriendos_Click);
            // 
            // buttonPeliculasSinArrendarAnio
            // 
            this.buttonPeliculasSinArrendarAnio.Location = new System.Drawing.Point(400, 377);
            this.buttonPeliculasSinArrendarAnio.Name = "buttonPeliculasSinArrendarAnio";
            this.buttonPeliculasSinArrendarAnio.Size = new System.Drawing.Size(297, 23);
            this.buttonPeliculasSinArrendarAnio.TabIndex = 9;
            this.buttonPeliculasSinArrendarAnio.Text = "Peliculas Sin Arriendo Anual";
            this.buttonPeliculasSinArrendarAnio.UseVisualStyleBackColor = true;
            this.buttonPeliculasSinArrendarAnio.Click += new System.EventHandler(this.buttonPeliculasSinArrendarAnio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Blokbaster";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::taller_2.Properties.Resources.blokmaster;
            this.pictureBox1.Location = new System.Drawing.Point(238, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 173);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPeliculasSinArrendarAnio);
            this.Controls.Add(this.buttonListadoClientesPorArriendos);
            this.Controls.Add(this.buttonTop5Arrendadas);
            this.Controls.Add(this.buttonTitulosDadoAnioCategoria);
            this.Controls.Add(this.buttonPeliculasDadoDirector);
            this.Controls.Add(this.buttonBuscarTitulo);
            this.Controls.Add(this.buttonBusquedaRut);
            this.Controls.Add(this.buttonArrendarPelicula);
            this.Controls.Add(this.buttonSesionAdmin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSesionAdmin;
        private System.Windows.Forms.Button buttonArrendarPelicula;
        private System.Windows.Forms.Button buttonBusquedaRut;
        private System.Windows.Forms.Button buttonBuscarTitulo;
        private System.Windows.Forms.Button buttonPeliculasDadoDirector;
        private System.Windows.Forms.Button buttonTitulosDadoAnioCategoria;
        private System.Windows.Forms.Button buttonTop5Arrendadas;
        private System.Windows.Forms.Button buttonListadoClientesPorArriendos;
        private System.Windows.Forms.Button buttonPeliculasSinArrendarAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

