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
    public partial class Eliminar_Usuario : Form
    {
        public Eliminar_Usuario()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Admin F = new Admin();
            F.Show();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
