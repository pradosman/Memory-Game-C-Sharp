using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace MemoryGame {
    public partial class Form9 : Form {
        public Form9() {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e) {

            string query = "SELECT * FROM usuarios";

            MySqlDataAdapter da = new MySqlDataAdapter(query, BD.ObtenerConexion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e) {
            Form6 form = new Form6();
            form.ShowDialog();
        }
    }
}
