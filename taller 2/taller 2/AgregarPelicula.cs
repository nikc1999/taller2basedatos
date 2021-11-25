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
    public partial class AgregarPelicula : Form
    {
        public AgregarPelicula()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string insertar = "INSERT INTO pelicula(Titulo,Anio,Idioma,Precio,Duracion,Sinopsis,DirectorNombre,CategoriaNombre) VALUES ('" + textBoxTitulo.Text + "','" + textBoxAnio.Text + "','" + textBoxIdioma.Text+ "','" 
               + textBoxPrecio.Text + "','" + textBoxDuracion.Text + "','" + textBoxSinopsis.Text + "','" + comboBoxDirector.Text + "','" + comboBoxCategoria.Text + "');";

            

            int insercionExitosa = 0;
            insercionExitosa = conex.executeNonQuery(insertar); //este metodo retorna un 1 si se inserto bien o 0 si no se pudo insertar
            if (insercionExitosa == 1)
            {
                MessageBox.Show("La pelicula fue agregada exitosamente.");
            }
            else
            {
                MessageBox.Show("La pelicula no se pudo agregar.");
            }
            conex.close();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAnio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSinopsis_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDuracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdioma_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarPelicula_Load(object sender, EventArgs e)
        {
            textBoxSinopsis.MaxLength = 255;
            //rellenar comboBox de directores y de categorias
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM categoria";
            DataTable categorias = conex.selectQuery(query);
            for (int i = 0; i < categorias.Rows.Count; i++)
            {
                comboBoxCategoria.Items.Add(categorias.Rows[i]["Nombre"]);
            }
            conex.close();

            ConexMySQL conex2 = new ConexMySQL();
            conex2.open();
            string query2 = "SELECT * FROM director";
            DataTable categorias2 = conex2.selectQuery(query2);
            for (int i = 0; i < categorias2.Rows.Count; i++)
            {
                comboBoxDirector.Items.Add(categorias2.Rows[i]["Nombre"]);
            }
            conex2.close();

        }
    }
}
