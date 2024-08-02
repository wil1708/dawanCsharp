
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
            this.label6 = new System.Windows.Forms.Label();
            this.lstMontant = new System.Windows.Forms.ListBox();
            this.lstAchat = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(56, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 411);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre Produit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prix Unitaire";
            // 
            // txtNombreProduit
            // 
            this.txtNombreProduit.Location = new System.Drawing.Point(64, 348);
            this.txtNombreProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreProduit.Name = "txtNombreProduit";
            this.txtNombreProduit.Size = new System.Drawing.Size(163, 23);
            this.txtNombreProduit.TabIndex = 3;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(64, 188);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(163, 23);
            this.txtPrix.TabIndex = 2;
            this.txtPrix.TextChanged += new System.EventHandler(this.txtPrix_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisir le produit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbProduit
            // 
            this.cmbProduit.FormattingEnabled = true;
            this.cmbProduit.Items.AddRange(new object[] {
            "Stylo",
            "Cahier",
            "Crayon",
            "Gomme"});
            this.cmbProduit.Location = new System.Drawing.Point(64, 51);
            this.cmbProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProduit.Name = "cmbProduit";
            this.cmbProduit.Size = new System.Drawing.Size(163, 24);
            this.cmbProduit.TabIndex = 0;
            this.cmbProduit.SelectedIndexChanged += new System.EventHandler(this.cmbProduit_SelectedIndexChanged);
            // 
            // btnNouveauProduit
            // 
            this.btnNouveauProduit.Location = new System.Drawing.Point(120, 21);
            this.btnNouveauProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNouveauProduit.Name = "btnNouveauProduit";
            this.btnNouveauProduit.Size = new System.Drawing.Size(150, 25);
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
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lstMontant);
            this.panel2.Controls.Add(this.lstAchat);
            this.panel2.Location = new System.Drawing.Point(345, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 411);
            this.panel2.TabIndex = 2;
            // 
            // lblMontantTotal
            // 
            this.lblMontantTotal.AutoSize = true;
            this.lblMontantTotal.Location = new System.Drawing.Point(399, 374);
            this.lblMontantTotal.Name = "lblMontantTotal";
            this.lblMontantTotal.Size = new System.Drawing.Size(31, 17);
            this.lblMontantTotal.TabIndex = 5;
            this.lblMontantTotal.Text = "0.0";
            // 
            // lblNombreProduit
            // 
            this.lblNombreProduit.AutoSize = true;
            this.lblNombreProduit.Location = new System.Drawing.Point(126, 374);
            this.lblNombreProduit.Name = "lblNombreProduit";
            this.lblNombreProduit.Size = new System.Drawing.Size(17, 17);
            this.lblNombreProduit.TabIndex = 4;
            this.lblNombreProduit.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Montant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Liste d\'achat";
            // 
            // lstMontant
            // 
            this.lstMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMontant.FormattingEnabled = true;
            this.lstMontant.ItemHeight = 20;
            this.lstMontant.Location = new System.Drawing.Point(308, 62);
            this.lstMontant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMontant.Name = "lstMontant";
            this.lstMontant.Size = new System.Drawing.Size(199, 284);
            this.lstMontant.TabIndex = 1;
            // 
            // lstAchat
            // 
            this.lstAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAchat.FormattingEnabled = true;
            this.lstAchat.ItemHeight = 20;
            this.lstAchat.Location = new System.Drawing.Point(59, 62);
            this.lstAchat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstAchat.Name = "lstAchat";
            this.lstAchat.Size = new System.Drawing.Size(170, 284);
            this.lstAchat.TabIndex = 0;
            this.lstAchat.SelectedIndexChanged += new System.EventHandler(this.lstAchat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gestion des ventes";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnQuitter);
            this.panel3.Controls.Add(this.btnEffacer);
            this.panel3.Controls.Add(this.btnSupprimer);
            this.panel3.Controls.Add(this.btnAjouter);
            this.panel3.Location = new System.Drawing.Point(56, 598);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 80);
            this.panel3.TabIndex = 4;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(658, 30);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 27);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(448, 30);
            this.btnEffacer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(124, 27);
            this.btnEffacer.TabIndex = 0;
            this.btnEffacer.Text = "Effacer (RAZ)";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(255, 30);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 27);
            this.btnSupprimer.TabIndex = 0;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(89, 30);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 27);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 850);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNouveauProduit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Librairie";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProduit;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Button btnNouveauProduit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMontantTotal;
        private System.Windows.Forms.Label lblNombreProduit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstMontant;
        private System.Windows.Forms.ListBox lstAchat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.ComboBox cmbProduit;
    }
}

