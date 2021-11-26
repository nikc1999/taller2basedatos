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
    public partial class TitulosDadoAnioCategoria : Form
    {
        public TitulosDadoAnioCategoria()
        {
            InitializeComponent();
        }

        private void TitulosDadoAnioCategoria_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM categoria";
            DataTable categorias = conex.selectQuery(query);
            for (int i = 0; i < categorias.Rows.Count; i++)
            {
                comboBox1.Items.Add(categorias.Rows[i]["Nombre"]);
            }
            conex.close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            //---------------------------------------
            // REQUISITO 12 
            //---------------------------------------
            string queryExiste = "SELECT COUNT(Titulo) FROM pelicula WHERE Anio = '" + textBoxAnio.Text + "' AND CategoriaNombre = '" + comboBox1.Text + "';";   //retorna 0 si no existe ese director 
            string queryDatos = "SELECT Titulo FROM pelicula WHERE Anio = '" + textBoxAnio.Text + "' AND categoriaNombre = '" + comboBox1.Text + "'; ";

            string respuesta = conex.selectQueryScalar(queryExiste);

            if (respuesta != "0")
            {
                
                DataTable datos = conex.selectQuery(queryDatos);

                listBoxPeliculas.Items.Clear();
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    listBoxPeliculas.Items.Add(datos.Rows[i]["Titulo"].ToString());
                }



            }
            else
            {
                MessageBox.Show("No existe una pelicula con estas caracteristicas.");
            }

            conex.close();
        }
    }
}
