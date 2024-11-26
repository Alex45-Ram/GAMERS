using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAMERS.Clases;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace GAMERS
{
    public partial class FormRecuperarContraseña : Form
    {
        public FormRecuperarContraseña()
        {
            InitializeComponent();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtCorreo.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico.");
                return;
            }

            string connectionString = "server=localhost;database=losputos;uid=root;pwd=root;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Personas WHERE email = @email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email); // Corregido el parámetro
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Correo encontrado. Se enviará un enlace para restablecer tu contraseña.");
                            EnviarCorreoRecuperacion(email);
                        }
                        else
                        {
                            MessageBox.Show("El correo ingresado no está registrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}");
            }
        }

        private void EnviarCorreoRecuperacion(string email)
        {
            try
            {
                // Crear la conexión y abrirla
                using (MySqlConnection connection = new MySqlConnection("server=localhost; database=losputos; Uid=root; pwd=root"))
                {
                    connection.Open();

                    // Obtener la contraseña desde la base de datos
                    string contraseña = ObtenerContraseñaDesdeBaseDatos(email, connection);

                    if (string.IsNullOrEmpty(contraseña))
                    {
                        MessageBox.Show("No se encontró una contraseña para este correo.");
                        return;
                    }

                    // Configurar el correo electrónico
                    MailMessage mensaje = new MailMessage
                    {
                        From = new MailAddress("jjbarocito@gmail.com"), // Cambia esto por tu correo
                        Subject = "Recuperación de contraseña",
                        Body = $"Tu contraseña es: {contraseña}",
                        IsBodyHtml = false
                    };

                    mensaje.To.Add(email);

                    // Configurar el cliente SMTP
                    using (SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com"))
                    {
                        clienteSmtp.Port = 587; // Puerto para Gmail
                        clienteSmtp.Credentials = new NetworkCredential("jjbarocito@gmail.com", "aynm dgvw picq cjnq"); // Reemplaza con tus credenciales
                        clienteSmtp.EnableSsl = true;

                        // Enviar el mensaje
                        clienteSmtp.Send(mensaje); // Corregido aquí
                    }

                    MessageBox.Show("La contraseña ha sido enviada a tu correo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }




        public string ObtenerContraseñaDesdeBaseDatos(string email, MySqlConnection connection)
        {
            string query = "SELECT contraseña FROM Personas WHERE email = @Email";

            try
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    // Ejecutar la consulta y obtener la contraseña
                    var result = command.ExecuteScalar();

                    // Si se encuentra un resultado, devolverlo como string, si no, devolver null
                    return result != null ? result.ToString() : null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar la consulta: {ex.Message}");
                return null;
            }
        }

    }

}  

        