using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using libreriaEL67;  //

namespace claseDLL6a
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //Class1 x = new Class1();
        libreriaEL67.Class1 x = new libreriaEL67.Class1();
        libreriaEL67.Class2 y = new libreriaEL67.Class2();
        private void button1_Click(object sender, EventArgs e)
        {
            //haciendo de la clase de la DLL
            int r = x.divide(8, 0);
            MessageBox.Show(r.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = y.dibuja(100, 100, Color.Blue, Color.White);
        }
    }
}
