using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GAMERS
{
    internal class GestorProductos
    {

            private static Ticket carrito = null;

            private static void AbrirCarrito()
            {
                if (carrito == null || carrito.IsDisposed)
                {
                    carrito = new Ticket();
                }
                carrito.Show();
                carrito.BringToFront();
            }

            public static int ObtenerPrecioDesdeBaseDeDatos(string nombreProducto)
            {
                int precio = 0;
                string cadenaConexion = "server=localhost; database=productos; Uid=root; pwd=MayaCity_23";

                using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT Precio FROM videojuegos_consolas WHERE Nombre = @nombre";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nombre", nombreProducto);
                            object resultado = cmd.ExecuteScalar();
                            if (resultado != null)
                            {
                                precio = Convert.ToInt32(resultado);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el precio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return precio;
            }

            public static void AgregarProducto(string nombreProducto)
            {
                try
                {
                    int precio = ObtenerPrecioDesdeBaseDeDatos(nombreProducto);
                 Producto producto = new Producto(nombreProducto, precio);

                    AbrirCarrito();
                    carrito.AgregarProducto(producto);

                    MessageBox.Show($"Producto agregado al carrito:\nNombre: {nombreProducto}\nPrecio: {precio}", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
