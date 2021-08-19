using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Joystick;


namespace semana3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        InfoJoystick j0 = new InfoJoystick(0);
        InfoJoystick j1 = new InfoJoystick(1);
        InfoJoystick j2= new InfoJoystick(2);
        int x, y, px, py, w, h;
        int cx,cy;
        Graphics g1,g2;
        Bitmap bmp;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int[] d = j0.GetData();
            string[] ds = j0.GetDataString();
            listBox1.DataSource = d;
            listBox2.DataSource = ds;


            x = d[0]; y = d[1];
            //px = x * w /cx;
            //py = y * h / cy;
            if (x < 32767) cx = cx - 10;
            if (x > 32767) cx = cx + 10;
            if (y < 32767) cy = cy - 10;
            if (y > 32767) cy = cy + 10;

            g1.Clear(Color.Yellow);
            g1.FillEllipse(Brushes.Brown, cx- 10, cy - 10, 20, 20);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int[] d = j0.GetData();
            string[] ds = j0.GetDataString();
            listBox1.DataSource = d;
            listBox2.DataSource = ds;


            x = d[0]; y = d[1];
            //px = x * w /cx;
            //py = y * h / cy;
            if (x < 32767) cx = cx - 10;
            if (x > 32767) cx = cx + 10;
            if (y < 32767) cy = cy - 10;
            if (y > 32767) cy = cy + 10;

            g2.Clear(Color.Yellow);
            g2.FillEllipse(Brushes.Brown, cx - 10, cy - 10, 20, 20);

            pictureBox1.Image = bmp;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            g1 = pictureBox1.CreateGraphics();
            w = pictureBox1.Width;
            h = pictureBox1.Height;
            /******/
            cx = w/2; cy =h/2;
            bmp = new Bitmap(w, h);
            g2 = Graphics.FromImage(bmp);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] d = j0.GetData();
            string[] ds = j0.GetDataString();
            listBox1.DataSource = d;
            listBox2.DataSource = ds;

            x = d[0]; y = d[1];
            px = x * w / 65535;
            py = y * h / 65535;

            g1.Clear(Color.Yellow);
            g1.FillEllipse(Brushes.Brown, px - 10, py - 10, 20, 20);

        }
    }
}
