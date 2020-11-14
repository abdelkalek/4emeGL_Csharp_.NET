using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Timer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void bnt_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bnt_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
