using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barcos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x1 = 192;
        int x2 = 615;
        int score1 = 0;
        int score2 = 0;
        bool f = true;
        bool g = true;
        int c = 0;
        double vel, ang, t, y1, x3;
        double vel1, ang1, t1, y2, x4;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            t1 = t1 + 0.1;
            x4 = vel1 * Math.Cos(ang1) * t1;
            y2 = vel1 * Math.Sin(ang1) * t1 - (0.5 * 9.8 * t1 * t1);
            pictureBox5.Location = new Point(641 - (int)x4, 433 - (int)y2);

            if (pictureBox5.Location.Y >=434)
            {
                if (pictureBox5.Location.X > pictureBox2.Location.X && pictureBox5.Location.X < pictureBox2.Location.X + 54)
                {
                    score1 = score1 + 1;
                    label10.Text = "SCORE: " + score1;
                }
                timer3.Enabled = false; pictureBox5.Location = new Point(641, 433);           
            }
            if(pictureBox5.Location.X < 192 || pictureBox5.Location.Y < 69) { timer3.Enabled = false; pictureBox5.Location = new Point(641, 433);}
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            x1 = 192;
            x2 = 615;
            score1 = 0;
            score2 = 0;
            f = true;
            g = true;
            label11.Text = "";
            pictureBox2.Location = new Point(x1, 433);
            pictureBox3.Location = new Point(x2, 433);
            button4.Visible = false;
            label9.Text = "SCORE: ";
            label10.Text = "SCORE: ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            c = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = "Nivel: " + hScrollBar1.Value.ToString();
            label8.Text = "Nivel: " + hScrollBar2.Value.ToString();
            int a = 3*Convert.ToInt32(hScrollBar1.Value.ToString());
            int b = 3*Convert.ToInt32(hScrollBar2.Value.ToString());
            pictureBox2.Location = new Point(x1, 433);
            pictureBox3.Location = new Point(x2, 433);
            if (f == false)
            {
                x1 = x1 - a;
                if (x1 <= 192) { x1 = 192; f = true; }
            }
            else if (f == true)
            {
                x1 = x1 + a;
                if (x1 >= 615) { x1 = 615; f = false; }
            }
            if (g == false)
            {
                x2 = x2 + b;
                if (x2 >= 615) { x2 = 615; g = true; }
            }
            else if (g == true)
            {
                x2 = x2 - b;
                if (x2 <= 192) { x2 = 192; g = false; }
            }
            if (score1 == 2)
            {
                c = 0;
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                label11.Text = "Ganador: " + 2;
                button4.Visible = true;
            }
            if (score2 == 2)
            {
                c = 0;
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                label11.Text = "Ganador: " + 1;
                button4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) //button1 timer2
        {
            t = 0; vel = 0; ang = 0; 
            vel = Convert.ToDouble(textBox1.Text);
            ang = Convert.ToDouble(textBox2.Text);
            ang = ang * Math.PI / 180;
            timer2.Interval = 10;
            if(c==1) timer2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e) //button2 timer3
        {
            t1 = 0; vel1 = 0; ang1 = 0;
            vel1 = Convert.ToDouble(textBox3.Text);
            ang1 = Convert.ToDouble(textBox4.Text);
            ang1 = ang1 * Math.PI / 180;
            timer3.Interval = 10;
            if(c==1) timer3.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t = t + 0.1;
            x3 = vel * Math.Cos(ang) * t;
            y1 = vel * Math.Sin(ang) * t - (0.5 * 9.8 * t * t);
            pictureBox4.Location = new Point(192+(int)x3, 433 - (int)y1);

            if (pictureBox4.Location.Y >= 434)
            {
                if (pictureBox4.Location.X > pictureBox3.Location.X && pictureBox4.Location.X < pictureBox3.Location.X + 54)
                {
                    score2 = score2 + 1;
                    label9.Text = "SCORE: " + score2;
                }
                timer2.Enabled = false; pictureBox4.Location = new Point(192, 433);
            }
            if (pictureBox4.Location.X > 192+478-29 || pictureBox4.Location.Y < 69) { timer2.Enabled = false; pictureBox4.Location = new Point(192, 433); }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }
    }
}
