using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace claseDLL6a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int suma(int a, int b)
        {
            int r = a + b;
            return (r);
        }

        void calcular(int a, int b)
        {
            int r = a + b;
            MessageBox.Show(r.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //usando la funcion suma
            int t = suma(5, 6);
            MessageBox.Show(t.ToString());

            //usando el procedimiento
            calcular(5, 8);
        }
    }
}
