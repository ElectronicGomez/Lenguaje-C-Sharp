using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reloj
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g1;
        double var;
        int w, h;
        double alfa1 = 0, alfa2=2;
        double radioesp ;
        int vueltas=2;
        int vez = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g1.Clear(Color.White);
            alfa1 = 0;
            radioesp = 1;
            Rectangle rec = new Rectangle(10, 10, w - 20, h - 20);
            g1.DrawEllipse(new Pen(Color.Blue, 3), rec);
            pictureBox1.Image = bmp;
            timer1.Interval = 1;
            timer2.Enabled = false;
            timer1.Enabled = true;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            vueltas = Convert.ToInt32(comboBox2.SelectedIndex)+1;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int a = trackBar1.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (vez == 0) {
                timer2.Enabled = true;
                vez = 1;
            }
            else
            {
                timer2.Enabled = false;
                vez = 0;

            }
            timer2.Interval = 50;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = bmp;
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //g1.Clear(Color.White);
            //Rectangle rec = new Rectangle(10, 10, w - 20, h - 20);
            //g1.DrawEllipse(new Pen(Color.Blue, 3), rec);
            //g1.DrawLine(new Pen(Color.Blue, 3), w / 2, h / 2, Convert.ToSingle(w / 2 + ((w - 20) / 2) * Math.Cos(alfa1*Math.PI/180)), Convert.ToSingle(h / 2 + ((h - 20) / 2) * Math.Sin(alfa1*Math.PI/180)));
            //alfa1++;
            //g1.DrawLine(new Pen(Color.Blue, 3), w / 2, h / 2, Convert.ToSingle(w / 2 + ((w - 20) / 2) * Math.Cos(alfa2 * Math.PI / 180)), Convert.ToSingle(h / 2 + ((h - 20) / 2) * Math.Sin(alfa2 * Math.PI / 180)));
            //alfa2 += 5;
            g1.FillEllipse(Brushes.Red, Convert.ToSingle(w / 2 + radioesp* Math.Cos(alfa1 * Math.PI / 180)), Convert.ToSingle(h / 2 + (radioesp) * Math.Sin(alfa1 * Math.PI / 180)), 10,10 );
            alfa1-=2 ;
            radioesp = radioesp + 0.2;
            if (alfa1<=-(360*vueltas))
            {
                timer1.Enabled = false;
            }


            pictureBox1.Image = bmp;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 8; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
            w = pictureBox1.Width;
            h = pictureBox1.Height;
            bmp = new Bitmap(w, h);           
            g1 = Graphics.FromImage(bmp);
            radioesp = 1;

            //radioesp = (w - 2) / 2;

        }
    }
}
