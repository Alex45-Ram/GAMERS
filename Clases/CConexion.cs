using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMERS.Clases
{
    class CConexion
    {
        public static MySqlConnection conex()
        {
            string servidor = "server=localhost; database=losputos; Uid=root; pwd=root"; // Asegúrate de que estos datos sean correctos
            MySqlConnection conexionbd = new MySqlConnection(servidor);

            try
            {
                conexionbd.Open(); // Intentamos abrir la conexión
                MessageBox.Show("Conexión exitosa con la base de datos.");
                return conexionbd;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + e.Message);
                return null;  // Si no se puede conectar, devolvemos null
            }
        }
    }


}

    

