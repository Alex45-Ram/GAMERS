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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Play nuevoForm = new Play();
            nuevoForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xbox nuevoForm = new Xbox();
            nuevoForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nintendo nuevoForm = new Nintendo();
            nuevoForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Accesorios nuevoForm = new Accesorios();
            nuevoForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accesorios nuevoForm = new Accesorios();
            nuevoForm.Show();
            this.Hide();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Segoe UI", 64, FontStyle.Bold); // Ajusta el tamaño de la fuente
            Brush brush = new SolidBrush(Color.Black); // Cambia el color según sea necesario

            // Dibuja el texto directamente sobre el PictureBox
            e.Graphics.DrawString("Consolas", font, brush, new PointF(570, -5));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Validacion nF = new Validacion();
            nF.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
