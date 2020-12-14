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
    public partial class ModifiyForm : Form
    {
        public ModifiyForm()
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
                MessageBox.Show("Modification effectuée avec success  " );

                
            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }
        }

        private void Bnt_ajouter_Click(object sender, EventArgs e)
        {
            string txtsql = "update client set NomClient = '" + txt_nom.Text + 
                "',ville='"+txt_ville.Text + 
                "',Rue='" +txt_rue.Text + 
                "',Cp=" + txt_cp.Text + 
                ", Tel=" + txt_tel.Text +
                " where NumClient = " +txt_numf.Text+ "";
             lancerRequete(txtsql);
        }
        }
    }

