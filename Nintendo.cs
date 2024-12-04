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
    public partial class Nintendo : Form
    {
        public Nintendo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu nuevoForm = new menu();
            nuevoForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Nintendo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Bienvenida nF = new Bienvenida();
            nF.Show();
            this.Close();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            menu nF = new menu();
            nF.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Ticket carrito = new Ticket();
            carrito.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Nintendo Switch");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Nintendo Lite");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Nintendo Switch Oled");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Joysticks Nintendo");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Accesorios");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Mario and Luigi Brothership");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Mario Party");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Luigi Mansion 2");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Mario vs Donkey Kong");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Metroid Prime");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Splantoon 3");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Pokemon Scarlet");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Kirby 20th Anniversary");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Nintendo Sports");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Bayoneta 3");
        }
    }
}
