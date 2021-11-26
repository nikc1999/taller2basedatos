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
    public partial class ListadoClientesPorArriendos : Form
    {
        public ListadoClientesPorArriendos()
        {
            InitializeComponent();
        }

        private void ListadoClientesPorArriendos_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            //---------------------------------------
            // REQUISITO 16
            //---------------------------------------
            string queryExiste = "SELECT COUNT(*) FROM cliente;";   //retorna 0 si no existe ese rut 
            string queryDatos = "SELECT cliente.Nombre, cliente.RUT, COUNT(*) FROM cliente JOIN arriendo ON cliente.RUT = arriendo.ClienteRUT WHERE arriendo.FechaArriendo >= date(sysdate()) - interval '2' month GROUP BY cliente.Nombre ORDER BY 3 desc;";

            string respuesta = conex.selectQueryScalar(queryExiste);

            if (respuesta != "0")
            {
                
                DataTable datos = conex.selectQuery(queryDatos);
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    listBoxClientes.Items.Add(datos.Rows[i]["Nombre"].ToString() + " : "+ datos.Rows[i][2].ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay clientes en el sistema.");
            }

            conex.close();
        }
    }
}
