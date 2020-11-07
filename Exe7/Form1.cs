using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Txt_numerique_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!(char.IsDigit(e.KeyChar)|char.IsControl(e.KeyChar))))
            {
               Txt_numerique.BackColor= Color.LightPink;
                e.Handled= true; 
            }
            else 
            {
                Txt_numerique.BackColor = Color.LightGreen;

            }
        }

        private void Txt_decimale_KeyPress(object sender, KeyPressEventArgs e)
        {

            string Decimalseparator = Convert.ToString(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
   
            if ((!(Decimalseparator.IndexOf(e.KeyChar) != -1 | char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar))))
            {
                 Txt_decimale.BackColor = Color.LightPink;
                e.Handled = true;
            }
            else
                 Txt_decimale.BackColor = Color.LightGreen;
        }

        private void Txt_alphabetique_KeyPress(object sender, KeyPressEventArgs e)
        {

      
            if((!(char.IsLetter(e.KeyChar)|char.IsControl(e.KeyChar))))
            {
                Txt_alphabetique.BackColor = Color.LightPink;
                e.Handled= true; 
            }
            else 
            {
                Txt_alphabetique.BackColor= Color.LightGreen;

            }
        }

        private void Majus_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!(char.IsUpper(e.KeyChar) | char.IsControl(e.KeyChar))))
            {
                Majus.BackColor = Color.LightPink;
                e.Handled = true;
            }
            else
            {
                Majus.BackColor = Color.LightGreen;

            }
        }

        private void Txt_munis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!(char.IsLower(e.KeyChar) | char.IsControl(e.KeyChar))))
            {
                Txt_munis.BackColor = Color.LightPink;
                e.Handled = true;
            }
            else
            {
                Txt_munis.BackColor = Color.LightGreen;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Numerique2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!(char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar))))
            {
               errorProvider1.SetError( txt_Numerique2,"Text non valide");
      
                e.Handled = true;
            }
            else
            {

              errorProvider1.SetError(txt_Numerique2, "");
            }
        }

        private void Txt_Alpha_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!(char.IsLetter(e.KeyChar) | char.IsControl(e.KeyChar))))
            {

                errorProvider2.SetError(Txt_Alpha, "Text non valide");
                e.Handled = true;
            }
            else
            {
                errorProvider2.SetError(Txt_Alpha, "");
               
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match result = email.Match(textBox7.Text);
            if (result.Success)
            {
                Email_errorProvider3.Clear();
                //txt_IPadresse.BackColor = Color.windows;
            }
            else
            {
                //txt_IPadresse.BackColor = Color.Red;
                Email_errorProvider3.SetError(textBox7, "adress Email non valide");
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            Regex ip = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            Match result = ip.Match(textBox7.Text);
            if (result.Success)
            {
                IP_errorProvider.Clear();
                //txt_IPadresse.BackColor = Color.windows;
            }
            else
            {
                //txt_IPadresse.BackColor = Color.Red;
                IP_errorProvider.SetError(textBox7, "adress ip non valide");
            }
        }
    
    }
}
