using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion
{
    public partial class AjouterForm : Form
    {
        public AjouterForm()
        {
            InitializeComponent();
        }
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = commercial.mdb";
        public void lancerRequete(string requete)
        {
            OleDbConnection ocn = new OleDbConnection();
            OleDbCommand ocm = new OleDbCommand();
            ocn.ConnectionString = sconstr;
            try
            {
                ocn.Open();
                ocm.Connection = ocn;

                ocm.CommandText = requete;
                ocm.ExecuteNonQuery();
                ocn.Close();
                MessageBox.Show("insertion terminer avec succee");
            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bnt_ajouter_Click(object sender, EventArgs e)
        {
            string txtinsert;
            txtinsert = "insert into client (NumClient,NomClient,Ville,Rue,Cp,Tel) values(" + txt_num.Text + ",'" + txt_nom.Text + "','" + txt_ville.Text + "','" + txt_rue.Text + "'," + txt_cp.Text+ "," + txt_tel.Text + ")";
            lancerRequete(txtinsert);
        }
    }
}
