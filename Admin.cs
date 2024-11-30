using GAMERS.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMERS
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uevo_Usuario nuevoForm = new uevo_Usuario();
            nuevoForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = CConexion.conex();
            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ("Select * From Personas;");
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla1 = new DataTable();
                adaptar.Fill(tabla1);
                dataGridView1.DataSource = tabla1;
            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
                conexionBD.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Validacion nF = new Validacion();
            nF.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Bienvenida F = new Bienvenida();
            F.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uevo_Usuario nuevoForm = new uevo_Usuario();
            nuevoForm.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Eliminar_Usuario F = new Eliminar_Usuario();
            F.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Eliminar_Usuario F = new Eliminar_Usuario();
            F.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Eliminar_Usuario F = new Eliminar_Usuario();
            F.Show();
            this.Hide();
            this.Close();
        }
    }
}
