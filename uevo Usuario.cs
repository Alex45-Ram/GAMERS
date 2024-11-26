using MySql.Data.MySqlClient;
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
    public partial class uevo_Usuario : Form
    {
        public uevo_Usuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            string nombre = textBox1.Text;
            string apellido = textBox3.Text;
            DateTime fechaNacimiento = dateTimePicker1.Value;
            string genero = comboBox1.SelectedItem?.ToString(); // Asegurarse de que se haya seleccionado algo
            string email = textBox4.Text;
            string telefono = textBox5.Text;
            string contraseña = textBox2.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(genero) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            try
            {
                // Crear la conexión a la base de datos
                using (MySqlConnection connection = new MySqlConnection("server=localhost; database=losputos; Uid=root; pwd=root"))
                {
                    connection.Open();

                    // Comando SQL para insertar datos
                    string query = "INSERT INTO Personas (nombre,contraseña, apellido, fecha_Nacimiento, genero, email, telefono) VALUES (@nombre,@contraseña, @apellido, @fecha_Nacimiento, @genero, @email, @telefono)";

                    // Crear el objeto MySqlCommand
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@fecha_Nacimiento", fechaNacimiento);
                        cmd.Parameters.AddWithValue("@Genero", genero);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);
                        cmd.Parameters.AddWithValue("@contraseña", telefono);

                        // Ejecutar el comando
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // Verificar si se insertaron datos
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario agregado correctamente.");
                            LimpiarCampos(); // Limpiar todos los campos
                        }
                        else
                        {
                            MessageBox.Show("Hubo un problema al agregar el usuario.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Método para limpiar los campos
        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1; // Limpiar el ComboBox
            textBox4.Clear();
            textBox5.Clear();
        }


private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}






