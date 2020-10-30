using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bnt_Ajouter_Click(object sender, EventArgs e)
        {
            Txt_Saisie.Text=  Txt_Saisie.Text.Trim(); 
            if(Txt_Saisie.Text!="")
            {
                listBox1.Items.Add(Txt_Saisie.Text); 
            }
            Txt_Saisie.Text = "";
            Txt_Saisie.Focus();
        }

        private void bnt_liste2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch (Exception E) { MessageBox.Show("Erreur : " + E);  }
        }

        private void bnt_liste1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            catch (Exception E) { MessageBox.Show("Erreur : " + E); }

        }

        private void Bnt_supp_list1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 

        }

        private void Bnt_supp_list2_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }
    }
}
