
namespace taller_2
{
    partial class PeliculasSinArrendarAnio
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peliculas Sin Arrendar En El Anio Actual";
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.ItemHeight = 20;
            this.listBoxPeliculas.Location = new System.Drawing.Point(207, 99);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.Size = new System.Drawing.Size(295, 304);
            this.listBoxPeliculas.TabIndex = 2;
            // 
            // PeliculasSinArrendarAnio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPeliculas);
            this.Name = "PeliculasSinArrendarAnio";
            this.Text = "PeliculasSinArrendarAnio";
            this.Load += new System.EventHandler(this.PeliculasSinArrendarAnio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPeliculas;
    }
}