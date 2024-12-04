using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public class Producto
        {
            public string Nombre { get; set; }
            public int Precio { get; set; }

            public Producto(string nombre, int precio)
            {
                Nombre = nombre;
                Precio = precio;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            menu nuevoForm = new menu();
            nuevoForm.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Play Station 4");
        }

        private void Play_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Bienvenida nF = new Bienvenida();
            nF.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            menu nF = new menu();
            nF.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Ticket carrito = new Ticket();
            carrito.Show();
            this.Close();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Ticket carrito = new Ticket();
            carrito.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("PlayStation 5");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("PlayStation VR");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("PlayStation Portatil");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Access Controller");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Sekiro");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Final Fantasy 7");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("It Takes Two");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Resident Evil 2");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Astrobot");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("The Witcher 3 Wild Hunt");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Crash Bandicoot 4");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Stray");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Persona 5 Royal");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Doom Eternal");
        }
    }



}

