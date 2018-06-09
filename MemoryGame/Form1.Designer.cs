namespace MemoryGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.time = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.remaining = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.time.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(591, 146);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(218, 25);
            this.time.TabIndex = 2;
            this.time.Text = "Tiempo Restante:";
            this.toolTip1.SetToolTip(this.time, "Tiempo restante \r\npara perder la partida");
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(596, 251);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(99, 23);
            this.newGameButton.TabIndex = 4;
            this.newGameButton.Text = "Nuevo Juego";
            this.toolTip1.SetToolTip(this.newGameButton, "Pulsa aquí \r\npara empezar el juego de nuevo\r\ncon la misma dificultad");
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // remaining
            // 
            this.remaining.AutoSize = true;
            this.remaining.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.remaining.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaining.Location = new System.Drawing.Point(591, 49);
            this.remaining.Name = "remaining";
            this.remaining.Size = new System.Drawing.Size(249, 25);
            this.remaining.TabIndex = 1;
            this.remaining.Text = "Parejas Disponibles:";
            this.toolTip1.SetToolTip(this.remaining, "Parejas disponibles \r\nque tienes que encontrar");
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox16.Location = new System.Drawing.Point(414, 414);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(128, 128);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 0;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox16, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox16.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox12.Location = new System.Drawing.Point(414, 280);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(128, 128);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox12, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox8.Location = new System.Drawing.Point(414, 146);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(128, 128);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox8, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Location = new System.Drawing.Point(414, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox4, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox15.Location = new System.Drawing.Point(280, 414);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(128, 128);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox15, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox11.Location = new System.Drawing.Point(280, 280);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(128, 128);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox11, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox7.Location = new System.Drawing.Point(280, 146);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(128, 128);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox7, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Location = new System.Drawing.Point(280, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox3, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox14.Location = new System.Drawing.Point(146, 414);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(128, 128);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox14, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox10.Location = new System.Drawing.Point(146, 280);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(128, 128);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox10, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox6.Location = new System.Drawing.Point(146, 146);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(128, 128);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox6, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(146, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox2, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox13.Location = new System.Drawing.Point(12, 414);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(128, 128);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox13, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox9.Location = new System.Drawing.Point(12, 280);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(128, 128);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox9, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox5.Location = new System.Drawing.Point(12, 146);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 128);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox5, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "0";
            this.toolTip1.SetToolTip(this.pictureBox1, "Pulsa aqui para ver la imagen escondida");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(916, 566);
            this.Controls.Add(this.remaining);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.time);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Found Pairs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label remaining;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

