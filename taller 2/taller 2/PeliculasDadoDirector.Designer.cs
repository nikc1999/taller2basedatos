
namespace taller_2
{
    partial class PeliculasDadoDirector
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
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.Location = new System.Drawing.Point(380, 181);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.ScrollAlwaysVisible = true;
            this.listBoxPeliculas.Size = new System.Drawing.Size(239, 95);
            this.listBoxPeliculas.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Peliculas Del Director: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 31);
            this.label4.TabIndex = 100;
            this.label4.Text = "Peliculas Dado Director";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Nombre Director";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(679, 96);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(98, 23);
            this.buttonBuscar.TabIndex = 97;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(394, 98);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(254, 20);
            this.textBoxDirector.TabIndex = 96;
            // 
            // PeliculasDadoDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 521);
            this.Controls.Add(this.listBoxPeliculas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxDirector);
            this.Name = "PeliculasDadoDirector";
            this.Text = "PeliculasDadoDirector";
            this.Load += new System.EventHandler(this.PeliculasDadoDirector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPeliculas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxDirector;
    }
}