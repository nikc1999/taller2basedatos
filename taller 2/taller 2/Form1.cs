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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSesionAdmin_Click(object sender, EventArgs e)
        {
            AutenticarAdmin autenticarAdmin = new AutenticarAdmin();
            autenticarAdmin.Show();
            //min 48 ayudantia 5
            //AgregarCliente test = new AgregarCliente();
            //test.Show();

        }

        private void buttonArrendarPelicula_Click(object sender, EventArgs e)
        {
            ArriendoPelicula arriendoPelicula = new ArriendoPelicula();
            arriendoPelicula.Show();        
        }

        private void buttonBusquedaRut_Click(object sender, EventArgs e)
        {
            BusquedaRut busquedaRut = new BusquedaRut();
            busquedaRut.Show();
        }

        private void buttonBuscarTitulo_Click(object sender, EventArgs e)
        {
            BusquedaTitulo busquedaTitulo = new BusquedaTitulo();
            busquedaTitulo.Show();
        }

        private void buttonPeliculasDadoDirector_Click(object sender, EventArgs e)
        {
            PeliculasDadoDirector peliculasDadoDirector = new PeliculasDadoDirector();
            peliculasDadoDirector.Show();
        }

        private void buttonTitulosDadoAnioCategoria_Click(object sender, EventArgs e)
        {
            TitulosDadoAnioCategoria titulosDadoAnioCategoria = new TitulosDadoAnioCategoria();
            titulosDadoAnioCategoria.Show();
        }

        private void buttonTop5Arrendadas_Click(object sender, EventArgs e)
        {
            Top5Arrendadas top5Arrendadas = new Top5Arrendadas();
            top5Arrendadas.Show();

        }
    }
}
