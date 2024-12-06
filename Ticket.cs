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
    public partial class Ticket : Form
    {

        private List<Producto> productos = new List<Producto>();
        public Ticket()
        {
            InitializeComponent();
        }



        public void AgregarProducto(Producto producto)
        {
            if (!CarritoCompartido.Productos.Any(p => p.Nombre == producto.Nombre))
            {
                productos.Add(producto);
                CarritoCompartido.Productos.Add(producto);
            }
            ActualizarVista();

        }


        private void ActualizarVista()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;


            int total = productos.Sum(p => p.Precio);
            labeltotal.Text = $"Total: ${total}";
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            menu nF = new menu();
            nF.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tarjeta nF = new Tarjeta();
            nF.Show();
            this.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = productos.Sum(p => p.Precio); // Calcula el total a pagar
            Efectivo nF = new Efectivo(total);
            nF.Show();
            this.Hide();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Bienvenida nF = new Bienvenida();
            nF.Show();
            this.Hide();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            productos = CarritoCompartido.Productos.ToList();
            ActualizarVista();
        }
        public static class CarritoCompartido
        {
            public static List<Producto> Productos { get; set; } = new List<Producto>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }





}
