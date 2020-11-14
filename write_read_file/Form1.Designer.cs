namespace write_read_file
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bnt_save = new System.Windows.Forms.Button();
            this.bnt_load = new System.Windows.Forms.Button();
            this.bnt_clear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Bnt_color = new System.Windows.Forms.Button();
            this.bnt_font = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 207);
            this.textBox1.TabIndex = 0;
            // 
            // bnt_save
            // 
            this.bnt_save.Location = new System.Drawing.Point(205, 258);
            this.bnt_save.Name = "bnt_save";
            this.bnt_save.Size = new System.Drawing.Size(75, 23);
            this.bnt_save.TabIndex = 1;
            this.bnt_save.Text = "Save";
            this.bnt_save.UseVisualStyleBackColor = true;
            this.bnt_save.Click += new System.EventHandler(this.bnt_save_Click);
            // 
            // bnt_load
            // 
            this.bnt_load.Location = new System.Drawing.Point(296, 258);
            this.bnt_load.Name = "bnt_load";
            this.bnt_load.Size = new System.Drawing.Size(75, 23);
            this.bnt_load.TabIndex = 2;
            this.bnt_load.Text = "Load";
            this.bnt_load.UseVisualStyleBackColor = true;
            this.bnt_load.Click += new System.EventHandler(this.bnt_load_Click);
            // 
            // bnt_clear
            // 
            this.bnt_clear.Location = new System.Drawing.Point(410, 257);
            this.bnt_clear.Name = "bnt_clear";
            this.bnt_clear.Size = new System.Drawing.Size(75, 23);
            this.bnt_clear.TabIndex = 3;
            this.bnt_clear.Text = "Clear";
            this.bnt_clear.UseVisualStyleBackColor = true;
            this.bnt_clear.Click += new System.EventHandler(this.bnt_clear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bnt_color
            // 
            this.Bnt_color.Location = new System.Drawing.Point(28, 294);
            this.Bnt_color.Name = "Bnt_color";
            this.Bnt_color.Size = new System.Drawing.Size(75, 23);
            this.Bnt_color.TabIndex = 4;
            this.Bnt_color.Text = "color";
            this.Bnt_color.UseVisualStyleBackColor = true;
            this.Bnt_color.Click += new System.EventHandler(this.Bnt_color_Click);
            // 
            // bnt_font
            // 
            this.bnt_font.Location = new System.Drawing.Point(132, 294);
            this.bnt_font.Name = "bnt_font";
            this.bnt_font.Size = new System.Drawing.Size(75, 23);
            this.bnt_font.TabIndex = 5;
            this.bnt_font.Text = "font";
            this.bnt_font.UseVisualStyleBackColor = true;
            this.bnt_font.Click += new System.EventHandler(this.bnt_font_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 329);
            this.Controls.Add(this.bnt_font);
            this.Controls.Add(this.Bnt_color);
            this.Controls.Add(this.bnt_clear);
            this.Controls.Add(this.bnt_load);
            this.Controls.Add(this.bnt_save);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bnt_save;
        private System.Windows.Forms.Button bnt_load;
        private System.Windows.Forms.Button bnt_clear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Bnt_color;
        private System.Windows.Forms.Button bnt_font;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

