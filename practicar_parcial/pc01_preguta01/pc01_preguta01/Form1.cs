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
namespace pc01_preguta01
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
        int[] dato;
        string[] s_dato;
        int x, y, w, h;
        double x_1, y_1,x_2,y_2,x_3,y_3;
        int contador=0;
        int contador2 = 90;
        int contador3 = 270;
        private void Form1_Load(object sender, EventArgs e)
        {
            g1 = pictureBox1.CreateGraphics();
            g1.Clear(Color.White);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dato = j0.GetData();
            s_dato = j0.GetDataString();
            listBox1.DataSource = dato;
            listBox2.DataSource = s_dato;
            if (dato[1] < 10)
            {
                contador = contador + 1;
                contador2 = contador2 + 1;
                contador3 = contador3 + 1;
            }
            if (dato[1] > 65500)
            {
                contador = contador - 1;
                contador2 = contador2 - 1;
                contador3 = contador3 - 1;
            }

            g1.Clear(Color.White);
            x = pictureBox1.Size.Width / 2;
            y = pictureBox1.Size.Height / 2;
            double angulo = Math.PI * contador / 180.0;
            double angulo2 = Math.PI * contador2 / 180.0;
            double angulo3 = Math.PI * contador3 / 180.0;

            x_1 = x+250 * Math.Cos(angulo);
            y_1 = (y-25)-250 * Math.Sin(angulo);
            Pen a = new Pen(Color.Black, 3);
            Pen b = new Pen(Color.Black, 3);
            x_2= 25*Math.Cos(angulo2);
            y_2 = 25*Math.Sin(angulo2);
            x_3 = 25 * Math.Cos(angulo3);
            y_3 = 25 * Math.Sin(angulo3);

            /*g1.DrawEllipse(a, x - 25, y - 25, 50, 50);
            g1.DrawEllipse(a, (int)x_1, (int)y_1, 50, 50);
            label1.Text = contador.ToString();
            label2.Text = contador2.ToString();*/

            if (contador < 90 && contador > 0)
            {
                g1.DrawLine(b, x + (int)x_2, y - (int)y_2, ((int)x_1 + 25) + (int)x_2, ((int)y_1 + 25) - (int)y_2);
                g1.DrawLine(b, x + (int)x_3, y - (int)y_3, ((int)x_1 + 25) + (int)x_3, ((int)y_1 + 25) - (int)y_3);

            }
            if (contador < 180 && contador >= 90)
            {
                g1.DrawLine(b, x + (int)x_2, y - (int)y_2, ((int)x_1 + 25) + (int)x_2, ((int)y_1 + 25) - (int)y_2);
                g1.DrawLine(b, x + (int)x_3, y - (int)y_3, ((int)x_1 + 25) + (int)x_3, ((int)y_1 + 25) - (int)y_3);
            }

            if (contador < 270 && contador >= 180)
            {
                g1.DrawLine(b, x + (int)x_2, y - (int)y_2, ((int)x_1 + 25) + (int)x_2, ((int)y_1 + 25) - (int)y_2);
                g1.DrawLine(b, x + (int)x_3, y - (int)y_3, ((int)x_1 + 25) + (int)x_3, ((int)y_1 + 25) - (int)y_3);
            }

            if (contador < 360 && contador >= 270)
            {
                g1.DrawLine(b, x + (int)x_2, y - (int)y_2, ((int)x_1 + 25) + (int)x_2, ((int)y_1 + 25) - (int)y_2);
                //g1.DrawLine(b, x, y + 25, ((int)x_1 + 25), ((int)y_1 + 50));
                g1.DrawLine(b, x + (int)x_3, y - (int)y_3, ((int)x_1 + 25) + (int)x_3, ((int)y_1 + 25) - (int)y_3);
            }
               
            if (contador == 360) contador = 0;

            //g1.DrawLine(b, x, y+25, ((int)x_1 + 25), (int)y_1+50);


        }
    }
}
