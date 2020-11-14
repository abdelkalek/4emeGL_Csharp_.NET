using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manip_multiform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2;
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null) 
            {
                f2 = new Form2();
                f2.MdiParent = this;
                f2.FormClosed += f2_FormClosed;
                f2.Show();
            }
            else 
            {
                f2.Activate();
            }
           
        }

        void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null; 
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.MdiParent = this;
            f.Show(); 
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade); 
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop(); 
        }

        private void reduireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] char1 = this.MdiChildren;
            foreach(Form ch in char1)
            {
                ch.WindowState = FormWindowState.Minimized;
            }

        }

        private void agrandirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] char1 = this.MdiChildren;
            foreach (Form ch in char1)
            {
                ch.WindowState = FormWindowState.Maximized;
            }
        }

        private void fermerToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] char1 = this.MdiChildren;
            foreach (Form ch in char1)
            {
                ch.Close();
            }
        }

        private void calculatirceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe"); 
        }
    }
}
