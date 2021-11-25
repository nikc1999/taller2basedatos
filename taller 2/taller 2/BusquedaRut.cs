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
    public partial class BusquedaRut : Form
    {
        string rutCliente = "";
        int saldo = 0;
        public BusquedaRut()
        {
            InitializeComponent();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryExiste = "SELECT COUNT(Nombre) FROM cliente WHERE RUT = '" + textBoxRut.Text + "' AND activo = 'si';";   //retorna 0 si no existe ese rut 
            string queryDatos = "SELECT Nombre, Email, Saldo, RUT FROM cliente WHERE RUT = '" + textBoxRut.Text + "';";
            
            string respuesta = conex.selectQueryScalar(queryExiste);

            if (respuesta == "1")
            {
                //mostrar informacion del cliente y el boton para agregar saldo
                DataTable datos = conex.selectQuery(queryDatos);
                labelNombre.Text = datos.Rows[0]["Nombre"].ToString();
                labelEmail.Text = datos.Rows[0]["Email"].ToString();
                
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

                //calcular cantidad de peliculas en los ultimos 3 meses
                string queryCantidad = "SELECT COUNT(PeliculaTitulo) FROM  arriendo WHERE ClienteRut = '" + textBoxRut.Text + "' AND FechaArriendo >= date(sysdate()) - interval '3' month; ";
                string respuestaCantidad = conex.selectQueryScalar(queryCantidad);
                //NO SE HACE IF YA QUE SIEMPRE RETORNARA UN NUMERO POR EL COUNT
                //MessageBox.Show("el usuario a pedido" + respuestaCantidad);
                labelCantPeliculas3meses.Text = respuestaCantidad;
                
            }
            else
            {
                MessageBox.Show("No existe un cliente con ese Rut.");
            }

            conex.close();
        }
    }
}
