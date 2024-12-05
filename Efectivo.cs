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
    public partial class Efectivo : Form
    {
        private int total;
        public Efectivo(int total)
        {
            InitializeComponent();
            this.total = total;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ticket nF = new Ticket();
            nF.Show();
            this.Hide();
        }

        private void Efectivo_Load(object sender, EventArgs e)
        {
            labelTotal.Text = $"Cambio: ${total}";
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEfectivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (decimal.TryParse(textBoxEfectivo.Text, out decimal cantidadPagada))
                {
                   
                    decimal total = Ticket.CarritoCompartido.Productos.Sum(p => p.Precio);

                    
                    if (cantidadPagada >= total)
                    {
                        
                        decimal cambio = cantidadPagada - total;

                        
                        labelCambio.Text = $"Cambio: ${cambio:F2}";

                        
                        string rutaArchivo = @"C:\Tickets\pago_ticket_efectivo.txt"; 
                        using (StreamWriter sw = new StreamWriter(rutaArchivo))
                        {
                            sw.WriteLine("Ticket de Compra:");
                            sw.WriteLine("-----------------");
                            foreach (var producto in Ticket.CarritoCompartido.Productos)
                            {
                                sw.WriteLine($"Producto: {producto.Nombre}, Precio: ${producto.Precio}");
                            }
                            sw.WriteLine("-----------------");
                            sw.WriteLine($"Total: ${total}");
                            sw.WriteLine($"Pagado: ${cantidadPagada}");
                            sw.WriteLine($"Cambio: ${cambio}");
                        }

                        MessageBox.Show("Pago realizado exitosamente. Ticket generado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        Ticket.CarritoCompartido.Productos.Clear();

                        
                        menu menu = new menu();
                        menu.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad ingresada es insuficiente para cubrir el total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

