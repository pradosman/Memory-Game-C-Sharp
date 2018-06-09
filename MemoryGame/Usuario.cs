using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame {
    class Usuario {
        public String username;
        public int puntuacion;

        public Usuario() { }

        public Usuario(String username, int puntuacion) {
            this.username = username;
            this.puntuacion = puntuacion;
        }
    }
}
