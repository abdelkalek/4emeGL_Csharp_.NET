using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bnt_Bonjour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bonjour"+Txt_nomPrenom.Text,"entete",MessageBoxButtons.YesNo);

        }
    }
}
