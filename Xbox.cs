using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GAMERS
{
    public partial class Xbox : Form
    {
        public Xbox()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        } 
       

        
        private Ticket carrito = null;

        
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Xbox_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Bienvenida nF = new Bienvenida();
            nF.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Ticket carrito = new Ticket();
            carrito.Show();
            this.Close();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            GestorProductos.AgregarProducto("Xbox Series X");

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Dragon Ball Sparking Zero");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Xbox Series S");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Xbox Game Pass Ultimate");
        }

        private void pictureBox6_Click_2(object sender, EventArgs e)
        {
            Ticket carrito = new Ticket();
            carrito.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Xbox Game Pass Core");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GestorProductos.AgregarProducto("Xbox Tarjeta de Regalo");

        }

       
        private void pictureBox20_Click(object sender, EventArgs e)
        {
          
            GestorProductos.AgregarProducto("Death Stranding");
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            
            GestorProductos.AgregarProducto("Halo the Master Chief Collection");
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
           
            GestorProductos.AgregarProducto("Black Ops 6");
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
        
            GestorProductos.AgregarProducto("GTA V");
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
           
            GestorProductos.AgregarProducto("Red Dead Redempiton 2");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            
            GestorProductos.AgregarProducto("2K25");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
          
            GestorProductos.AgregarProducto("Resident Evil 4");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
           
            GestorProductos.AgregarProducto("Hellblade");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            
            GestorProductos.AgregarProducto("Alan Wake 2");
        }
    }




}
