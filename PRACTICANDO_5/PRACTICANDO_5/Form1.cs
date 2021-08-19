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

namespace PRACTICANDO_5
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
        int x, y, px, py, w, h;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] d = j0.GetData();
            string[] ds = j0.GetDataString();

        }

        int cx, cy;
        Graphics g1, g2;
        Bitmap bmp1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
         



        }
    }
}
