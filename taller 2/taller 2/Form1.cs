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
            ConexMySQL conex = new ConexMySQL() ;
            conex.open();
            string query = "SELECT * FROM categoria";
            DataTable categorias = conex.selectQuery(query);
            for (int i =0; i< categorias.Rows.Count; i++)
            {
                comboBox1.Items.Add(categorias.Rows[i]["Nombre"]);
            }
            conex.close();
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
    }
}
