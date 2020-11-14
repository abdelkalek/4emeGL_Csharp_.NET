namespace Timer
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
            this.Lbl_Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bnt_start = new System.Windows.Forms.Button();
            this.bnt_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Timer
            // 
            this.Lbl_Timer.AutoSize = true;
            this.Lbl_Timer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Timer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Lbl_Timer.Location = new System.Drawing.Point(75, 86);
            this.Lbl_Timer.Name = "Lbl_Timer";
            this.Lbl_Timer.Size = new System.Drawing.Size(54, 24);
            this.Lbl_Timer.TabIndex = 0;
            this.Lbl_Timer.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bnt_start
            // 
            this.bnt_start.Location = new System.Drawing.Point(54, 174);
            this.bnt_start.Name = "bnt_start";
            this.bnt_start.Size = new System.Drawing.Size(75, 23);
            this.bnt_start.TabIndex = 1;
            this.bnt_start.Text = "Start";
            this.bnt_start.UseVisualStyleBackColor = true;
            this.bnt_start.Click += new System.EventHandler(this.bnt_start_Click);
            // 
            // bnt_stop
            // 
            this.bnt_stop.Location = new System.Drawing.Point(150, 174);
            this.bnt_stop.Name = "bnt_stop";
            this.bnt_stop.Size = new System.Drawing.Size(75, 23);
            this.bnt_stop.TabIndex = 2;
            this.bnt_stop.Text = "stop";
            this.bnt_stop.UseVisualStyleBackColor = true;
            this.bnt_stop.Click += new System.EventHandler(this.bnt_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bnt_stop);
            this.Controls.Add(this.bnt_start);
            this.Controls.Add(this.Lbl_Timer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bnt_start;
        private System.Windows.Forms.Button bnt_stop;
    }
}

