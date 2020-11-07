namespace Exe7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_munis = new System.Windows.Forms.TextBox();
            this.Majus = new System.Windows.Forms.TextBox();
            this.Txt_alphabetique = new System.Windows.Forms.TextBox();
            this.Txt_decimale = new System.Windows.Forms.TextBox();
            this.Txt_numerique = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Alpha = new System.Windows.Forms.TextBox();
            this.txt_Numerique2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.IP_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Email_errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email_errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Txt_munis);
            this.groupBox1.Controls.Add(this.Majus);
            this.groupBox1.Controls.Add(this.Txt_alphabetique);
            this.groupBox1.Controls.Add(this.Txt_decimale);
            this.groupBox1.Controls.Add(this.Txt_numerique);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validation key press";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "TextBox alphabetique muniscule";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "TextBox alphabetique majuscule";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tester champs vides";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_munis
            // 
            this.Txt_munis.Location = new System.Drawing.Point(190, 144);
            this.Txt_munis.Name = "Txt_munis";
            this.Txt_munis.Size = new System.Drawing.Size(100, 20);
            this.Txt_munis.TabIndex = 9;
            this.Txt_munis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_munis_KeyPress);
            // 
            // Majus
            // 
            this.Majus.Location = new System.Drawing.Point(190, 113);
            this.Majus.Name = "Majus";
            this.Majus.Size = new System.Drawing.Size(100, 20);
            this.Majus.TabIndex = 8;
            this.Majus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Majus_KeyPress);
            // 
            // Txt_alphabetique
            // 
            this.Txt_alphabetique.Location = new System.Drawing.Point(190, 82);
            this.Txt_alphabetique.Name = "Txt_alphabetique";
            this.Txt_alphabetique.Size = new System.Drawing.Size(100, 20);
            this.Txt_alphabetique.TabIndex = 7;
            this.Txt_alphabetique.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_alphabetique_KeyPress);
            // 
            // Txt_decimale
            // 
            this.Txt_decimale.Location = new System.Drawing.Point(190, 51);
            this.Txt_decimale.Name = "Txt_decimale";
            this.Txt_decimale.Size = new System.Drawing.Size(100, 20);
            this.Txt_decimale.TabIndex = 6;
            this.Txt_decimale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_decimale_KeyPress);
            // 
            // Txt_numerique
            // 
            this.Txt_numerique.Location = new System.Drawing.Point(190, 20);
            this.Txt_numerique.Name = "Txt_numerique";
            this.Txt_numerique.Size = new System.Drawing.Size(100, 20);
            this.Txt_numerique.TabIndex = 5;
            this.Txt_numerique.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_numerique_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TextBox alphabetique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TextBox Numerique decimale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TextBox Numerique";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Txt_Alpha);
            this.groupBox2.Controls.Add(this.txt_Numerique2);
            this.groupBox2.Location = new System.Drawing.Point(12, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 108);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "validation text change";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "TextBox alphabetique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "TextBox Numerique";
            // 
            // Txt_Alpha
            // 
            this.Txt_Alpha.Location = new System.Drawing.Point(143, 67);
            this.Txt_Alpha.Name = "Txt_Alpha";
            this.Txt_Alpha.Size = new System.Drawing.Size(100, 20);
            this.Txt_Alpha.TabIndex = 6;
            this.Txt_Alpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Alpha_KeyPress);
            // 
            // txt_Numerique2
            // 
            this.txt_Numerique2.Location = new System.Drawing.Point(143, 36);
            this.txt_Numerique2.Name = "txt_Numerique2";
            this.txt_Numerique2.Size = new System.Drawing.Size(100, 20);
            this.txt_Numerique2.TabIndex = 5;
            this.txt_Numerique2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Numerique2_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 93);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regex Mask text";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(143, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 8;
            this.textBox8.Validating += new System.ComponentModel.CancelEventHandler(this.textBox8_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "address email";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(143, 66);
            this.textBox6.MaxLength = 20;
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '$';
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 6;
            this.textBox6.UseSystemPasswordChar = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(143, 39);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 5;
            this.textBox7.Validating += new System.ComponentModel.CancelEventHandler(this.textBox7_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "adress ip";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // IP_errorProvider
            // 
            this.IP_errorProvider.ContainerControl = this;
            // 
            // Email_errorProvider3
            // 
            this.Email_errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IP_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email_errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_munis;
        private System.Windows.Forms.TextBox Majus;
        private System.Windows.Forms.TextBox Txt_alphabetique;
        private System.Windows.Forms.TextBox Txt_decimale;
        private System.Windows.Forms.TextBox Txt_numerique;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_Alpha;
        private System.Windows.Forms.TextBox txt_Numerique2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider IP_errorProvider;
        private System.Windows.Forms.ErrorProvider Email_errorProvider3;
    }
}

