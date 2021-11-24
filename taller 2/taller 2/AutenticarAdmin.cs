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
    public partial class AutenticarAdmin : Form
    {
        public AutenticarAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT contra FROM contrasena;";
            if (conex.selectQueryScalar(query) == textBox1.Text)
            {
                MessageBox.Show("contrasena correcta");
                Admin admin = new Admin();
                admin.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AutenticarAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
