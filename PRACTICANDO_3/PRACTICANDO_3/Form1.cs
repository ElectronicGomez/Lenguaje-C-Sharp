using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICANDO_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp1, bmp2, bmp3;
        Graphics g1, g2;
        int w, h;
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp1 = new Bitmap(100, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
                for (int j = 0; j < 100; j++)
                {
                    if (i == j)
                        bmp1.SetPixel(i, j, Color.White);
                    else
                        bmp1.SetPixel(i, j, Color.FromArgb(0, 0, 255));

                }
            pictureBox1.Image = bmp1;



        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < w; i++)
                for (int j = 0; j < h; j++)
                {
                    c = bmp2.GetPixel(i, j);
                    bmp3.SetPixel(i, j, Color.FromArgb(c.A, c.G, c.B, c.R));

                }
            pictureBox2.Image = bmp3;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images BMP|*.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                string ruta = op.FileName;
                bmp2 = new Bitmap(ruta);
                pictureBox1.Image = bmp2;

                w = bmp2.Width;
                h = bmp2.Height;
                bmp3 = new Bitmap(w, h);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g1 = Graphics.FromImage(bmp1);
            g1.Clear(Color.Red);

            Pen p = new Pen(Color.Black, 1);
            g1.DrawLine(p, 0, 0, 100, 100);

            pictureBox1.Image = bmp1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmp1 = new Bitmap(100, 100);
            g1 = Graphics.FromImage(bmp1);
            g1.Clear(Color.Yellow);
            Pen p = new Pen(Color.White, 1);
            g1.DrawLine(p, 0, 0, 100, 100);
            //pictureBox1.Image = bmp1;
            g2 = pictureBox1.CreateGraphics();
            g2.DrawImage(bmp1, 0, 0);
            g2.DrawImage(bmp1, 0, 120);

        }
    }
            

}
