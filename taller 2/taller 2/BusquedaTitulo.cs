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
    public partial class BusquedaTitulo : Form
    {
        public BusquedaTitulo()
        {
            InitializeComponent();
        }

        private void buttonBuscarPelicula_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            //---------------------------------------
            // REQUISITO 9
            //---------------------------------------
            string queryExiste = "SELECT COUNT(Titulo) FROM pelicula WHERE Titulo = '" + textBoxTitulo.Text + "';";   //retorna 0 si no existe ese rut 
            string queryDatos = "SELECT ClienteRUT, FechaArriendo FROM arriendo WHERE PeliculaTitulo = '" + textBoxTitulo.Text + "' AND FechaArriendo >= date(sysdate()) - interval weekday((sysdate())) day; ; ";

            string respuesta = conex.selectQueryScalar(queryExiste);

            if (respuesta != "0")
            {
                
                DataTable datos = conex.selectQuery(queryDatos);
                listBoxSemanaActual.Items.Clear();
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    listBoxSemanaActual.Items.Add(datos.Rows[i][0].ToString() + "    " + datos.Rows[i][1].ToString().Split(' ')[0]);
                }

                //---------------------------------------
                // REQUISITO 10
                //---------------------------------------

                
                queryDatos = "SELECT * FROM actua JOIN pelicula ON actua.PeliculaTitulo = pelicula.titulo JOIN actor ON actor.Nombre = actua.ActorNombre WHERE PeliculaTitulo = '" + textBoxTitulo.Text + "';  ";
                string queryDatos2 = "SELECT * FROM pelicula WHERE Titulo = '" + textBoxTitulo.Text + "';  ";
                datos.Clear();
                datos = conex.selectQuery(queryDatos);
                DataTable datos2 = conex.selectQuery(queryDatos2);

                labelTitulo.Text = datos2.Rows[0]["Titulo"].ToString();
                labelAnio.Text = datos2.Rows[0]["Anio"].ToString();
                labelDuracion.Text = datos2.Rows[0]["Duracion"].ToString();
                labelDirector.Text = datos2.Rows[0]["DirectorNombre"].ToString();
                labelCategoria.Text = datos2.Rows[0]["CategoriaNombre"].ToString();
                textBoxSinopsis.Text = datos2.Rows[0]["Sinopsis"].ToString();


                listBoxActores.Items.Clear();
                listBoxNombreReal.Items.Clear();
                listBoxLugarNacimiento.Items.Clear();
                listBoxFecha.Items.Clear();
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    listBoxActores.Items.Add(datos.Rows[i]["ActorNombre"].ToString());
                    listBoxNombreReal.Items.Add(datos.Rows[i]["NombreReal"].ToString());
                    listBoxLugarNacimiento.Items.Add(datos.Rows[i]["LugarNacimiento"].ToString());
                    listBoxFecha.Items.Add(datos.Rows[i]["Fecha"].ToString().Split(' ')[0]);
                }

                //---------------------------------------
                // REQUISITO 15
                //---------------------------------------

                queryDatos = "SELECT count(*) FROM arriendo WHERE PeliculaTitulo = '" + textBoxTitulo.Text + "' AND FechaArriendo >= date(sysdate()) - interval '7' day;";
                datos.Clear();
                string cantidad = conex.selectQueryScalar(queryDatos);
                labelNumeroArriendos.Text = cantidad;




            }
            else
            {
                MessageBox.Show("No existe una pelicula con ese Titulo.");
            }

            conex.close();
        }

        private void BusquedaTitulo_Load(object sender, EventArgs e)
        {
            labelTitulo.Text = "";
            labelAnio.Text = "";
            labelDuracion.Text = "";
            labelDirector.Text = "";
            labelCategoria.Text = "";
            labelNumeroArriendos.Text = "";
        }
    }
    
}
