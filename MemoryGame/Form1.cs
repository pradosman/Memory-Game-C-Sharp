﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame {
    public partial class Form1 : Form {
        PictureBox prev;
        int flag = 0;
        int remain = 8;
        private byte timeResponse;
        private byte timeLeft;
        bool colorblind;
        int puntuacion = 0;
        
        public Form1() {
            InitializeComponent();
        }

        public Form1(byte time, bool colorblind) {
            this.colorblind = colorblind;
            this.timeResponse = time;
            InitializeComponent();
        }

        public int getTime() {
            return this.timeResponse;
        }


        private void Form1_Load(object sender, EventArgs e) {
            newgame();

        }

        void resetImages() {
            if (colorblind == true) {
                foreach (Control x in this.Controls)
                    if (x is PictureBox)
                        (x as PictureBox).Image = Properties.Resources.question_mark;
            }
            else {
                foreach (Control x in this.Controls)
                    if (x is PictureBox)
                        (x as PictureBox).Image = Properties.Resources._0;
            }
        }

        void resetTags() {
            foreach (Control x in this.Controls)
                if (x is PictureBox)
                    (x as PictureBox).Tag = "0";
        }

        void showImage(PictureBox box) {

            if (colorblind == true) {
                switch (Convert.ToInt32(box.Tag)) {
                    case 1:
                        box.Image = Properties.Resources.colorblindmode1;
                        break;
                    case 2:
                        box.Image = Properties.Resources.colorblindmode2;
                        break;
                    case 3:
                        box.Image = Properties.Resources.colorblindmode3;
                        break;
                    case 4:
                        box.Image = Properties.Resources.colorblindmode4;
                        break;
                    case 5:
                        box.Image = Properties.Resources.colorblindmode5;
                        break;
                    case 6:
                        box.Image = Properties.Resources.colorblindmode6;
                        break;
                    case 7:
                        box.Image = Properties.Resources.colorblindmode7;
                        break;
                    case 8:
                        box.Image = Properties.Resources.colorblindmode8;
                        break;
                    default:
                        box.Image = Properties.Resources.question_mark;
                        break;
                }
            }
            else {
                switch (Convert.ToInt32(box.Tag)) {
                    case 1:
                        box.Image = Properties.Resources._1;
                        break;
                    case 2:
                        box.Image = Properties.Resources._2;
                        break;
                    case 3:
                        box.Image = Properties.Resources._3;
                        break;
                    case 4:
                        box.Image = Properties.Resources._4;
                        break;
                    case 5:
                        box.Image = Properties.Resources._5;
                        break;
                    case 6:
                        box.Image = Properties.Resources._6;
                        break;
                    case 7:
                        box.Image = Properties.Resources._7;
                        break;
                    case 8:
                        box.Image = Properties.Resources._8;
                        break;
                    default:
                        box.Image = Properties.Resources._0;
                        break;
                }
            }

        }


        void setTagRandom() {
            int[] arr = new int[16];
            int index = 0;
            Random rand = new Random();
            int r;
            while (index < 16) {
                r = rand.Next(1, 17);
                if (Array.IndexOf(arr, r) == -1) {
                    arr[index] = r;
                    index++;
                }
            }
            for (index = 0; index < 16; index++) {
                if (arr[index] > 8) arr[index] -= 8;
            }
            index = 0;
            foreach (Control x in this.Controls) {
                if (x is PictureBox) {
                    (x as PictureBox).Tag = arr[index].ToString();
                    index++;
                }
            }
            
        }
        void compare(PictureBox previous, PictureBox current) {
            if (previous.Tag.ToString() == current.Tag.ToString()) {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                previous.Visible = false;
                current.Visible = false;
                puntuacion = puntuacion + 10;
                if (--remain == 0) {
                    timer1.Enabled = false;
                    MessageBox.Show("HAS COMPLETADO EL JUEGO", "FIN DE LA PARTIDA");
                    Form8 form = new Form8(puntuacion+remain);
                    form.ShowDialog();

                }
                else remaining.Text = "Parejas Disponibles: " + remain;
            }
            else {
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
                if (colorblind == true) {
                    previous.Image = Properties.Resources.question_mark;
                    current.Image = Properties.Resources.question_mark;
                }
                else {
                    previous.Image = Properties.Resources._0;
                    current.Image = Properties.Resources._0;
                }
            }
        }

        void allvisibleTrue() {
            foreach (Control x in this.Controls)
                if (x is PictureBox)
                    (x as PictureBox).Visible = true;
        }
        void activeAll() {
            foreach (Control x in this.Controls)
                if (x is PictureBox)
                    (x as PictureBox).Enabled = true;
        }
        void deActiveAll() {
            foreach (Control x in this.Controls)
                if (x is PictureBox)
                    (x as PictureBox).Enabled = false;
        }
        void newgame() {
            remain = 8;

            setTagRandom();
            allvisibleTrue();
            resetImages();

            remaining.Text = "Parejas Disponibles: " + remain;

            flag = 0;
            timeLeft = timeResponse;
            time.Text = "Tiempo Restante: " + timeLeft;
            timer1.Enabled = true;
            activeAll();

        }
        private void pictureBox1_Click(object sender, EventArgs e) {
            PictureBox current = (sender as PictureBox);
            showImage((sender as PictureBox));
            if (flag == 0) {
                prev = current;
                flag = 1;
            }
            else if (prev != current) {
                compare(prev, current);
                flag = 0;
            }

        }



        private void timer1_Tick(object sender, EventArgs e) {

            if (--timeLeft == 0) {
                timer1.Enabled = !timer1.Enabled;
                time.Text = "Se acabó el tiempo";
                MessageBox.Show("TIEMPO ACABADO", "FIN DE LA PARTIDA");
                deActiveAll();


            }
            else
                time.Text = "Tiempo Restante: " + timeLeft;

        }

        private void newGameButton_Click(object sender, EventArgs e) {
            newgame();
        }

       
    }
}
