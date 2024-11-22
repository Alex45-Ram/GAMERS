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
                    // Generar un token para el enlace de restablecimiento
                    string token = GenerarToken(email);
                string enlace = "http://localhost:5000/restablecer?token=" + token;


                // Configurar el correo electrónico
                MailMessage mensaje = new MailMessage
                    {
                        From = new MailAddress("tuCorreo@dominio.com"), // Cambia esto por tu correo
                        Subject = "Recuperación de contraseña",
                        Body = $"Haz clic en el siguiente enlace para restablecer tu contraseña: <a href='{enlace}'>Restablecer Contraseña</a>",
                        IsBodyHtml = true
                    };

                    mensaje.To.Add(email);

                    // Configurar el cliente SMTP
                    using (SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com")) // Usa SMTP de Gmail
                    {
                        clienteSmtp.Port = 587; // Puerto para Gmail
                        clienteSmtp.Credentials = new NetworkCredential("jjbarocito@gmail.com", "aynm dgvw picq cjnq"); // Reemplaza con tus credenciales
                        clienteSmtp.EnableSsl = true;

                        // Enviar el mensaje
                        clienteSmtp.Send(mensaje);
                    }

                    MessageBox.Show("Correo enviado con éxito. Por favor, revisa tu bandeja de entrada.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al enviar el correo: {ex.Message}");
                }
            }

            private string GenerarToken(string email)
            {
                // Generar un token único
                return Convert.ToBase64String(Guid.NewGuid().ToByteArray())
                    .Replace("=", "")
                    .Replace("+", "")
                    .Replace("/", "");
            }


        }
    }
