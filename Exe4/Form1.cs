using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new String[] { "zero", "un", "deux", "trois", "quatre" });
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedIndex.ToString()+" "+comboBox1.SelectedItem.ToString()); 
        }

        private void Bnt_Ajouter_Click(object sender, EventArgs e)
        {
       comboBox1.Items.Add(Txt_text.Text);
            Txt_text.Text="";
             Txt_text.Focus() ; 
        }

        private void Bnt_supp_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex); 
        }
    }
}
