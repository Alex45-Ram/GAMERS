using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GAMERS
{
    public partial class Test : Form
    {
        private string captchaText;

        public Test()
        {
            InitializeComponent();
            GenerateCaptcha();
        }
        private void GenerateCaptcha()
        {

            var random = new Random();
            captchaText = new string(
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray()
                .OrderBy(c => random.Next())
                .Take(6)
                .ToArray()
            );


            Bitmap bitmap = new Bitmap(200, 60);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                using (Font font = new Font("Arial", 24, FontStyle.Bold | FontStyle.Italic))
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(
                        new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                        Color.Blue, Color.Red, 1.2f, true))
                    {
                        g.DrawString(captchaText, font, brush, 10, 10);
                    }
                }


                Pen pen = new Pen(Color.Gray, 2);
                for (int i = 0; i < 5; i++)
                {
                    g.DrawLine(pen, random.Next(bitmap.Width), random.Next(bitmap.Height),
                               random.Next(bitmap.Width), random.Next(bitmap.Height));
                }
            }


            pictureBoxCaptcha.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxCaptcha.Text.Equals(captchaText, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("¡Datos validados correctamente!");

                Admin nuevoForm = new Admin();
                nuevoForm.Show();
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: El texto no coincide. Inténtalo de nuevo.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Bienvenida nF = new Bienvenida();
            nF.Show();
            this.Hide();
            this.Close();
        }
    }
}
