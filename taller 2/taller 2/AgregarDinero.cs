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
    public partial class AgregarDinero : Form
    {
        int saldo = 0;
        public AgregarDinero()
        {
            InitializeComponent();
        }

        private void textBoxRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryExiste = "SELECT COUNT(Nombre) FROM cliente WHERE RUT = '" + textBoxRut.Text + "';";   //retorna 0 si no existe ese rut 
            string queryDatos = "SELECT Nombre, Email, Saldo FROM cliente WHERE RUT = '" + textBoxRut.Text + "';";
            string respuesta = conex.selectQueryScalar(queryExiste);

            if (respuesta == "1")
            {
                //mostrar informacion del cliente y el boton para agregar saldo
                DataTable datos = conex.selectQuery(queryDatos);
                labelNombre.Text = datos.Rows[0]["Nombre"].ToString();
                labelEmail.Text = datos.Rows[0]["Email"].ToString();
                labelSaldo.Text = datos.Rows[0]["Saldo"].ToString();

                if (datos.Rows[0]["Saldo"].ToString() == "")
                {
                    saldo = 0;
                }
                else
                {
                    saldo = Int32.Parse(datos.Rows[0]["Saldo"].ToString());
                }
                
                buttonAgregarSaldo.Visible = true;
            }
            else
            {
                MessageBox.Show("No existe un cliente con ese Rut.");
            }
            
            conex.close();
        }

        private void buttonAgregarSaldo_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            int saldoActualizado = 0;
            saldoActualizado = Int32.Parse(textBoxSaldo.Text) + saldo;
            string actualizar = "UPDATE cliente SET saldo = "+ saldoActualizado +" WHERE RUT = '" + textBoxRut.Text + "';";

            int insercionExitosa = 0;
            insercionExitosa = conex.executeNonQuery(actualizar); //este metodo retorna un 1 si se inserto bien o 0 si no se pudo insertar
            if (insercionExitosa == 1)
            {
                MessageBox.Show("El saldo fue agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("El saldo no se pudo agregar.");
            }
            conex.close();
        }

        private void textBoxSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelSaldo_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
