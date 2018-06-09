using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MemoryGame {
    public class BD {
        public static MySqlConnection ObtenerConexion() {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=ejemplodi; Uid=root; pwd=josegras;");

            conectar.Open();
            return conectar;
        }
    }
}
