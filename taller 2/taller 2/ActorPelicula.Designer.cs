
namespace taller_2
{
    partial class ActorPelicula
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
            this.comboBoxActor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPelicula = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxActor
            // 
            this.comboBoxActor.FormattingEnabled = true;
            this.comboBoxActor.Location = new System.Drawing.Point(279, 76);
            this.comboBoxActor.Name = "comboBoxActor";
            this.comboBoxActor.Size = new System.Drawing.Size(238, 21);
            this.comboBoxActor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Agregar Actor A Pelicula";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxPelicula
            // 
            this.comboBoxPelicula.FormattingEnabled = true;
            this.comboBoxPelicula.Location = new System.Drawing.Point(279, 126);
            this.comboBoxPelicula.Name = "comboBoxPelicula";
            this.comboBoxPelicula.Size = new System.Drawing.Size(238, 21);
            this.comboBoxPelicula.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pelicula";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(349, 227);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 21;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // ActorPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.comboBoxPelicula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxActor);
            this.Controls.Add(this.label1);
            this.Name = "ActorPelicula";
            this.Text = "ActorPelicula";
            this.Load += new System.EventHandler(this.ActorPelicula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxActor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAgregar;
    }
}