using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bnt_Ajouter_Click(object sender, EventArgs e)
        {
            
            Txt_List.Text = Txt_List.Text + Txt_Nom.Text +"\r\n";
            Txt_Nom.Text="";
            Txt_Nom.Focus();


        }
    }
}
