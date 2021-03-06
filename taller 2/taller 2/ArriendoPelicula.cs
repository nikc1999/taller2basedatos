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
    public partial class ArriendoPelicula : Form
    {
        int saldo = 0;
        int precio = 0;
        bool clickCliente = false;
        bool clickPelicula = false;
        string rutCliente = "";
        public ArriendoPelicula()
        {
            InitializeComponent();
        }

        private void ArriendoPelicula_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryExiste = "SELECT COUNT(Nombre) FROM cliente WHERE RUT = '" + textBoxRut.Text + "' AND activo = 'si';";   //retorna 0 si no existe ese rut 
            string queryDatos = "SELECT Nombre, Saldo, RUT FROM cliente WHERE RUT = '" + textBoxRut.Text + "';";
            string respuesta = conex.selectQueryScalar(queryExiste);

            if (respuesta == "1")
            {
                //mostrar informacion del cliente y el boton para agregar saldo
                DataTable datos = conex.selectQuery(queryDatos);
                labelNombre.Text = datos.Rows[0]["Nombre"].ToString();               
                rutCliente = datos.Rows[0]["RUT"].ToString();

                if (datos.Rows[0]["Saldo"].ToString() == "")
                {
                    saldo = 0;
                    labelSaldo.Text = "0";
                }
                else
                {
                    saldo = Int32.Parse(datos.Rows[0]["Saldo"].ToString());
                    labelSaldo.Text = datos.Rows[0]["Saldo"].ToString();
                }

                clickCliente = true;
                if (clickPelicula == true && clickCliente == true)
                {
                    buttonArrendarPelicula.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No existe un cliente con ese Rut.");
            }

            conex.close();
        }

        private void buttonBuscarPelicula_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryExiste = "SELECT COUNT(Titulo) FROM pelicula WHERE Titulo = '" + textBoxTitulo.Text + "';";   //retorna 0 si no existe ese rut 
            string queryDatos = "SELECT Anio, Precio FROM pelicula WHERE Titulo = '" + textBoxTitulo.Text + "';";
            string respuesta = conex.selectQueryScalar(queryExiste);

            if (respuesta == "1")
            {
                //mostrar informacion del cliente y el boton para agregar saldo
                DataTable datos = conex.selectQuery(queryDatos);
                labelAnio.Text = datos.Rows[0]["Anio"].ToString();
                labelPrecio.Text = datos.Rows[0]["Precio"].ToString();
                labelTituloPelicula.Text = textBoxTitulo.Text;

                precio = Int32.Parse(datos.Rows[0]["Precio"].ToString());


                clickPelicula = true;
                if (clickPelicula == true && clickCliente == true)
                {
                    buttonArrendarPelicula.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No existe un cliente con ese Rut.");
            }

            conex.close();
        }

        private void buttonBuscarPeliculaActor_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryExiste = "SELECT COUNT(Nombre) FROM actor WHERE Nombre = '" + textBoxNombreActor.Text + "';";   //retorna 0 si no existe ese rut 
            string queryDatos = "SELECT * FROM pelicula WHERE titulo IN(SELECT PeliculaTitulo FROM actua WHERE ActorNombre = '" + textBoxNombreActor.Text + "');";
            string respuesta = conex.selectQueryScalar(queryExiste);

            if (respuesta == "1")
            {
                //mostrar informacion del cliente y el boton para agregar saldo
                DataTable datos = conex.selectQuery(queryDatos);
                labelAnio.Text = datos.Rows[0]["Anio"].ToString();
                labelPrecio.Text = datos.Rows[0]["Precio"].ToString();
                labelTituloPelicula.Text = datos.Rows[0]["Titulo"].ToString();

                precio = Int32.Parse(datos.Rows[0]["Precio"].ToString());


                clickPelicula = true;
                if (clickPelicula == true && clickCliente == true)
                {
                    buttonArrendarPelicula.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No existe un actor con ese Nombre.");
            }

            conex.close();
        }
        private void buttonArrendarPelicula_Click(object sender, EventArgs e)
        {
            if (precio > saldo)
            {
                MessageBox.Show("El saldo no es suficiente");
            }
            else
            {
                

                ConexMySQL conex = new ConexMySQL();
                conex.open();

                //buscar descuento
                string descuento = "SELECT ClienteRUT FROM arriendo WHERE FechaArriendo >= date(sysdate()) - interval '20' day GROUP BY ClienteRut;";
                DataTable rutDescuento = new DataTable();
                float desc = 0f;
                rutDescuento = conex.selectQuery(descuento);

                bool descuentoBool = false;
                for (int i = 0; i < rutDescuento.Rows.Count; i++)
                {

                    if (rutCliente == rutDescuento.Rows[i]["ClienteRut"].ToString())
                    {
                        desc = 0.7f;
                        MessageBox.Show("DESCUENTO DISPONIBLE");
                        descuentoBool = true;


                    }
                }
                if (descuentoBool == false)
                {
                    desc = 1f;
                    //MessageBox.Show("ERROR DESCUENTO");
                }


                string insertar = "INSERT INTO arriendo VALUES('" + rutCliente + "', '" + labelTituloPelicula.Text + "', date(sysdate()));";
                int insercionExitosa2 = 0;
                insercionExitosa2 = conex.executeNonQuery(insertar);
                if (insercionExitosa2 == 1)
                {
                    string actualizarArriendo = "UPDATE cliente SET UltimoArriendo = date(sysdate()) WHERE RUT = '" + rutCliente + "';";
                    int insercionExitosa3 = 0;
                    insercionExitosa3 = conex.executeNonQuery(actualizarArriendo);
                    if (insercionExitosa3 == 1)
                    {
                        MessageBox.Show("Arriendo Exitoso");
                        float saldoRestanteFlotante = saldo - (precio * desc);
                        int saldoRestante = (int)saldoRestanteFlotante;

                        string actualizarSaldo = "UPDATE cliente SET Saldo = " + saldoRestante + " WHERE RUT = '" + rutCliente + "' AND activo = 'si';";
                        int insercionExitosa = 0;
                        insercionExitosa = conex.executeNonQuery(actualizarSaldo); //este metodo retorna un 1 si se inserto bien o 0 si no se pudo insertar
                        if (insercionExitosa == 1)
                        {



                        }
                        else
                        {
                            MessageBox.Show("NO SE PUDO DESCONTAR EL SALDO.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR2");
                    }
                }
                else
                {
                    MessageBox.Show("No puedes arrendar la misma pelicula 2 veces el mismo dia");
                }

                
                conex.close();

                


                
            }
        }

        

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void labelSaldo_Click(object sender, EventArgs e)
        {

        }

        private void labelAnio_Click(object sender, EventArgs e)
        {

        }

        private void labelPrecio_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreActor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
