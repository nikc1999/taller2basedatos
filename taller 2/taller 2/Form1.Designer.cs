
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
            this.SuspendLayout();
            // 
            // buttonSesionAdmin
            // 
            this.buttonSesionAdmin.Location = new System.Drawing.Point(544, 58);
            this.buttonSesionAdmin.Name = "buttonSesionAdmin";
            this.buttonSesionAdmin.Size = new System.Drawing.Size(75, 23);
            this.buttonSesionAdmin.TabIndex = 1;
            this.buttonSesionAdmin.Text = "Admin";
            this.buttonSesionAdmin.UseVisualStyleBackColor = true;
            this.buttonSesionAdmin.Click += new System.EventHandler(this.buttonSesionAdmin_Click);
            // 
            // buttonArrendarPelicula
            // 
            this.buttonArrendarPelicula.Location = new System.Drawing.Point(532, 106);
            this.buttonArrendarPelicula.Name = "buttonArrendarPelicula";
            this.buttonArrendarPelicula.Size = new System.Drawing.Size(116, 23);
            this.buttonArrendarPelicula.TabIndex = 2;
            this.buttonArrendarPelicula.Text = "7Arrendar Pelicula";
            this.buttonArrendarPelicula.UseVisualStyleBackColor = true;
            this.buttonArrendarPelicula.Click += new System.EventHandler(this.buttonArrendarPelicula_Click);
            // 
            // buttonBusquedaRut
            // 
            this.buttonBusquedaRut.Location = new System.Drawing.Point(418, 144);
            this.buttonBusquedaRut.Name = "buttonBusquedaRut";
            this.buttonBusquedaRut.Size = new System.Drawing.Size(297, 23);
            this.buttonBusquedaRut.TabIndex = 3;
            this.buttonBusquedaRut.Text = "8-13-17-18  Informacion De Cliente Dado Un RUT";
            this.buttonBusquedaRut.UseVisualStyleBackColor = true;
            this.buttonBusquedaRut.Click += new System.EventHandler(this.buttonBusquedaRut_Click);
            // 
            // buttonBuscarTitulo
            // 
            this.buttonBuscarTitulo.Location = new System.Drawing.Point(418, 191);
            this.buttonBuscarTitulo.Name = "buttonBuscarTitulo";
            this.buttonBuscarTitulo.Size = new System.Drawing.Size(297, 23);
            this.buttonBuscarTitulo.TabIndex = 4;
            this.buttonBuscarTitulo.Text = "9-10-15  Informacion De Pelicula Dado Titulo";
            this.buttonBuscarTitulo.UseVisualStyleBackColor = true;
            this.buttonBuscarTitulo.Click += new System.EventHandler(this.buttonBuscarTitulo_Click);
            // 
            // buttonPeliculasDadoDirector
            // 
            this.buttonPeliculasDadoDirector.Location = new System.Drawing.Point(418, 233);
            this.buttonPeliculasDadoDirector.Name = "buttonPeliculasDadoDirector";
            this.buttonPeliculasDadoDirector.Size = new System.Drawing.Size(297, 23);
            this.buttonPeliculasDadoDirector.TabIndex = 5;
            this.buttonPeliculasDadoDirector.Text = "11 Peliculas Dado Director";
            this.buttonPeliculasDadoDirector.UseVisualStyleBackColor = true;
            this.buttonPeliculasDadoDirector.Click += new System.EventHandler(this.buttonPeliculasDadoDirector_Click);
            // 
            // buttonTitulosDadoAnioCategoria
            // 
            this.buttonTitulosDadoAnioCategoria.Location = new System.Drawing.Point(418, 274);
            this.buttonTitulosDadoAnioCategoria.Name = "buttonTitulosDadoAnioCategoria";
            this.buttonTitulosDadoAnioCategoria.Size = new System.Drawing.Size(297, 23);
            this.buttonTitulosDadoAnioCategoria.TabIndex = 6;
            this.buttonTitulosDadoAnioCategoria.Text = "12 Titulos Dado Anio Y Categoria";
            this.buttonTitulosDadoAnioCategoria.UseVisualStyleBackColor = true;
            this.buttonTitulosDadoAnioCategoria.Click += new System.EventHandler(this.buttonTitulosDadoAnioCategoria_Click);
            // 
            // buttonTop5Arrendadas
            // 
            this.buttonTop5Arrendadas.Location = new System.Drawing.Point(418, 316);
            this.buttonTop5Arrendadas.Name = "buttonTop5Arrendadas";
            this.buttonTop5Arrendadas.Size = new System.Drawing.Size(297, 23);
            this.buttonTop5Arrendadas.TabIndex = 7;
            this.buttonTop5Arrendadas.Text = "14 Las Mas Arrendadas";
            this.buttonTop5Arrendadas.UseVisualStyleBackColor = true;
            this.buttonTop5Arrendadas.Click += new System.EventHandler(this.buttonTop5Arrendadas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 478);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSesionAdmin;
        private System.Windows.Forms.Button buttonArrendarPelicula;
        private System.Windows.Forms.Button buttonBusquedaRut;
        private System.Windows.Forms.Button buttonBuscarTitulo;
        private System.Windows.Forms.Button buttonPeliculasDadoDirector;
        private System.Windows.Forms.Button buttonTitulosDadoAnioCategoria;
        private System.Windows.Forms.Button buttonTop5Arrendadas;
    }
}

