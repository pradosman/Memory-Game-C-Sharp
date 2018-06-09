using System.Windows.Forms;

namespace MemoryGame {
    public partial class Form2 : Form {
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button1;
        private byte timeLeft;
        bool colorblind;

        public Form2(bool colorblind) {
            this.colorblind = colorblind;
            InitializeComponent();
        }
             

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fácil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Difícil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Muy Difícil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona una dificultad";
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Found Pairs";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form2_Load(object sender, System.EventArgs e) {
            
        }

        private void button1_Click(object sender, System.EventArgs e) {
            this.timeLeft = 60;
            Form5 form = new Form5(timeLeft,colorblind);
            form.ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e) {
            this.timeLeft = 40;
            Form4 form = new Form4(timeLeft, colorblind);
            form.ShowDialog();
        }

        private void button3_Click(object sender, System.EventArgs e) {
            this.timeLeft = 30;
            Form1 form = new Form1(timeLeft, colorblind);
            form.ShowDialog();
        }
    }
}
