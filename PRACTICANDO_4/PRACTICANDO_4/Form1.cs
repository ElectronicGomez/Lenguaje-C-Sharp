using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICANDO_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g1, g2;
        int angulo = 0;
        Bitmap bmp1, bmp2;
        private void button1_Click(object sender, EventArgs e)
        {
            g1 = pictureBox1.CreateGraphics();
            g1.Clear(Color.Green);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Black, 3);
            g1.DrawLine(p, 0, 0, 100, 100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Point[] pntos = new Point[3];
            pntos[0] = new Point(50, 0);
            pntos[1] = new Point(50, 150);
            pntos[2] = new Point(150, 150);
            Pen p = new Pen(Color.White, 4);
            g1.DrawLines(p, pntos);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Purple);
            p.Width = 4;
            Point p1 = new Point(0, 0);
            Point p2 = new Point(150, 150);
            g1.DrawLine(p, p1, p2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Point[] pts = new Point[3];
            pts[0] = new Point(50, 0);
            pts[1] = new Point(50, 150);
            pts[2] = new Point(150, 150);

            Pen pe1 = new Pen(Color.Red, 4);
            g1.DrawPolygon(pe1, pts);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Point[] pto = new Point[3];
            pto[0] = new Point(50, 0);
            pto[1] = new Point(50, 150);
            pto[2] = new Point(150, 150);
            Pen p = new Pen(Color.Red, 3);
            g1.DrawPolygon(p, pto);
            g1.FillPolygon(Brushes.Blue, pto);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle(20, 20, 100, 100);
            g1.DrawEllipse(new Pen(Color.Red, 5), rec);
            g1.FillEllipse(Brushes.Blue, rec);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Rectangle rec1 = new Rectangle(30, 30, 120, 120);
            g1.DrawRectangle(new Pen(Color.Blue), rec1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Red, 3);
            g1.DrawRectangle(p, 20, 20, 100, 100);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Black, 4);
            g1.DrawRectangle(p, 20, 20, 100, 100);
            g1.FillRectangle(Brushes.Yellow, 20, 20, 100, 100);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle(20, 20, 100, 100);
            g1.DrawArc(new Pen(Color.Blue, 4), rec, 270, 90);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rectangle rec = new Rectangle(20, 20, 100, 100);
            g1.DrawEllipse(new Pen(Color.Red, 5), rec);
            g1.DrawArc(new Pen(Color.White, 5), rec, angulo, 20);
            angulo = angulo + 1;
            if (angulo == 360)
            {
                timer1.Enabled = false;
                angulo = 0;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {

            timer1.Interval = 2;
            timer1.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bmp1 = new Bitmap(50, 50);
            g1 = Graphics.FromImage(bmp1);
            g1.Clear(Color.Red);
            for (int i = 0; i < 50; i++)
            {
                bmp1.SetPixel(i, 25, Color.Black);
            }

            g2 = pictureBox1.CreateGraphics();
            g2.DrawImage(bmp1, 0, 0);
            g2.DrawImage(bmp1, 0, 70);
            g2.DrawImage(bmp1, 0, 140);



        }

        private void button16_Click(object sender, EventArgs e)
        {

            Color c1 = bmp1.GetPixel(15, 15);
            MessageBox.Show(c1.ToString());
            int a = c1.A;
            int r = c1.R;
            int g = c1.G;
            int b = c1.B;
            MessageBox.Show(a + "/" + r + "/" + g + "/" + b);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            bmp1 = new Bitmap(100, 100);
            for(int i =0;i<100;i++)
            {
                bmp1.SetPixel(i,50,Color.Black);
            }
            pictureBox1.Image = bmp1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bmp1 = new Bitmap(100, 100);
            bmp2 = new Bitmap(100, 120);
            for(int i=0;i<100;i++)
            {
                bmp1.SetPixel(i, 20, Color.Red);
                bmp2.SetPixel(0, i+20, Color.Red);

            }
            g2 = pictureBox1.CreateGraphics();
            g2.DrawImage(bmp1, 0, 0);
            g2.DrawImage(bmp1, 0, 100);
            g2.DrawImage(bmp2, 0,0 );
            g2.DrawImage(bmp2, 100, 0);
        }
    }
}
