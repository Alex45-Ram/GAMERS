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
    public partial class Accesorios : Form
    {
        public Accesorios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu nuevoForm = new menu();
            nuevoForm.Show();
            this.Hide();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Accesorios_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Mouse Razer");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            menu nF = new menu();
            nF.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Bienvenida nF = new Bienvenida();
            nF.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Teclado Mecanico");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Ticket carrito = new Ticket();
            carrito.Show();
            this.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Ticket carrito = new Ticket();
            carrito.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Mouse Logitech");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Mouse HyperX");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Audifonos HyperX");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Audifonos Sony");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Mouse Pad");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Volante y Pedales");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Gafas VR");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Stream Deck");
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Memoria RAM 16gb");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Parlamtes Genius");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Webcam Zilink");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("GeoForce RTX ");
        }
    }
}
