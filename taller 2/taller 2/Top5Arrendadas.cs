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
    public partial class Top5Arrendadas : Form
    {
        public Top5Arrendadas()
        {
            InitializeComponent();
        }

        private void Top5Arrendadas_Load(object sender, EventArgs e)
        {
            label1Lugar.Text = "";
            label2Lugar.Text = "";
            label3Lugar.Text = "";
            label4Lugar.Text = "";
            label5Lugar.Text = "";

            ConexMySQL conex = new ConexMySQL();
            conex.open();
            //---------------------------------------
            // REQUISITO 14
            //---------------------------------------
            string queryExiste = "SELECT COUNT(*) FROM pelicula;";   //retorna 0 si no existe ese rut 
            string queryDatos = "SELECT PeliculaTitulo, COUNT(*) FROM arriendo WHERE FechaArriendo >= date(sysdate())- interval weekday((sysdate())) day GROUP BY PeliculaTitulo ORDER BY 2 desc limit 5;";

            string respuesta = conex.selectQueryScalar(queryExiste);

            if (respuesta != "0")
            {
                //mostrar informacion del cliente y el boton para agregar saldo
                DataTable datos = conex.selectQuery(queryDatos);

                if (datos.Rows.Count == 5)
                {
                    label1Lugar.Text = datos.Rows[0]["PeliculaTitulo"].ToString();
                    label2Lugar.Text = datos.Rows[1]["PeliculaTitulo"].ToString();
                    label3Lugar.Text = datos.Rows[2]["PeliculaTitulo"].ToString();
                    label4Lugar.Text = datos.Rows[3]["PeliculaTitulo"].ToString();
                    label5Lugar.Text = datos.Rows[4]["PeliculaTitulo"].ToString();
                }
                else if (datos.Rows.Count == 4)
                {
                    label1Lugar.Text = datos.Rows[0]["PeliculaTitulo"].ToString();
                    label2Lugar.Text = datos.Rows[1]["PeliculaTitulo"].ToString();
                    label3Lugar.Text = datos.Rows[2]["PeliculaTitulo"].ToString();
                    label4Lugar.Text = datos.Rows[3]["PeliculaTitulo"].ToString();
                    
                }
                else if (datos.Rows.Count == 3)
                {
                    label1Lugar.Text = datos.Rows[0]["PeliculaTitulo"].ToString();
                    label2Lugar.Text = datos.Rows[1]["PeliculaTitulo"].ToString();
                    label3Lugar.Text = datos.Rows[2]["PeliculaTitulo"].ToString();
                    
                    
                }
                else if (datos.Rows.Count == 2)
                {
                    label1Lugar.Text = datos.Rows[0]["PeliculaTitulo"].ToString();
                    label2Lugar.Text = datos.Rows[1]["PeliculaTitulo"].ToString();
                    
                }
                else if (datos.Rows.Count == 1)
                {
                    label1Lugar.Text = datos.Rows[0]["PeliculaTitulo"].ToString();
                }


            }
            else
            {
                MessageBox.Show("NO HAY PELICULAS EN EL SISTEMA.");
            }

            conex.close();


        }
    }
}
