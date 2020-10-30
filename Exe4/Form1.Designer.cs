namespace Exe4
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Bnt_Ajouter = new System.Windows.Forms.Button();
            this.Txt_text = new System.Windows.Forms.TextBox();
            this.Bnt_supp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // Bnt_Ajouter
            // 
            this.Bnt_Ajouter.Location = new System.Drawing.Point(23, 155);
            this.Bnt_Ajouter.Name = "Bnt_Ajouter";
            this.Bnt_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Bnt_Ajouter.TabIndex = 1;
            this.Bnt_Ajouter.Text = "Ajouter";
            this.Bnt_Ajouter.UseVisualStyleBackColor = true;
            this.Bnt_Ajouter.Click += new System.EventHandler(this.Bnt_Ajouter_Click);
            // 
            // Txt_text
            // 
            this.Txt_text.Location = new System.Drawing.Point(22, 99);
            this.Txt_text.Name = "Txt_text";
            this.Txt_text.Size = new System.Drawing.Size(100, 20);
            this.Txt_text.TabIndex = 2;
            // 
            // Bnt_supp
            // 
            this.Bnt_supp.Location = new System.Drawing.Point(114, 155);
            this.Bnt_supp.Name = "Bnt_supp";
            this.Bnt_supp.Size = new System.Drawing.Size(75, 23);
            this.Bnt_supp.TabIndex = 3;
            this.Bnt_supp.Text = "supprimer";
            this.Bnt_supp.UseVisualStyleBackColor = true;
            this.Bnt_supp.Click += new System.EventHandler(this.Bnt_supp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Bnt_supp);
            this.Controls.Add(this.Txt_text);
            this.Controls.Add(this.Bnt_Ajouter);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Bnt_Ajouter;
        private System.Windows.Forms.TextBox Txt_text;
        private System.Windows.Forms.Button Bnt_supp;
    }
}

