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
    public partial class PeliculasDadoDirector : Form
    {
        public PeliculasDadoDirector()
        {
            InitializeComponent();
        }

        private void PeliculasDadoDirector_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            //---------------------------------------
            // REQUISITO 11 
            //---------------------------------------
            string queryExiste = "SELECT COUNT(Nombre) FROM director WHERE Nombre = '" + textBoxDirector.Text + "';";   //retorna 0 si no existe ese director 
            string queryDatos = "SELECT Titulo FROM pelicula WHERE DirectorNombre = '" + textBoxDirector.Text + "';";

            string respuesta = conex.selectQueryScalar(queryExiste);

            if (respuesta == "1")
            {
                //mostrar informacion del cliente y el boton para agregar saldo
                DataTable datos = conex.selectQuery(queryDatos);

                listBoxPeliculas.Items.Clear();
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    listBoxPeliculas.Items.Add(datos.Rows[i]["Titulo"].ToString());
                }
                

                
            }
            else
            {
                MessageBox.Show("No existe un director con ese nombre.");
            }

            conex.close();
        }
    }
    
}
