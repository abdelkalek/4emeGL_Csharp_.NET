using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace write_read_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_save_Click(object sender, EventArgs e)
        {
            // on sauvegarde la boîte de saisie dans un fichier texte
            // on paramètre la boîte de dialogue savefileDialog1
            saveFileDialog1.InitialDirectory = Application.ExecutablePath;
            saveFileDialog1.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            //saveFileDialog1.FilterIndex = 0;
            // on affiche la boîte de dialogue et on récupère son résultat
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // on récupère le nom du fichier
                string nomFichier = saveFileDialog1.FileName;
                StreamWriter fichier = null;
                try
                {
                    // on ouvre le fichier en écriture
                    fichier = new StreamWriter(nomFichier);
                    // on écrit le texte dedans
                    fichier.Write(textBox1.Text);


                    //ecrire a la fin de fichier ces 3 ligne 
                  /*  using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("This");
                        sw.WriteLine("is Extra");
                        sw.WriteLine("Text");
                    }	*/
                }
                catch (Exception ex)
                {
                    // problème
                    MessageBox.Show("Problème à l'écriture du fichier (" +
                    ex.Message + ")", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    // on ferme le fichier
                    if (fichier != null)
                    {
                        fichier.Dispose();
                    }
                }
            }
        }

        private void bnt_load_Click(object sender, EventArgs e)
        {
            // on sauvegarde la boîte de saisie dans un fichier texte
            // on paramètre la boîte de dialogue savefileDialog1

            openFileDialog1.InitialDirectory = Application.ExecutablePath;
            openFileDialog1.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            // on affiche la boîte de dialogue et on récupère son résultat
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // on récupère le nom du fichier
                string nomFichier = openFileDialog1.FileName;
                StreamReader fichier = null;
                try
                {
                    // on ouvre le fichier en écriture
                    fichier = new StreamReader(nomFichier);
                    // on écrit le texte dedans
                    textBox1.Text = fichier.ReadToEnd();
                }
                catch (Exception ex)
                {
                    // problème
                    MessageBox.Show("Problème à l'écriture du fichier (" +
                    ex.Message + ")", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    // on ferme le fichier
                    if (fichier != null)
                    {
                        fichier.Dispose();
                    }
                }
            }
        }

        private void Bnt_color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void bnt_font_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font; 
        }

        private void bnt_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
