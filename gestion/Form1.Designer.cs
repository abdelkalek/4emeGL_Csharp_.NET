namespace gestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Supprimer_Bnt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Modifier_BNT = new System.Windows.Forms.Button();
            this.Ajouter_BNT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_chercher = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridClient);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 278);
            this.panel1.TabIndex = 0;
            // 
            // dataGridClient
            // 
            this.dataGridClient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClient.Location = new System.Drawing.Point(0, 0);
            this.dataGridClient.Name = "dataGridClient";
            this.dataGridClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClient.Size = new System.Drawing.Size(640, 278);
            this.dataGridClient.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Num Client";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom Client";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ville";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Rue";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Code Postale";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tel";
            this.Column6.Name = "Column6";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.Supprimer_Bnt);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Modifier_BNT);
            this.panel2.Controls.Add(this.Ajouter_BNT);
            this.panel2.Location = new System.Drawing.Point(658, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 278);
            this.panel2.TabIndex = 1;
            // 
            // Supprimer_Bnt
            // 
            this.Supprimer_Bnt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Supprimer_Bnt.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer_Bnt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Supprimer_Bnt.Image = ((System.Drawing.Image)(resources.GetObject("Supprimer_Bnt.Image")));
            this.Supprimer_Bnt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Supprimer_Bnt.Location = new System.Drawing.Point(3, 110);
            this.Supprimer_Bnt.Name = "Supprimer_Bnt";
            this.Supprimer_Bnt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Supprimer_Bnt.Size = new System.Drawing.Size(122, 48);
            this.Supprimer_Bnt.TabIndex = 3;
            this.Supprimer_Bnt.Text = "Supprimer";
            this.Supprimer_Bnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Supprimer_Bnt.UseVisualStyleBackColor = false;
            this.Supprimer_Bnt.Click += new System.EventHandler(this.Supprimer_Bnt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(3, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quitter";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modifier_BNT
            // 
            this.Modifier_BNT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Modifier_BNT.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier_BNT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Modifier_BNT.Image = ((System.Drawing.Image)(resources.GetObject("Modifier_BNT.Image")));
            this.Modifier_BNT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modifier_BNT.Location = new System.Drawing.Point(3, 56);
            this.Modifier_BNT.Name = "Modifier_BNT";
            this.Modifier_BNT.Size = new System.Drawing.Size(122, 48);
            this.Modifier_BNT.TabIndex = 1;
            this.Modifier_BNT.Text = "Modifier";
            this.Modifier_BNT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modifier_BNT.UseVisualStyleBackColor = false;
            this.Modifier_BNT.Click += new System.EventHandler(this.Modifier_BNT_Click);
            // 
            // Ajouter_BNT
            // 
            this.Ajouter_BNT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Ajouter_BNT.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter_BNT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ajouter_BNT.Image = ((System.Drawing.Image)(resources.GetObject("Ajouter_BNT.Image")));
            this.Ajouter_BNT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ajouter_BNT.Location = new System.Drawing.Point(3, 3);
            this.Ajouter_BNT.Name = "Ajouter_BNT";
            this.Ajouter_BNT.Size = new System.Drawing.Size(122, 47);
            this.Ajouter_BNT.TabIndex = 0;
            this.Ajouter_BNT.Text = "Ajouter";
            this.Ajouter_BNT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajouter_BNT.UseVisualStyleBackColor = false;
            this.Ajouter_BNT.Click += new System.EventHandler(this.Ajouter_BNT_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Txt_chercher);
            this.panel3.Location = new System.Drawing.Point(12, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 55);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chercher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_chercher
            // 
            this.Txt_chercher.Location = new System.Drawing.Point(168, 23);
            this.Txt_chercher.Name = "Txt_chercher";
            this.Txt_chercher.Size = new System.Drawing.Size(150, 20);
            this.Txt_chercher.TabIndex = 0;
            this.Txt_chercher.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(793, 356);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestion des Clients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.button1_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Ajouter_BNT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Modifier_BNT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Supprimer_Bnt;
        private System.Windows.Forms.TextBox Txt_chercher;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

