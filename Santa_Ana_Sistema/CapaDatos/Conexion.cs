
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public static MySqlConnection conexion()

        {
            string servidor = "localhost";
            string bd = "db_sistema_ventas";
            string puerto = "3306";
            string usuario = "root";
            string password = "admin";

            String cadenaConexion = "Database =" + bd + "; Data Source =" + servidor + "; Port = " + puerto + "; User id =" + usuario + "; Password =" + password;

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
          

}
}
