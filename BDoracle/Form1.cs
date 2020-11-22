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
using Oracle;
using System.Data.OracleClient; 



namespace BDoracle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Conn_bnt_Click(object sender, EventArgs e)
        {

            try 
            {

                OracleConnection con = new OracleConnection();
                con.ConnectionString = "User Id=abdelkalek;Password=abdelkalek;Data Source=ORCL";
                 con.Open();
                MessageBox.Show("Connected to Oracle");

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);

            }
        

            // Close and Dispose OracleConnection object
        //    con.Close();
           // con.Dispose();
    
        }
    }
}
