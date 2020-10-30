namespace Exe6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonRadio3 = new System.Windows.Forms.RadioButton();
            this.ButtonRadio2 = new System.Windows.Forms.RadioButton();
            this.ButtonRadio1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonRadio3);
            this.groupBox1.Controls.Add(this.ButtonRadio2);
            this.groupBox1.Controls.Add(this.ButtonRadio1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boutton Radio";
            // 
            // ButtonRadio3
            // 
            this.ButtonRadio3.AutoSize = true;
            this.ButtonRadio3.Location = new System.Drawing.Point(119, 32);
            this.ButtonRadio3.Name = "ButtonRadio3";
            this.ButtonRadio3.Size = new System.Drawing.Size(31, 17);
            this.ButtonRadio3.TabIndex = 2;
            this.ButtonRadio3.TabStop = true;
            this.ButtonRadio3.Text = "3";
            this.ButtonRadio3.UseVisualStyleBackColor = true;
            this.ButtonRadio3.Click += new System.EventHandler(this.R3_Click);
            // 
            // ButtonRadio2
            // 
            this.ButtonRadio2.AutoSize = true;
            this.ButtonRadio2.Location = new System.Drawing.Point(64, 32);
            this.ButtonRadio2.Name = "ButtonRadio2";
            this.ButtonRadio2.Size = new System.Drawing.Size(31, 17);
            this.ButtonRadio2.TabIndex = 1;
            this.ButtonRadio2.TabStop = true;
            this.ButtonRadio2.Text = "2";
            this.ButtonRadio2.UseVisualStyleBackColor = true;
            this.ButtonRadio2.Click += new System.EventHandler(this.R3_Click);
            // 
            // ButtonRadio1
            // 
            this.ButtonRadio1.AutoSize = true;
            this.ButtonRadio1.Location = new System.Drawing.Point(18, 32);
            this.ButtonRadio1.Name = "ButtonRadio1";
            this.ButtonRadio1.Size = new System.Drawing.Size(31, 17);
            this.ButtonRadio1.TabIndex = 0;
            this.ButtonRadio1.TabStop = true;
            this.ButtonRadio1.Text = "1";
            this.ButtonRadio1.UseVisualStyleBackColor = true;
            this.ButtonRadio1.Click += new System.EventHandler(this.R3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckBox3);
            this.groupBox2.Controls.Add(this.CheckBox2);
            this.groupBox2.Controls.Add(this.CheckBox1);
            this.groupBox2.Location = new System.Drawing.Point(200, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Case a cocher";
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(86, 32);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(33, 17);
            this.CheckBox3.TabIndex = 2;
            this.CheckBox3.Text = "C";
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox3.Click += new System.EventHandler(this.R3_Click);
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(46, 32);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(33, 17);
            this.CheckBox2.TabIndex = 1;
            this.CheckBox2.Text = "B";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.Click += new System.EventHandler(this.R3_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(6, 32);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(33, 17);
            this.CheckBox1.TabIndex = 0;
            this.CheckBox1.Text = "A";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.Click += new System.EventHandler(this.R3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 108);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Case a cocher et button radio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ButtonRadio3;
        private System.Windows.Forms.RadioButton ButtonRadio2;
        private System.Windows.Forms.RadioButton ButtonRadio1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CheckBox3;
        private System.Windows.Forms.CheckBox CheckBox2;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

