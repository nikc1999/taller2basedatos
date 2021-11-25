
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSesionAdmin = new System.Windows.Forms.Button();
            this.buttonArrendarPelicula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 60);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.buttonArrendarPelicula.Location = new System.Drawing.Point(336, 60);
            this.buttonArrendarPelicula.Name = "buttonArrendarPelicula";
            this.buttonArrendarPelicula.Size = new System.Drawing.Size(75, 23);
            this.buttonArrendarPelicula.TabIndex = 2;
            this.buttonArrendarPelicula.Text = "Arrendar Pelicula";
            this.buttonArrendarPelicula.UseVisualStyleBackColor = true;
            this.buttonArrendarPelicula.Click += new System.EventHandler(this.buttonArrendarPelicula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 478);
            this.Controls.Add(this.buttonArrendarPelicula);
            this.Controls.Add(this.buttonSesionAdmin);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSesionAdmin;
        private System.Windows.Forms.Button buttonArrendarPelicula;
    }
}

