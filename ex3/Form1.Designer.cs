namespace ex3
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
            this.Bnt_Quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bnt_Quitter
            // 
            this.Bnt_Quitter.Location = new System.Drawing.Point(29, 61);
            this.Bnt_Quitter.Name = "Bnt_Quitter";
            this.Bnt_Quitter.Size = new System.Drawing.Size(199, 54);
            this.Bnt_Quitter.TabIndex = 0;
            this.Bnt_Quitter.Text = "Quitter";
            this.Bnt_Quitter.UseVisualStyleBackColor = true;
            this.Bnt_Quitter.Click += new System.EventHandler(this.Bnt_Quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Bnt_Quitter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bnt_Quitter;
    }
}

