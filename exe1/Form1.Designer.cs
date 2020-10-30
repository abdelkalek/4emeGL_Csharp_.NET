namespace exe1
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
            this.Bnt_Bonjour = new System.Windows.Forms.Button();
            this.Txt_nomPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bnt_Bonjour
            // 
            this.Bnt_Bonjour.Location = new System.Drawing.Point(75, 101);
            this.Bnt_Bonjour.Name = "Bnt_Bonjour";
            this.Bnt_Bonjour.Size = new System.Drawing.Size(110, 40);
            this.Bnt_Bonjour.TabIndex = 0;
            this.Bnt_Bonjour.Text = "Bonjour";
            this.Bnt_Bonjour.UseVisualStyleBackColor = true;
            this.Bnt_Bonjour.Click += new System.EventHandler(this.Bnt_Bonjour_Click);
            // 
            // Txt_nomPrenom
            // 
            this.Txt_nomPrenom.Location = new System.Drawing.Point(122, 42);
            this.Txt_nomPrenom.Name = "Txt_nomPrenom";
            this.Txt_nomPrenom.Size = new System.Drawing.Size(129, 20);
            this.Txt_nomPrenom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "nom et prenom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_nomPrenom);
            this.Controls.Add(this.Bnt_Bonjour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bnt_Bonjour;
        private System.Windows.Forms.TextBox Txt_nomPrenom;
        private System.Windows.Forms.Label label1;
    }
}

