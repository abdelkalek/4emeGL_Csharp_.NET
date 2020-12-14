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
    public partial class Form1 : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = commercial.mdb";
        public Form1()
        {
            InitializeComponent();
        }


        public void charger_Liste_client()
        {
            dataGridClient.Rows.Clear();
            string txtsql;
            txtsql = "select * from Client";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string[] row = new string[] { reader.GetValue(1).ToString(), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetValue(5).ToString(), reader["tel"].ToString() };
                dataGridClient.Rows.Add(row);
            }
            reader.Close();
            ocn.Close();
        }
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
                int k = ocm.ExecuteNonQuery();
                ocn.Close();
                MessageBox.Show("Supression terminer ok");
            }

            catch (Exception ex)
            {
                MessageBox.Show("exception Générée : " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            charger_Liste_client();
        }

        private void Ajouter_BNT_Click(object sender, EventArgs e)
        {
            AjouterForm aF = new AjouterForm();
            aF.ShowDialog();
            charger_Liste_client();

        }

        private void Modifier_BNT_Click(object sender, EventArgs e)
        {
            ModifiyForm mf = new ModifiyForm();
            int index;
            String numc, nomc, ville, rue, cp, tel;
            if (dataGridClient.RowCount == 0)
                return;
            index = dataGridClient.CurrentRow.Index;
            numc = dataGridClient.Rows[index].Cells[0].Value.ToString();
            nomc = dataGridClient.Rows[index].Cells[1].Value.ToString();
            ville = dataGridClient.Rows[index].Cells[2].Value.ToString();
            rue = dataGridClient.Rows[index].Cells[3].Value.ToString();
            cp = dataGridClient.Rows[index].Cells[4].Value.ToString();
            tel = dataGridClient.Rows[index].Cells[5].Value.ToString();
            mf.txt_numf.Text = numc;
            mf.txt_nom.Text = nomc;
            mf.txt_ville.Text = ville;
            mf.txt_rue.Text = rue;
            mf.txt_cp.Text = cp;
            mf.txt_tel.Text = tel;
            mf.ShowDialog();
            charger_Liste_client();

        }

        private void Supprimer_Bnt_Click(object sender, EventArgs e)
        {
            int index;
            String numClient;
            String req_sup;
            if (dataGridClient.RowCount == 0)
                return;
            index = dataGridClient.CurrentRow.Index;
            numClient = dataGridClient.Rows[index].Cells[0].Value.ToString();
            DialogResult supp = (MessageBox.Show("Voulez supprimer le Client '" + dataGridClient.Rows[index].Cells[1].Value.ToString() + "'", "suppression Client", MessageBoxButtons.YesNo));
            if (supp == DialogResult.Yes)
            {
                req_sup = "delete from client where numClient =" + numClient + "";
                lancerRequete(req_sup);
                charger_Liste_client();
            }
            else
                return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridClient.Rows.Clear();
            string txtsql;
            txtsql = "select * from Client where nomClient like '%" + Txt_chercher.Text + "%' or ville like '%" + Txt_chercher.Text + "%'";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();
            OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string[] row = new string[] { reader.GetValue(1).ToString(), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetValue(5).ToString(), reader["tel"].ToString() };
                dataGridClient.Rows.Add(row);
            }
            reader.Close();
            ocn.Close();
        }


    }

}
