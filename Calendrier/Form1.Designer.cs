
namespace Calendrier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrécedent = new System.Windows.Forms.Button();
            this.buttonQuiter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMoisEnCours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPrécedent
            // 
            this.buttonPrécedent.Location = new System.Drawing.Point(11, 205);
            this.buttonPrécedent.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonPrécedent.Name = "buttonPrécedent";
            this.buttonPrécedent.Size = new System.Drawing.Size(81, 22);
            this.buttonPrécedent.TabIndex = 0;
            this.buttonPrécedent.Text = "< Précedent";
            this.buttonPrécedent.UseVisualStyleBackColor = true;
            this.buttonPrécedent.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonQuiter
            // 
            this.buttonQuiter.Location = new System.Drawing.Point(282, 398);
            this.buttonQuiter.Name = "buttonQuiter";
            this.buttonQuiter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuiter.TabIndex = 1;
            this.buttonQuiter.Text = "Quitter";
            this.buttonQuiter.UseVisualStyleBackColor = true;
            this.buttonQuiter.Click += new System.EventHandler(this.buttonQuiter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Suivant >";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelMoisEnCours
            // 
            this.labelMoisEnCours.AutoSize = true;
            this.labelMoisEnCours.Location = new System.Drawing.Point(255, 9);
            this.labelMoisEnCours.Name = "labelMoisEnCours";
            this.labelMoisEnCours.Size = new System.Drawing.Size(81, 15);
            this.labelMoisEnCours.TabIndex = 3;
            this.labelMoisEnCours.Text = "mois en cours";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 447);
            this.Controls.Add(this.labelMoisEnCours);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonQuiter);
            this.Controls.Add(this.buttonPrécedent);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrécedent;
        private System.Windows.Forms.Button buttonQuiter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMoisEnCours;
    }
}

