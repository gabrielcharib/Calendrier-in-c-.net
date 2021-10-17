namespace Calendrier
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
            this.labelMoisEnCours = new System.Windows.Forms.Label();
            this.btNext = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.btPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMoisEnCours
            // 
            this.labelMoisEnCours.AutoSize = true;
            this.labelMoisEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelMoisEnCours.Location = new System.Drawing.Point(301, 25);
            this.labelMoisEnCours.Name = "labelMoisEnCours";
            this.labelMoisEnCours.Size = new System.Drawing.Size(90, 13);
            this.labelMoisEnCours.TabIndex = 0;
            this.labelMoisEnCours.Text = "Le mois en cours:";
            this.labelMoisEnCours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(634, 254);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(84, 43);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Suivant >";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(279, 518);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(127, 43);
            this.btQuit.TabIndex = 3;
            this.btQuit.Text = "Quitter";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btPrevious
            // 
            this.btPrevious.Location = new System.Drawing.Point(10, 254);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(91, 43);
            this.btPrevious.TabIndex = 4;
            this.btPrevious.Text = "< Précédent";
            this.btPrevious.UseVisualStyleBackColor = true;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 588);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.labelMoisEnCours);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Calendrier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoisEnCours;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btPrevious;
    }
}

