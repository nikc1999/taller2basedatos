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
    public partial class AgregarActor : Form
    {
        public AgregarActor()
        {
            InitializeComponent();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLugarNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void AgregarActor_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string insertar = "INSERT INTO actor(Nombre,Fecha,LugarNacimiento, NombreReal) VALUES ('" + textBoxNombre.Text + "','" + dateTimePicker1.Text + "','" + textBoxLugarNacimiento.Text + "','" + textBoxNombreReal.Text + "');";
            int insercionExitosa = 0;
            insercionExitosa = conex.executeNonQuery(insertar); //este metodo retorna un 1 si se inserto bien o 0 si no se pudo insertar
            if (insercionExitosa == 1)
            {
                MessageBox.Show("El actor fue agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("El actor no se pudo agregar.");
            }
            conex.close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
