namespace Exe5
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bnt_Ajouter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Saisie = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_liste2 = new System.Windows.Forms.Button();
            this.bnt_liste1 = new System.Windows.Forms.Button();
            this.Bnt_supp_list1 = new System.Windows.Forms.Button();
            this.Bnt_supp_list2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bnt_Ajouter
            // 
            this.Bnt_Ajouter.Location = new System.Drawing.Point(273, 45);
            this.Bnt_Ajouter.Name = "Bnt_Ajouter";
            this.Bnt_Ajouter.Size = new System.Drawing.Size(152, 23);
            this.Bnt_Ajouter.TabIndex = 0;
            this.Bnt_Ajouter.Text = "Ajouter";
            this.Bnt_Ajouter.UseVisualStyleBackColor = true;
            this.Bnt_Ajouter.Click += new System.EventHandler(this.Bnt_Ajouter_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(75, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tapez un texte pour l\'inclure dans la liste 1 ";
            // 
            // Txt_Saisie
            // 
            this.Txt_Saisie.Location = new System.Drawing.Point(75, 45);
            this.Txt_Saisie.Name = "Txt_Saisie";
            this.Txt_Saisie.Size = new System.Drawing.Size(169, 20);
            this.Txt_Saisie.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(315, 103);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saisie";
            // 
            // bnt_liste2
            // 
            this.bnt_liste2.Location = new System.Drawing.Point(216, 119);
            this.bnt_liste2.Name = "bnt_liste2";
            this.bnt_liste2.Size = new System.Drawing.Size(75, 23);
            this.bnt_liste2.TabIndex = 6;
            this.bnt_liste2.Text = "-->";
            this.bnt_liste2.UseVisualStyleBackColor = true;
            this.bnt_liste2.Click += new System.EventHandler(this.bnt_liste2_Click);
            // 
            // bnt_liste1
            // 
            this.bnt_liste1.Location = new System.Drawing.Point(216, 160);
            this.bnt_liste1.Name = "bnt_liste1";
            this.bnt_liste1.Size = new System.Drawing.Size(75, 23);
            this.bnt_liste1.TabIndex = 7;
            this.bnt_liste1.Text = "<--";
            this.bnt_liste1.UseVisualStyleBackColor = true;
            this.bnt_liste1.Click += new System.EventHandler(this.bnt_liste1_Click);
            // 
            // Bnt_supp_list1
            // 
            this.Bnt_supp_list1.Location = new System.Drawing.Point(100, 213);
            this.Bnt_supp_list1.Name = "Bnt_supp_list1";
            this.Bnt_supp_list1.Size = new System.Drawing.Size(75, 23);
            this.Bnt_supp_list1.TabIndex = 8;
            this.Bnt_supp_list1.Text = "Effacer";
            this.Bnt_supp_list1.UseVisualStyleBackColor = true;
            this.Bnt_supp_list1.Click += new System.EventHandler(this.Bnt_supp_list1_Click);
            // 
            // Bnt_supp_list2
            // 
            this.Bnt_supp_list2.Location = new System.Drawing.Point(330, 213);
            this.Bnt_supp_list2.Name = "Bnt_supp_list2";
            this.Bnt_supp_list2.Size = new System.Drawing.Size(75, 23);
            this.Bnt_supp_list2.TabIndex = 9;
            this.Bnt_supp_list2.Text = "Effacer";
            this.Bnt_supp_list2.UseVisualStyleBackColor = true;
            this.Bnt_supp_list2.Click += new System.EventHandler(this.Bnt_supp_list2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 261);
            this.Controls.Add(this.Bnt_supp_list2);
            this.Controls.Add(this.Bnt_supp_list1);
            this.Controls.Add(this.bnt_liste1);
            this.Controls.Add(this.bnt_liste2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Txt_Saisie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Bnt_Ajouter);
            this.Name = "Form1";
            this.Text = "ListeBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bnt_Ajouter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Saisie;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnt_liste2;
        private System.Windows.Forms.Button bnt_liste1;
        private System.Windows.Forms.Button Bnt_supp_list1;
        private System.Windows.Forms.Button Bnt_supp_list2;
    }
}

