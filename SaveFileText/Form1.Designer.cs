namespace SaveFileText
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
            this.Txt_Text = new System.Windows.Forms.TextBox();
            this.Bnt_save = new System.Windows.Forms.Button();
            this.bnt_load = new System.Windows.Forms.Button();
            this.Bnt_clear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Txt_Text
            // 
            this.Txt_Text.Location = new System.Drawing.Point(12, 12);
            this.Txt_Text.Multiline = true;
            this.Txt_Text.Name = "Txt_Text";
            this.Txt_Text.Size = new System.Drawing.Size(552, 179);
            this.Txt_Text.TabIndex = 0;
            // 
            // Bnt_save
            // 
            this.Bnt_save.Location = new System.Drawing.Point(12, 217);
            this.Bnt_save.Name = "Bnt_save";
            this.Bnt_save.Size = new System.Drawing.Size(75, 23);
            this.Bnt_save.TabIndex = 1;
            this.Bnt_save.Text = "Save";
            this.Bnt_save.UseVisualStyleBackColor = true;
            // 
            // bnt_load
            // 
            this.bnt_load.Location = new System.Drawing.Point(117, 217);
            this.bnt_load.Name = "bnt_load";
            this.bnt_load.Size = new System.Drawing.Size(75, 23);
            this.bnt_load.TabIndex = 2;
            this.bnt_load.Text = "Load";
            this.bnt_load.UseVisualStyleBackColor = true;
            this.bnt_load.Click += new System.EventHandler(this.bnt_load_Click);
            // 
            // Bnt_clear
            // 
            this.Bnt_clear.Location = new System.Drawing.Point(218, 217);
            this.Bnt_clear.Name = "Bnt_clear";
            this.Bnt_clear.Size = new System.Drawing.Size(75, 23);
            this.Bnt_clear.TabIndex = 3;
            this.Bnt_clear.Text = "Clear";
            this.Bnt_clear.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 294);
            this.Controls.Add(this.Bnt_clear);
            this.Controls.Add(this.bnt_load);
            this.Controls.Add(this.Bnt_save);
            this.Controls.Add(this.Txt_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Text;
        private System.Windows.Forms.Button Bnt_save;
        private System.Windows.Forms.Button bnt_load;
        private System.Windows.Forms.Button Bnt_clear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

