using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grafica;
        int t = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(textBox1.Text);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            grafica = pictureBox1.CreateGraphics();
            Point[] pts = new Point[5];
            pts[0] = new Point(60, 280 - t);
            pts[1] = new Point(140, 280 - t);
            pts[2] = new Point(180, 240 - t);
            pts[3] = new Point(100, 210 - t);
            pts[4] = new Point(20, 240 - t);
            grafica.FillPolygon(Brushes.DarkBlue, pts);
            //Relieve
            grafica.DrawPolygon(new Pen(Color.Blue,1), pts);
            //Tanque no optimizado
            //Tapa de arriba
            grafica.DrawLine(new Pen(Color.Black, 2), 60, 280, 140, 280);
            grafica.DrawLine(new Pen(Color.Black, 2), 140, 280, 180, 240);
            grafica.DrawLine(new Pen(Color.Black, 2), 60, 280, 20, 240);
            grafica.DrawLine(new Pen(Color.Black, 2), 180, 240, 100, 210);
            grafica.DrawLine(new Pen(Color.Black, 2), 20, 240, 100, 210);
            //Tapa de abajo
            grafica.DrawLine(new Pen(Color.Black, 2), 60, 80, 140, 80);
            grafica.DrawLine(new Pen(Color.Black, 2), 140, 80, 180, 40);
            grafica.DrawLine(new Pen(Color.Black, 2), 60, 80, 20, 40);
            grafica.DrawLine(new Pen(Color.Black, 2), 180, 40, 100, 10);
            grafica.DrawLine(new Pen(Color.Black, 2), 20, 40, 100, 10);
            //Aristas
            grafica.DrawLine(new Pen(Color.Black, 2), 60, 280, 60, 80);
            grafica.DrawLine(new Pen(Color.Black, 2), 140, 280, 140, 80);
            grafica.DrawLine(new Pen(Color.Black, 2), 20, 240, 20, 40);
            grafica.DrawLine(new Pen(Color.Black, 2), 180, 240, 180, 40);
            grafica.DrawLine(new Pen(Color.Black, 2), 100, 210, 100, 10);
            t++;
            if (t == 2 * Convert.ToInt32(textBox2.Text)) timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
