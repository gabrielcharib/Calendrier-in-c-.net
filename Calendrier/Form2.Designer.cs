
namespace Calendrier
{
    partial class Form2
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
            this.labeRdv = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.buttonEnregistre = new System.Windows.Forms.Button();
            this.buttonQuiter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeRdv
            // 
            this.labeRdv.AutoSize = true;
            this.labeRdv.Location = new System.Drawing.Point(334, 31);
            this.labeRdv.Name = "labeRdv";
            this.labeRdv.Size = new System.Drawing.Size(29, 15);
            this.labeRdv.TabIndex = 0;
            this.labeRdv.Text = "RDV";
            this.labeRdv.Click += new System.EventHandler(this.label1_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(186, 81);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(348, 203);
            this.text.TabIndex = 1;
            // 
            // buttonEnregistre
            // 
            this.buttonEnregistre.Location = new System.Drawing.Point(186, 397);
            this.buttonEnregistre.Name = "buttonEnregistre";
            this.buttonEnregistre.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistre.TabIndex = 2;
            this.buttonEnregistre.Text = "Enregistre";
            this.buttonEnregistre.UseVisualStyleBackColor = true;
            this.buttonEnregistre.Click += new System.EventHandler(this.buttonEnregistre_Click);
            // 
            // buttonQuiter
            // 
            this.buttonQuiter.Location = new System.Drawing.Point(458, 397);
            this.buttonQuiter.Name = "buttonQuiter";
            this.buttonQuiter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuiter.TabIndex = 3;
            this.buttonQuiter.Text = "Quiter";
            this.buttonQuiter.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuiter);
            this.Controls.Add(this.buttonEnregistre);
            this.Controls.Add(this.text);
            this.Controls.Add(this.labeRdv);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeRdv;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button buttonEnregistre;
        private System.Windows.Forms.Button buttonQuiter;
    }
}