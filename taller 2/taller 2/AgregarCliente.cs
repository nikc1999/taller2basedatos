using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace taller_2
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void textBoxRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string insertar = "INSERT INTO cliente(RUT,Nombre,Email) VALUES ('" + textBoxRut.Text + "','" + textBoxNombre.Text + "','" + textBoxEmail.Text + "');";
            int insercionExitosa = 0;
            insercionExitosa = conex.executeNonQuery(insertar); //este metodo retorna un 1 si se inserto bien o 0 si no se pudo insertar
            if (insercionExitosa == 1)
            {
                MessageBox.Show("El cliente fue agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("El cliente no se pudo agregar.");
            }





        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            
        }
    }
}
