using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        int w, h, a11, b11, a22, b22, a33, b33, H11, H22, counth1=0, counth2=0;

        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            llenado = 0;
            counth1 = 0;
            counth2 = 0;
         

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        double xa, xb;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("20");
            comboBox1.Items.Add("30");
            comboBox1.Items.Add("40");
            comboBox1.Items.Add("50");
            comboBox1.Items.Add("60");
            comboBox1.Items.Add("70");
            comboBox1.Items.Add("80");
            comboBox1.Items.Add("90");
            comboBox1.Items.Add("100");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //pen para la simulacion 
            Pen p2 = new Pen(Color.Aqua);
            porcentaje = Convert.ToInt32(comboBox1.SelectedItem) * HT / 100;
            p2.Width = 5;
            
            //calcular las nuevas elipses que hacen posible la simulacion
            llenado = llenado + 1;
           

            

            xa = (H11 - counth1) * (a22 - a11) / H11 + a11;
            xb = (H11 - counth1) * (b22 - b11) / H11 + b11;
            //g.DrawEllipse(p2, w / 2 - Convert.ToInt32(xa), h / 2 - Convert.ToInt32(xb) - counth2 + H22, 2 * Convert.ToInt32(xa), 2 * Convert.ToInt32(xb));
            g.FillEllipse(Brushes.Yellow, w / 2 - Convert.ToInt32(xa), h / 2 - Convert.ToInt32(xb) - counth1, 2 * Convert.ToInt32(xa), 2 * Convert.ToInt32(xb));
            counth1 = counth1 + 1;

            Point[] pts = new Point[3];
            pts[0] = new Point(w / 2 - a11, h / 2 - H11);
            pts[1] = new Point(w / 2 - a22, h / 2);
            pts[2] = new Point(w / 2 - a33, h / 2 + H22);
            //izquierda
            Point[] pts1 = new Point[3];
            pts1[0] = new Point(w / 2 + a11, h / 2 - H11);
            pts1[1] = new Point(w / 2 + a22, h / 2);
            pts1[2] = new Point(w / 2 + a33, h / 2 + H22);

            //pen para el dibujo y los trazos
            Pen p1 = new Pen(Color.Black);
            p1.Width = 2;
            //Dibujo las elipses
            g.DrawEllipse(p1, w / 2 - a11, h / 2 - b11 - H11, 2 * a11, 2 * b11);
            g.DrawEllipse(p1, w / 2 - a22, h / 2 - b22, 2 * a22, 2 * b22);
            g.DrawEllipse(p1, w / 2 - a33, h / 2 - b33 + H22, 2 * a33, 2 * b33);
            //Dibujo las lineas que las unen
            g.DrawLines(p1, pts);
            g.DrawLines(p1, pts1);
          

            if ((llenado - porcentaje) == 0)
            {
                timer2.Enabled = false;
            }

            if ((H11 - counth1) == 0)
                timer2.Enabled = false;
        }
        int llenado, porcentaje,HT;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //pen para la simulacion 
            Pen p2 = new Pen(Color.Yellow);
            p2.Width = 2;

            porcentaje = Convert.ToInt32(comboBox1.SelectedItem) * HT / 100;

            //calcular las nuevas elipses que hacen posible la simulacion

            xa = (H22 - counth2) * (a33 - a22) / H22 + a22;
            xb = (H22 - counth2) * (b33 - b22) / H22 + b22;
            //g.DrawEllipse(p2, w / 2 - Convert.ToInt32(xa), h / 2 - Convert.ToInt32(xb) - counth2 + H22, 2 * Convert.ToInt32(xa), 2 * Convert.ToInt32(xb));
            g.FillEllipse(Brushes.Yellow, w / 2 - Convert.ToInt32(xa), h / 2 - Convert.ToInt32(xb) - counth2 + H22, 2 * Convert.ToInt32(xa), 2 * Convert.ToInt32(xb));
            counth2 = counth2 + 1;
            llenado = llenado + 1;
            

            Point[] pts = new Point[3];
            pts[0] = new Point(w / 2 - a11, h / 2 - H11);
            pts[1] = new Point(w / 2 - a22, h / 2);
            pts[2] = new Point(w / 2 - a33, h / 2 + H22);
            //izquierda
            Point[] pts1 = new Point[3];
            pts1[0] = new Point(w / 2 + a11, h / 2 - H11);
            pts1[1] = new Point(w / 2 + a22, h / 2);
            pts1[2] = new Point(w / 2 + a33, h / 2 + H22);

            //pen para el dibujo y los trazos
            Pen p1 = new Pen(Color.Black);
            p1.Width = 2;
            //Dibujo las elipses
            g.DrawEllipse(p1, w / 2 - a11, h / 2 - b11 - H11, 2 * a11, 2 * b11);
            g.DrawEllipse(p1, w / 2 - a22, h / 2 - b22, 2 * a22, 2 * b22);
            g.DrawEllipse(p1, w / 2 - a33, h / 2 - b33 + H22, 2 * a33, 2 * b33);
            //Dibujo las lineas que las unen
            g.DrawLines(p1, pts);
            g.DrawLines(p1, pts1);

           

            if ((llenado - porcentaje) == 0)
            {
                timer1.Enabled = false;
            }


            if ((H22-counth2)==0)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            llenado = 0;
          
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            w = pictureBox1.Size.Width;
            h = pictureBox1.Size.Height;
            a11 = Convert.ToInt32(a1.Text);
            b11 = Convert.ToInt32(b1.Text);
            a22 = Convert.ToInt32(a2.Text);
            b22 = Convert.ToInt32(b2.Text);
            a33 = Convert.ToInt32(a3.Text);
            b33 = Convert.ToInt32(b3.Text);
            H11 = Convert.ToInt32(H1.Text);
            H22 = Convert.ToInt32(H2.Text);
            HT = H11 + H22;
            porcentaje = Convert.ToInt32(comboBox1.SelectedItem) * HT / 100;
            //lineas para cerrar la figuras
            //derecha
            Point[] pts = new Point[3];
            pts[0] = new Point(w / 2 - a11, h / 2 - H11);
            pts[1] = new Point(w / 2 - a22, h / 2);
            pts[2] = new Point(w / 2 - a33, h / 2 + H22);
            //izquierda
            Point[] pts1 = new Point[3];
            pts1[0] = new Point(w / 2 + a11, h / 2 - H11);
            pts1[1] = new Point(w / 2 + a22, h / 2);
            pts1[2] = new Point(w / 2 + a33, h / 2 + H22);

            //pen para el dibujo y los trazos
            Pen p1 = new Pen(Color.Black);
            p1.Width = 2;
            //Dibujo las elipses
            g.DrawEllipse(p1, w / 2 - a11, h / 2 - b11 - H11, 2 * a11, 2 * b11);
            g.DrawEllipse(p1, w / 2 - a22, h / 2 - b22, 2 * a22, 2 * b22);
            g.DrawEllipse(p1, w / 2 - a33, h / 2 - b33 + H22, 2 * a33, 2 * b33);
            //Dibujo las lineas que las unen
            g.DrawLines(p1, pts);
            g.DrawLines(p1,pts1);

        }
    }
}
