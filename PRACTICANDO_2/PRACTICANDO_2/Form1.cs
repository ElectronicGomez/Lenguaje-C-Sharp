using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICANDO_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            string d = textBox1.Text;
            for (int i = 0; i < d.Length;i++) 
            {
                //char ch = d[i];
                int a = (int)d[i];
                s = s + a.ToString();                
                textBox2.Text = s;                                        

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d = textBox3.Text;
            listBox1.Items.Clear();
            for (int i=0; i < d.Length; i++)
            {

                int ca = (int)d[i];
                listBox1.Items.Add(d[i] + ">>" + ca);


            }
            

        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            listBox2.Items.Add(ch +">>"+ (int)ch);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string d = textBox5.Text;
            string s = "";
            for (int i = 0; i < d.Length; i++)
            {
                int ca = (int)d[i]+5;                
                s = s + (char)ca;
            }
            textBox6.Text = s;
        }
        string encriptar(string palabra, int num)
        {
            
            string s = "";
            for (int i = 0;i<palabra.Length; i++)
            {
                int ca = (int)palabra[i] + num;
                s = s + (char)ca;

            }
            return (s);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string d = textBox7.Text;
            textBox8.Text = encriptar(d, 6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] palabras = new string[5];
            char[] ch= new char[10];
            int[] num = new int[10];
            for(int i=0; i<10;i++)
            {
                //listBox3.Items.Add(65 + i);
                //listBox4.Items.Add((char)(65 + i));
                num[i] = 65 + i;
                ch[i] = (char)num[i];
            }
            listBox3.DataSource = num;
            listBox4.DataSource = ch;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = 0;
            int[,] num = new int[5, 5];
            for(int i=0; i<5;i++)
                for(int j=0;j<5;j++)
                {
                    n = n + 1;
                    num[i, j] = n;
                }
            MessageBox.Show(num[3,2].ToString());
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
