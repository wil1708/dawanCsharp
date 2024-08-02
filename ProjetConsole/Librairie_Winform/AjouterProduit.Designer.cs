
namespace Librairie_Winform
{
    partial class AjouterProduit
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
            this.txtAjouterProduit = new System.Windows.Forms.Label();
            this.txtAjouterProd = new System.Windows.Forms.TextBox();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAjouterProduit
            // 
            this.txtAjouterProduit.AutoSize = true;
            this.txtAjouterProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAjouterProduit.Location = new System.Drawing.Point(125, 59);
            this.txtAjouterProduit.Name = "txtAjouterProduit";
            this.txtAjouterProduit.Size = new System.Drawing.Size(93, 13);
            this.txtAjouterProduit.TabIndex = 0;
            this.txtAjouterProduit.Text = "Nom du produit";
            // 
            // txtAjouterProd
            // 
            this.txtAjouterProd.Location = new System.Drawing.Point(227, 56);
            this.txtAjouterProd.Name = "txtAjouterProd";
            this.txtAjouterProd.Size = new System.Drawing.Size(169, 20);
            this.txtAjouterProd.TabIndex = 1;
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterProduit.Location = new System.Drawing.Point(432, 56);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterProduit.TabIndex = 2;
            this.btnAjouterProduit.Text = "Ajouter";
            this.btnAjouterProduit.UseVisualStyleBackColor = true;
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouterProduit_Click);
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 166);
            this.Controls.Add(this.btnAjouterProduit);
            this.Controls.Add(this.txtAjouterProd);
            this.Controls.Add(this.txtAjouterProduit);
            this.Name = "AjouterProduit";
            this.Text = "AjouterProduit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAjouterProduit;
        private System.Windows.Forms.TextBox txtAjouterProd;
        private System.Windows.Forms.Button btnAjouterProduit;
    }
}