using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMERS
{
    public partial class Tarjeta : Form
    {
        public Tarjeta()
        {
            InitializeComponent();
        }

        private void Tarjeta_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ticket nF = new Ticket();
            nF.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Bienvenida nF = new Bienvenida();
            nF.Show();
            this.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroTarjeta = textBoxNumeroTarjeta.Text; 
            string titular = textBoxTitular.Text; 
            string fechaVencimiento = textBoxFechaVencimiento.Text; 
            string cvv = textBoxCVV.Text; 
            int total = Ticket.CarritoCompartido.Productos.Sum(p => p.Precio); 

            if (string.IsNullOrEmpty(numeroTarjeta) ||
                string.IsNullOrEmpty(titular) ||
                string.IsNullOrEmpty(fechaVencimiento) ||
                string.IsNullOrEmpty(cvv))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarNumeroTarjeta(numeroTarjeta))
            {
                MessageBox.Show("El número de tarjeta no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string rutaArchivo = @"C:\Tickets\pago_ticket.txt"; 
                Directory.CreateDirectory(@"C:\Tickets"); 

                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    writer.WriteLine("===== RECIBO DE PAGO =====");
                    writer.WriteLine($"Fecha: {DateTime.Now}");
                    writer.WriteLine($"Nombre del Titular: {titular}");
                    writer.WriteLine($"Número de Tarjeta: {EnmascararTarjeta(numeroTarjeta)}");
                    writer.WriteLine($"Fecha de Vencimiento: {fechaVencimiento}");
                    writer.WriteLine($"Monto Total: ${total}");
                    writer.WriteLine("==========================");
                }

                MessageBox.Show($"Pago realizado con éxito. Recibo generado en: {rutaArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                Ticket.CarritoCompartido.Productos.Clear();

                menu menu = new menu();
                menu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el recibo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string EnmascararTarjeta(string numeroTarjeta)
        {
            if (numeroTarjeta.Length < 4)
                return numeroTarjeta;

            return new string('*', numeroTarjeta.Length - 4) + numeroTarjeta.Substring(numeroTarjeta.Length - 4);
        }

        private bool ValidarNumeroTarjeta(string numeroTarjeta)
        {
            if (string.IsNullOrEmpty(numeroTarjeta))
                return false;

            int suma = 0;
            bool alternar = false;

            for (int i = numeroTarjeta.Length - 1; i >= 0; i--)
            {
                char digitoChar = numeroTarjeta[i];
                if (!char.IsDigit(digitoChar)) 
                    return false;

                int digito = digitoChar - '0';

                if (alternar)
                {
                    digito *= 2;
                    if (digito > 9)
                        digito -= 9; 
                }

                suma += digito;
                alternar = !alternar;
            }

            
            return (suma % 10) == 0;
        }

    }

}
