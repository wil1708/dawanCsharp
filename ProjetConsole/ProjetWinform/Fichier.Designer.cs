
namespace ProjetWinform
{
    partial class Fichier
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
            this.txtEcriture = new System.Windows.Forms.TextBox();
            this.txtLecture = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtEcriture
            // 
            this.txtEcriture.Location = new System.Drawing.Point(52, 35);
            this.txtEcriture.Multiline = true;
            this.txtEcriture.Name = "txtEcriture";
            this.txtEcriture.Size = new System.Drawing.Size(362, 228);
            this.txtEcriture.TabIndex = 0;
            // 
            // txtLecture
            // 
            this.txtLecture.Enabled = false;
            this.txtLecture.Location = new System.Drawing.Point(52, 335);
            this.txtLecture.Multiline = true;
            this.txtLecture.Name = "txtLecture";
            this.txtLecture.Size = new System.Drawing.Size(362, 228);
            this.txtLecture.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ecrire dans un fichier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 88);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lecture dans un fichier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Fichier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 728);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLecture);
            this.Controls.Add(this.txtEcriture);
            this.Name = "Fichier";
            this.Text = "Fichier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEcriture;
        private System.Windows.Forms.TextBox txtLecture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}