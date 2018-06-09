using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MemoryGame {
    class Controlador {

        public static int agregar(Usuario u) {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into usuarios (username, puntuacion) values ('{0}','{1}')",
                u.username, u.puntuacion), BD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
