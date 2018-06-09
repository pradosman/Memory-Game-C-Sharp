using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame {
    public partial class Form8 : Form {

        int puntuacion;

        public Form8() {
            InitializeComponent();
        }

        public Form8(int puntuacion) {
            this.puntuacion = puntuacion;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Usuario u = new Usuario();
            u.username = textBox1.Text.Trim();
            u.puntuacion = puntuacion;

            int resultado = Controlador.agregar(u);
            if (resultado == 0) {
                MessageBox.Show("Usuario guardado con exito");
            }
            else {
                MessageBox.Show("Usuario guardado con exito");
            }
            Form9 form = new Form9();
            form.ShowDialog();
        }
    }
}
