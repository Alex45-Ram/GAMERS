using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GAMERS
{
    public partial class Validacion : Form
    {
        public Validacion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int emp = comboBox1.SelectedIndex;

            string contrase�aValida = "caje1";
            string Contrase�ajefe = "jefazo";



            string contrase�aIngresada = Pass.Text;
            string contrase�aBoss = Pass.Text;


            if (comboBox1.SelectedIndex == 0 && Pass.Text == contrase�aValida)
            {

                menu nuevoForm = new menu();
                nuevoForm.Show();
                this.Hide();
            }
            else

            {
                MessageBox.Show("Usuario o contrase�a incorrectos", "Error de autenticaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (comboBox1.SelectedIndex == 1 && Pass.Text == contrase�aBoss)
            {
                Admin nuevoForm = new Admin();
                nuevoForm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos", "Error de autenticaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Validacion_Load(object sender, EventArgs e)
        {

        }

        private void Usser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


