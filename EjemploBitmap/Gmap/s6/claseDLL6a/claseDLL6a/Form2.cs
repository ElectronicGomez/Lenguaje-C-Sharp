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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Class1 x = new Class1(); // esta linea se pone para compartir datos

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //uso de funcioines dentro de la clase
            int r = x.restar(7, 4);
            MessageBox.Show(r.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //uso de la funcion de la dividir
            int r = x.divide(5, 2);
            MessageBox.Show(r.ToString());
        }
    }
}
