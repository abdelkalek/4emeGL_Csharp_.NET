namespace gestion
{
    partial class AjouterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterForm));
            this.Bnt_ajouter = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.txt_rue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bnt_ajouter
            // 
            this.Bnt_ajouter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bnt_ajouter.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_ajouter.ForeColor = System.Drawing.SystemColors.Info;
            this.Bnt_ajouter.Location = new System.Drawing.Point(50, 259);
            this.Bnt_ajouter.Name = "Bnt_ajouter";
            this.Bnt_ajouter.Size = new System.Drawing.Size(212, 44);
            this.Bnt_ajouter.TabIndex = 0;
            this.Bnt_ajouter.Text = "Ajouter";
            this.Bnt_ajouter.UseVisualStyleBackColor = false;
            this.Bnt_ajouter.Click += new System.EventHandler(this.Bnt_ajouter_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(178, 41);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 1;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(178, 73);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 2;
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(178, 105);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(100, 20);
            this.txt_ville.TabIndex = 3;
            // 
            // txt_rue
            // 
            this.txt_rue.Location = new System.Drawing.Point(178, 135);
            this.txt_rue.Name = "txt_rue";
            this.txt_rue.Size = new System.Drawing.Size(100, 20);
            this.txt_rue.TabIndex = 4;
            this.txt_rue.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero Client";
            // 
            // txt_cp
            // 
            this.txt_cp.Location = new System.Drawing.Point(178, 167);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(100, 20);
            this.txt_cp.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Code postale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "telephone";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(178, 199);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 12;
            // 
            // AjouterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 370);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_rue);
            this.Controls.Add(this.txt_ville);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.Bnt_ajouter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterForm";
            this.Text = "AjouterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bnt_ajouter;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.TextBox txt_rue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tel;
    }
}