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

namespace PC_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g1;
        InfoJoystick j0 = new InfoJoystick(0);
        InfoJoystick j1 = new InfoJoystick(1);
        InfoJoystick j2 = new InfoJoystick(2);
        //double alfa1, alfa2, alfa3;
        string[] datos;
        int[] data;
        int x, y, w, h;
        int px, py, pz, pr;
        //int cont1 = 0, cont2 = 90, cont3 = 270;
        double alfa = Math.PI / 4;
       



        private void timer1_Tick(object sender, EventArgs e)
        {
            x = pictureBox1.Size.Width ;
            y = pictureBox1.Size.Height ;
            Rectangle rec = new Rectangle((x/2)-100,(y/2)-100, 200, 200);
            Pen p = new Pen(Color.Blue, 4);
            g1.DrawEllipse(p, rec);
            int[] data = j0.GetData();
            string[] datos = j0.GetDataString();
            listBox1.DataSource = data;
            listBox2.DataSource = datos;
            double angulo1=Math.PI/4+ 0.463647609; // tan^-1(25/50)=0.463647609
            double angulo2 = angulo1- 0.463647609;

            if (data[0] == 0)
            {
                alfa = alfa + 0.1;
            }
            if (data[0] == 65535)
            {
                alfa = alfa - 0.1;
            }
            PointF[] pnts=new PointF[3]; 
            pnts[0]=new PointF( 50 + (x / 2) - 100, 50 + (y / 2) - 100);
            pnts[1] = new PointF(Convert.ToSingle(50 + (x / 2) - 100 + 55.9016994 * Math.Cos(angulo1)), Convert.ToSingle(50 + (y / 2) - 100 + 55.90169944 * Math.Sin(angulo1)));
            pnts[2] = new PointF(Convert.ToSingle(50 + (x / 2) - 100 + 55.9016994 * Math.Cos(angulo2)), Convert.ToSingle(50 + (y / 2) - 100 + 55.90169944 * Math.Sin(angulo2)));
            g1.FillPolygon(Brushes.Blue, pnts);





        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int alt, ancho;
        private void Form1_Load(object sender, EventArgs e)
        {
            g1 = pictureBox1.CreateGraphics();
            g1.Clear(Color.Blue);
            alt = pictureBox1.Height;
            ancho = pictureBox1.Width;
        }
    }
}
