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
    public partial class ActorPelicula : Form
    {
        public ActorPelicula()
        {
            InitializeComponent();
        }

        private void ActorPelicula_Load(object sender, EventArgs e)
        {
            //rellenar comboBox de actores y peliculas
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM actor";
            DataTable categorias = conex.selectQuery(query);
            for (int i = 0; i < categorias.Rows.Count; i++)
            {
                comboBoxActor.Items.Add(categorias.Rows[i]["Nombre"]);
            }
            conex.close();

            ConexMySQL conex2 = new ConexMySQL();
            conex2.open();
            string query2 = "SELECT * FROM pelicula";
            DataTable categorias2 = conex2.selectQuery(query2);
            for (int i = 0; i < categorias2.Rows.Count; i++)
            {
                comboBoxPelicula.Items.Add(categorias2.Rows[i]["Titulo"]);
            }
            conex2.close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
           
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "INSERT INTO actua VALUES('" + comboBoxPelicula.Text + "', '" + comboBoxActor.Text + "');";
            int respuesta = conex.executeNonQuery(query);
            if (respuesta == 1)
            {
                MessageBox.Show("Actor Agregado a Pelicula con EXITO"); 
            }
            else
            {
                MessageBox.Show("Este actor ya esta agregado en la pelicula");
            }
            conex.close();
        }
    }
}
