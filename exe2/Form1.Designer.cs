namespace exe2
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
            this.Lbb_nom = new System.Windows.Forms.Label();
            this.Txt_Nom = new System.Windows.Forms.TextBox();
            this.Txt_List = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bnt_Ajouter
            // 
            this.Bnt_Ajouter.Location = new System.Drawing.Point(78, 66);
            this.Bnt_Ajouter.Name = "Bnt_Ajouter";
            this.Bnt_Ajouter.Size = new System.Drawing.Size(100, 23);
            this.Bnt_Ajouter.TabIndex = 0;
            this.Bnt_Ajouter.Text = "Ajouter";
            this.Bnt_Ajouter.UseVisualStyleBackColor = true;
            this.Bnt_Ajouter.Click += new System.EventHandler(this.Bnt_Ajouter_Click);
            // 
            // Lbb_nom
            // 
            this.Lbb_nom.AutoSize = true;
            this.Lbb_nom.Location = new System.Drawing.Point(13, 36);
            this.Lbb_nom.Name = "Lbb_nom";
            this.Lbb_nom.Size = new System.Drawing.Size(26, 13);
            this.Lbb_nom.TabIndex = 1;
            this.Lbb_nom.Text = "LBL";
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.Location = new System.Drawing.Point(78, 28);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nom.TabIndex = 2;
            // 
            // Txt_List
            // 
            this.Txt_List.Location = new System.Drawing.Point(78, 95);
            this.Txt_List.Multiline = true;
            this.Txt_List.Name = "Txt_List";
            this.Txt_List.Size = new System.Drawing.Size(100, 93);
            this.Txt_List.TabIndex = 3;
            // 
            // Close
            // 
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.Location = new System.Drawing.Point(78, 194);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 35);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.Bnt_Ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Close;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Txt_List);
            this.Controls.Add(this.Txt_Nom);
            this.Controls.Add(this.Lbb_nom);
            this.Controls.Add(this.Bnt_Ajouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bnt_Ajouter;
        private System.Windows.Forms.Label Lbb_nom;
        private System.Windows.Forms.TextBox Txt_Nom;
        private System.Windows.Forms.TextBox Txt_List;
        private System.Windows.Forms.Button Close;
    }
}

