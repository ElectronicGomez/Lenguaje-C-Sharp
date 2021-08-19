using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grafica;
        bool bandera = true;
        int t = 0;
        int b = 0;
        int seg = 90;
        int contador;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 60;
            timer1.Enabled = true;
            grafica = pictureBox1.CreateGraphics();
            grafica.Clear(Color.White);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                bandera = false;
                b = Convert.ToInt32(textBox1.Text) * 360 / 12 + 90;
                t = Convert.ToInt32(textBox2.Text) * 360 / 60 + 90;
                contador = Convert.ToInt32(textBox2.Text);
            }
            grafica.Clear(Color.White);
            for (int i = 1; i < 13; i++) grafica.DrawLine(new Pen(Color.Black, 1), 100, 100, 100 - 100 * (float)Math.Cos(i * 30 * Math.PI / 180), 100 - 100 * (float)Math.Sin(i * 30 * Math.PI / 180));
            grafica.DrawEllipse(new Pen(Color.Black, 4), 20, 20, 160, 160);
            for (int i = 4; i < 16; i++) grafica.DrawString((i-3).ToString(), new Font("Arial", 7), new SolidBrush(Color.DarkBlue), 95 - 90 * (float)Math.Cos(i * 30 * Math.PI / 180), 95 - 90 * (float)Math.Sin(i * 30 * Math.PI / 180));
            grafica.DrawLine(new Pen(Color.Red, 4), 100, 100, 100 - 70 * (float)Math.Cos(t * Math.PI / 180), 100 - 70 * (float)Math.Sin(t * Math.PI / 180));
            grafica.DrawLine(new Pen(Color.Blue, 4), 100, 100, 100 - 40 * (float)Math.Cos(b * Math.PI / 180), 100 - 40 * (float)Math.Sin(b * Math.PI / 180));
            grafica.DrawLine(new Pen(Color.Black, 1), 100, 100, 100 - 80 * (float)Math.Cos(seg * Math.PI / 180), 100 - 80 * (float)Math.Sin(seg * Math.PI / 180));
            seg++;
            if (seg == 450)
            {
                seg = 90;
                t = t + 6;
                contador++;
            }
            if (contador == 60) 
            {
                b = b + 30;
                contador = 1;
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox1.Text)*360/12+90;
            int a = Convert.ToInt32(textBox2.Text)*360/60+90;
            grafica = pictureBox1.CreateGraphics();
            grafica.Clear(Color.White);
            for (int i = 1; i < 13; i++) grafica.DrawLine(new Pen(Color.Black, 1), 100, 100, 100 - 100 * (float)Math.Cos(i * 30 * Math.PI / 180), 100 - 100 * (float)Math.Sin(i * 30 * Math.PI / 180));
            grafica.DrawEllipse(new Pen(Color.Black, 4), 20, 20, 160, 160);
            for (int i = 4; i < 16; i++) grafica.DrawString((i - 3).ToString(), new Font("Arial", 7), new SolidBrush(Color.DarkBlue), 95 - 90 * (float)Math.Cos(i * 30 * Math.PI / 180), 95 - 90 * (float)Math.Sin(i * 30 * Math.PI / 180));
            grafica.DrawLine(new Pen(Color.Red, 4), 100, 100, 100 - 80 * (float)Math.Cos(a * Math.PI / 180), 100 - 80 * (float)Math.Sin(a * Math.PI / 180));
            grafica.DrawLine(new Pen(Color.Blue, 4), 100, 100, 100 - 40 * (float)Math.Cos(c * Math.PI / 180), 100 - 40 * (float)Math.Sin(c * Math.PI / 180));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
