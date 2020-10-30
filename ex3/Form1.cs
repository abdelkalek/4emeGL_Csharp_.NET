using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bnt_Quitter_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("voulez Vous  Quitter", "Quitter", MessageBoxButtons.YesNo);
          
            if (dialogResult == DialogResult.Yes) 
            {
                Application.Exit(); 
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("voulez Vous  Quitter", "Quitter", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Merciiiiiiiiiii"); 
        }

    }
}
