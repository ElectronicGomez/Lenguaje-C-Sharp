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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void pREGUNTA1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.MdiParent = this;  //this hace referencia al formulario donde estas
            x.Show();

        }

        private void pREGUNTA2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 y = new Form2();
            y.MdiParent = this;  //this hace referencia al formulario donde estas
            y.Show();
        }

        private void pREGUNTA3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 z = new Form3();
            z.MdiParent = this;
            z.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
