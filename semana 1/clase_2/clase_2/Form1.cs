using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // string d = textBox3.Text; //palabra
            //int t = d.Length;
            //int ca;
            //listBox1.
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            int ca;
            char ch;
            string s = "";
            string d = textBox5.Text;
            int t = d.Length;
            for (int i = 0; i < t; i++)
            {
                ca = (int)d[i] + 5;
                ch=(char)ca;
                s = s + ch;


            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = 0;
            int[,] num = new int[5, 5];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    n = n + 1;
                    num[i, j] = n;
                }
            MessageBox.Show(num[3, 2].ToString());
                
        }
    }
}
