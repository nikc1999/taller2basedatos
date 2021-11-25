
namespace taller_2
{
    partial class AgregarDinero
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonAgregarSaldo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxRut = new System.Windows.Forms.TextBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(312, 173);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 13);
            this.labelEmail.TabIndex = 38;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(312, 131);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(0, 13);
            this.labelNombre.TabIndex = 37;
            // 
            // buttonAgregarSaldo
            // 
            this.buttonAgregarSaldo.Location = new System.Drawing.Point(522, 241);
            this.buttonAgregarSaldo.Name = "buttonAgregarSaldo";
            this.buttonAgregarSaldo.Size = new System.Drawing.Size(98, 23);
            this.buttonAgregarSaldo.TabIndex = 36;
            this.buttonAgregarSaldo.Text = "Agregar Saldo";
            this.buttonAgregarSaldo.UseVisualStyleBackColor = true;
            this.buttonAgregarSaldo.Visible = false;
            this.buttonAgregarSaldo.Click += new System.EventHandler(this.buttonAgregarSaldo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "Agregar saldo cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Rut";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(522, 87);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 31;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxRut
            // 
            this.textBoxRut.Location = new System.Drawing.Point(237, 89);
            this.textBoxRut.Name = "textBoxRut";
            this.textBoxRut.Size = new System.Drawing.Size(254, 20);
            this.textBoxRut.TabIndex = 30;
            this.textBoxRut.TextChanged += new System.EventHandler(this.textBoxRut_TextChanged);
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(312, 212);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(0, 13);
            this.labelSaldo.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Saldo por Agregar";
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(234, 244);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(254, 20);
            this.textBoxSaldo.TabIndex = 42;
            this.textBoxSaldo.TextChanged += new System.EventHandler(this.textBoxSaldo_TextChanged);
            // 
            // AgregarDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonAgregarSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxRut);
            this.Name = "AgregarDinero";
            this.Text = "AgregarDinero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonAgregarSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxRut;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSaldo;
    }
}