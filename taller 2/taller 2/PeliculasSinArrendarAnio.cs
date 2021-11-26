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
    public partial class PeliculasSinArrendarAnio : Form
    {
        public PeliculasSinArrendarAnio()
        {
            InitializeComponent();
        }

        private void PeliculasSinArrendarAnio_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            //---------------------------------------
            // REQUISITO 19
            //---------------------------------------
            string queryExiste = "SELECT COUNT(*) FROM pelicula WHERE titulo NOT IN (SELECT PeliculaTitulo FROM arriendo WHERE extract(year FROM FechaArriendo) = extract(year from sysdate())) ;";   //retorna 0 si no existe ese rut 
            string queryDatos = "SELECT titulo FROM pelicula WHERE titulo NOT IN (SELECT PeliculaTitulo FROM arriendo WHERE extract(year FROM FechaArriendo) = extract(year from sysdate())) ;";

            string respuesta = conex.selectQueryScalar(queryExiste);

            if (respuesta != "0")
            {

                DataTable datos = conex.selectQuery(queryDatos);
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    listBoxPeliculas.Items.Add(datos.Rows[i]["Titulo"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay peliculas que cumplan la condicion.");
            }

            conex.close();
        }
    }
}
