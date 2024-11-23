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
            string servidor = "server=localhost; database = losputos; Uid=root; pwd=root";

            MySqlConnection conexionbd = new MySqlConnection(servidor);

            try
            {
                return conexionbd;
                MessageBox.Show("Se logro conectar a la base de datos");
            }

            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos:" + e.ToString());
                return null;
            }

        }

    
    }
}
    

