
namespace Librairie_Winform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProduit = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProduit = new System.Windows.Forms.ComboBox();
            this.btnNouveauProduit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMontantTotal = new System.Windows.Forms.Label();
            this.lblNombreProduit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstMontant = new System.Windows.Forms.ListBox();
            this.lstAchat = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreProduit);
            this.panel1.Controls.Add(this.txtPrix);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbProduit);
            this.panel1.Location = new System.Drawing.Point(136, 151);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 365);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Porduit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prix Unitaire";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombreProduit
            // 
            this.txtNombreProduit.Location = new System.Drawing.Point(21, 278);
            this.txtNombreProduit.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProduit.Name = "txtNombreProduit";
            this.txtNombreProduit.Size = new System.Drawing.Size(137, 24);
            this.txtNombreProduit.TabIndex = 2;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(21, 169);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(137, 24);
            this.txtPrix.TabIndex = 2;
            this.txtPrix.TextChanged += new System.EventHandler(this.txtPrix_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisir le produit";
            // 
            // cmbProduit
            // 
            this.cmbProduit.FormattingEnabled = true;
            this.cmbProduit.Items.AddRange(new object[] {
            "Stylo",
            "Cahier",
            "Crayon",
            "Gomme"});
            this.cmbProduit.Location = new System.Drawing.Point(21, 58);
            this.cmbProduit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProduit.Name = "cmbProduit";
            this.cmbProduit.Size = new System.Drawing.Size(137, 26);
            this.cmbProduit.TabIndex = 0;
            this.cmbProduit.SelectedIndexChanged += new System.EventHandler(this.cmbProduit_SelectedIndexChanged);
            // 
            // btnNouveauProduit
            // 
            this.btnNouveauProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveauProduit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNouveauProduit.Location = new System.Drawing.Point(136, 109);
            this.btnNouveauProduit.Name = "btnNouveauProduit";
            this.btnNouveauProduit.Size = new System.Drawing.Size(192, 28);
            this.btnNouveauProduit.TabIndex = 1;
            this.btnNouveauProduit.Text = "Nouveau Produit";
            this.btnNouveauProduit.UseVisualStyleBackColor = true;
            this.btnNouveauProduit.Click += new System.EventHandler(this.btnNouveauProduit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMontantTotal);
            this.panel2.Controls.Add(this.lblNombreProduit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lstMontant);
            this.panel2.Controls.Add(this.lstAchat);
            this.panel2.Location = new System.Drawing.Point(472, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 415);
            this.panel2.TabIndex = 2;
            // 
            // lblMontantTotal
            // 
            this.lblMontantTotal.AutoSize = true;
            this.lblMontantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantTotal.Location = new System.Drawing.Point(394, 341);
            this.lblMontantTotal.Name = "lblMontantTotal";
            this.lblMontantTotal.Size = new System.Drawing.Size(38, 24);
            this.lblMontantTotal.TabIndex = 2;
            this.lblMontantTotal.Text = "0.0";
            this.lblMontantTotal.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblNombreProduit
            // 
            this.lblNombreProduit.AutoSize = true;
            this.lblNombreProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProduit.Location = new System.Drawing.Point(120, 341);
            this.lblNombreProduit.Name = "lblNombreProduit";
            this.lblNombreProduit.Size = new System.Drawing.Size(21, 24);
            this.lblNombreProduit.TabIndex = 2;
            this.lblNombreProduit.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Montant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Liste d\'achat";
            // 
            // lstMontant
            // 
            this.lstMontant.FormattingEnabled = true;
            this.lstMontant.ItemHeight = 18;
            this.lstMontant.Location = new System.Drawing.Point(338, 63);
            this.lstMontant.Name = "lstMontant";
            this.lstMontant.Size = new System.Drawing.Size(161, 256);
            this.lstMontant.TabIndex = 0;
            // 
            // lstAchat
            // 
            this.lstAchat.FormattingEnabled = true;
            this.lstAchat.ItemHeight = 18;
            this.lstAchat.Location = new System.Drawing.Point(56, 63);
            this.lstAchat.Name = "lstAchat";
            this.lstAchat.Size = new System.Drawing.Size(172, 256);
            this.lstAchat.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(537, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "GESTION DES VENTES";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSupprimer);
            this.panel3.Controls.Add(this.btnQuitter);
            this.panel3.Controls.Add(this.btnEffacer);
            this.panel3.Controls.Add(this.btnAjouter);
            this.panel3.Location = new System.Drawing.Point(136, 646);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 100);
            this.panel3.TabIndex = 4;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(249, 43);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(132, 32);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(734, 43);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(118, 32);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(486, 43);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(118, 32);
            this.btnEffacer.TabIndex = 0;
            this.btnEffacer.Text = "Effacer(RAZ)";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(37, 43);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(118, 32);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 764);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNouveauProduit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Librairie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProduit;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouveauProduit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMontantTotal;
        private System.Windows.Forms.Label lblNombreProduit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstMontant;
        private System.Windows.Forms.ListBox lstAchat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        public System.Windows.Forms.ComboBox cmbProduit;
    }
}

