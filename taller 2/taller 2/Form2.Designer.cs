﻿
namespace taller_2
{
    partial class Form2
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
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonContra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxContra
            // 
            this.textBoxContra.Location = new System.Drawing.Point(171, 101);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.Size = new System.Drawing.Size(217, 20);
            this.textBoxContra.TabIndex = 0;
            this.textBoxContra.TextChanged += new System.EventHandler(this.textBoxContra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese contrasena de administracion";
            // 
            // buttonContra
            // 
            this.buttonContra.Location = new System.Drawing.Point(429, 97);
            this.buttonContra.Name = "buttonContra";
            this.buttonContra.Size = new System.Drawing.Size(92, 24);
            this.buttonContra.TabIndex = 2;
            this.buttonContra.Text = "autenticar";
            this.buttonContra.UseVisualStyleBackColor = true;
            this.buttonContra.Click += new System.EventHandler(this.buttonContra_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContra);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonContra;
    }
}