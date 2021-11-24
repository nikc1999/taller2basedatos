﻿using System;
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

                saldo = Int32.Parse(labelSaldo.Text);
                buttonAgregarSaldo.Visible = true;
            }
            else
            {
                MessageBox.Show("No existe un cliente con ese Rut.");
            }
            //9-18
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
                MessageBox.Show("El cliente fue eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("El cliente no se pudo eliminar.");
            }
            conex.close();
        }

        private void textBoxSaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
