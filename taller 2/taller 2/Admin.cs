using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente agregarCliente = new AgregarCliente();
            agregarCliente.Show();
        }

        private void buttonAgregarPelicula_Click(object sender, EventArgs e)
        {
            AgregarPelicula agregarPelicula = new AgregarPelicula();
            agregarPelicula.Show();
        }

        private void buttonAgregarActor_Click(object sender, EventArgs e)
        {
            AgregarActor agregarActor = new AgregarActor();
            agregarActor.Show();
        }

        private void buttonAgregarDirector_Click(object sender, EventArgs e)
        {
            AgregarDirector agregarDirector = new AgregarDirector();
            agregarDirector.Show();
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente eliminarCliente = new EliminarCliente();
            eliminarCliente.Show();
        }

        private void buttonAgregarDinero_Click(object sender, EventArgs e)
        {
            AgregarDinero agregarDinero = new AgregarDinero();
            agregarDinero.Show();
        }
    }
}
