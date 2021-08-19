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

namespace Practica_Calificada_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        InfoJoystick j0 = new InfoJoystick(0);
        InfoJoystick j1 = new InfoJoystick(1);
        InfoJoystick j2 = new InfoJoystick(2);
        Graphics g1;
        int px, py, pz, pr, x, y, z, r;

        int Alto;
        int Ancho;
        double aux1;
        private void Form1_Load(object sender, EventArgs e)
        {
            Alto = pictureBox1.Height;  // Altura del PictureBox
            Ancho = pictureBox1.Width;  // Ancho del PictureBox
            g1 = pictureBox1.CreateGraphics();
            g1.Clear(Color.White);           // Color de Fondo
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Grosor = 20;             // Ancho del Brazo
            int Largo = 100;                    // Largo del Brazo

            int[] d = j0.GetData();
            string[] ds = j0.GetDataString();

            //listBox1.DataSource = d;
            //listBox2.DataSource = ds;

            px = d[0]; py = d[1]; //pz = d[2]; pr = d[3];
            x = (pz * Ancho) / 65535;
            y = (pr * Alto) / 65535;
            g1.Clear(Color.White);
            g1.FillEllipse(Brushes.Blue, x - 20, y - 20, 40, 40);

            // Primer Grafico
            // Linea Centro
            Point[] ls1 = new Point[2];
            ls1[0] = new Point(x, y);
            ls1[1] = new Point(Ancho / 2, Alto / 2);
            Pen pls1 = new Pen(Color.Blue);
            pls1.Width = 1;
            g1.DrawLines(pls1, ls1);

            // Linea Inferior
            Point[] li1 = new Point[2];
            li1[0] = new Point(Ancho / 2 - Largo, Alto / 2 + Grosor);
            li1[1] = new Point(Ancho / 2, Alto / 2 + Grosor);
            Pen pli1 = new Pen(Color.Blue);
            pli1.Width = 1;
            g1.DrawLines(pli1, li1);

           
           //CENTRO
            Rectangle c1 = new Rectangle(Ancho/2-20, Alto/2-20, 40, 40);
            /*Pen pc1 = new Pen(Color.Purple);
            pc1.Width = 1;
            g1.DrawEllipse(pc1, c1);
            */
            g1.FillEllipse(Brushes.Blue, c1);

  
            // Circulo

            Rectangle c2 = new Rectangle(0,0,Ancho, Alto);
            Pen pc2 = new Pen(Color.Purple);
            pc2.Width = 1;
            g1.DrawEllipse(pc2, c2);

            // Circulo 2 
            Rectangle c3 = new Rectangle((int)(Ancho / 2 - 20+aux1), 0, 40, 40);
            g1.FillEllipse(Brushes.Red, c3);
            if (px>32511)
            {
                aux1=aux1+0.1;
            }
            if (px< 32511)
            {
                aux1 = aux1 - 0.1;
            }
            if (px == 32511)
            {
                aux1 = 0;
            }
            
            Pen sal = new Pen(Color.Red);
            g1.DrawLine(sal, Ancho / 2, Alto / 2, Ancho/2+(int)(Ancho/2 * Math.Cos(aux1)), Alto/2+(int)(Alto/2 * Math.Sin(aux1)));


            Rectangle c4 = new Rectangle(Ancho / 2 + (int)(Ancho / 2 * Math.Cos(aux1))-20, Alto / 2 + (int)(Alto / 2 * Math.Sin(aux1))-20, 40, 40);
            g1.FillEllipse(Brushes.Green, c4);
        }
    }
}
