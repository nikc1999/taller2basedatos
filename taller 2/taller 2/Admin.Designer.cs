
namespace taller_2
{
    partial class Admin
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
            this.buttonAgregarCliente = new System.Windows.Forms.Button();
            this.buttonAgregarPelicula = new System.Windows.Forms.Button();
            this.buttonAgregarActor = new System.Windows.Forms.Button();
            this.buttonAgregarDirector = new System.Windows.Forms.Button();
            this.buttonEliminarCliente = new System.Windows.Forms.Button();
            this.buttonAgregarDinero = new System.Windows.Forms.Button();
            this.buttonActorPelicula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgregarCliente
            // 
            this.buttonAgregarCliente.Location = new System.Drawing.Point(294, 40);
            this.buttonAgregarCliente.Name = "buttonAgregarCliente";
            this.buttonAgregarCliente.Size = new System.Drawing.Size(159, 23);
            this.buttonAgregarCliente.TabIndex = 0;
            this.buttonAgregarCliente.Text = "Agregar Cliente";
            this.buttonAgregarCliente.UseVisualStyleBackColor = true;
            this.buttonAgregarCliente.Click += new System.EventHandler(this.buttonAgregarCliente_Click);
            // 
            // buttonAgregarPelicula
            // 
            this.buttonAgregarPelicula.Location = new System.Drawing.Point(294, 88);
            this.buttonAgregarPelicula.Name = "buttonAgregarPelicula";
            this.buttonAgregarPelicula.Size = new System.Drawing.Size(159, 23);
            this.buttonAgregarPelicula.TabIndex = 1;
            this.buttonAgregarPelicula.Text = "Agregar Pelicula";
            this.buttonAgregarPelicula.UseVisualStyleBackColor = true;
            this.buttonAgregarPelicula.Click += new System.EventHandler(this.buttonAgregarPelicula_Click);
            // 
            // buttonAgregarActor
            // 
            this.buttonAgregarActor.Location = new System.Drawing.Point(294, 137);
            this.buttonAgregarActor.Name = "buttonAgregarActor";
            this.buttonAgregarActor.Size = new System.Drawing.Size(159, 23);
            this.buttonAgregarActor.TabIndex = 2;
            this.buttonAgregarActor.Text = "Agregar Actor";
            this.buttonAgregarActor.UseVisualStyleBackColor = true;
            this.buttonAgregarActor.Click += new System.EventHandler(this.buttonAgregarActor_Click);
            // 
            // buttonAgregarDirector
            // 
            this.buttonAgregarDirector.Location = new System.Drawing.Point(294, 213);
            this.buttonAgregarDirector.Name = "buttonAgregarDirector";
            this.buttonAgregarDirector.Size = new System.Drawing.Size(159, 23);
            this.buttonAgregarDirector.TabIndex = 3;
            this.buttonAgregarDirector.Text = "Agregar Director";
            this.buttonAgregarDirector.UseVisualStyleBackColor = true;
            this.buttonAgregarDirector.Click += new System.EventHandler(this.buttonAgregarDirector_Click);
            // 
            // buttonEliminarCliente
            // 
            this.buttonEliminarCliente.Location = new System.Drawing.Point(294, 256);
            this.buttonEliminarCliente.Name = "buttonEliminarCliente";
            this.buttonEliminarCliente.Size = new System.Drawing.Size(159, 23);
            this.buttonEliminarCliente.TabIndex = 4;
            this.buttonEliminarCliente.Text = "Eliminar Cliente";
            this.buttonEliminarCliente.UseVisualStyleBackColor = true;
            this.buttonEliminarCliente.Click += new System.EventHandler(this.buttonEliminarCliente_Click);
            // 
            // buttonAgregarDinero
            // 
            this.buttonAgregarDinero.Location = new System.Drawing.Point(294, 301);
            this.buttonAgregarDinero.Name = "buttonAgregarDinero";
            this.buttonAgregarDinero.Size = new System.Drawing.Size(159, 23);
            this.buttonAgregarDinero.TabIndex = 5;
            this.buttonAgregarDinero.Text = "Agregar Dinero a Cuenta";
            this.buttonAgregarDinero.UseVisualStyleBackColor = true;
            this.buttonAgregarDinero.Click += new System.EventHandler(this.buttonAgregarDinero_Click);
            // 
            // buttonActorPelicula
            // 
            this.buttonActorPelicula.Location = new System.Drawing.Point(294, 174);
            this.buttonActorPelicula.Name = "buttonActorPelicula";
            this.buttonActorPelicula.Size = new System.Drawing.Size(159, 23);
            this.buttonActorPelicula.TabIndex = 6;
            this.buttonActorPelicula.Text = "Agregar Actor a Pelicula";
            this.buttonActorPelicula.UseVisualStyleBackColor = true;
            this.buttonActorPelicula.Click += new System.EventHandler(this.buttonActorPelicula_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonActorPelicula);
            this.Controls.Add(this.buttonAgregarDinero);
            this.Controls.Add(this.buttonEliminarCliente);
            this.Controls.Add(this.buttonAgregarDirector);
            this.Controls.Add(this.buttonAgregarActor);
            this.Controls.Add(this.buttonAgregarPelicula);
            this.Controls.Add(this.buttonAgregarCliente);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarCliente;
        private System.Windows.Forms.Button buttonAgregarPelicula;
        private System.Windows.Forms.Button buttonAgregarActor;
        private System.Windows.Forms.Button buttonAgregarDirector;
        private System.Windows.Forms.Button buttonEliminarCliente;
        private System.Windows.Forms.Button buttonAgregarDinero;
        private System.Windows.Forms.Button buttonActorPelicula;
    }
}