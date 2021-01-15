using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = commercial.mdb";
        public string convstring(String name)
        {
            String ch = "";
            for (int i = 0; i <= name.Length - 1; i++)
            {
                if (name[i] == '\'')
                {
                    ch += "\''";

                }
                else
                {
                    ch += name[i];
                }
            }
            return ch;
        }
        private void bnt_connexion_Click(object sender, EventArgs e)
        {

         

            string txtsql;
            txtsql = "select count(login) from connexion where login='" + convstring(txt_login.Text) + "' and pwd='" + convstring(txt_password.Text) + "'";
          
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);

            Int32 ival;
            try
            {
                ocm.Connection.Open();
                ival = Convert.ToInt32(ocm.ExecuteScalar());
                if (ival == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("verfier l'indetification");
                    txt_login.Text = "";
                    txt_password.Text = "";
                    txt_login.Focus();
                    ocm.Connection.Close();
                }
                else 
                {
                    this.Hide(); 
                    Form1 f = new Form1();
                    f.ShowDialog();
             
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

   

        private void bnt_quitter_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
    
}
