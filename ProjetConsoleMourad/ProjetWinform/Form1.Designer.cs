
namespace ProjetWinform
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
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.rbRetrait = new System.Windows.Forms.RadioButton();
            this.rbDepot = new System.Windows.Forms.RadioButton();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSolde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lectureEcritureDeFichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sérialisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validationFormulaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleMiseÀJoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbOperation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOperation
            // 
            this.gbOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbOperation.Controls.Add(this.btnValider);
            this.gbOperation.Controls.Add(this.rbRetrait);
            this.gbOperation.Controls.Add(this.rbDepot);
            this.gbOperation.Controls.Add(this.txtMontant);
            this.gbOperation.Controls.Add(this.label2);
            this.gbOperation.Controls.Add(this.txtSolde);
            this.gbOperation.Controls.Add(this.label1);
            this.gbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperation.Location = new System.Drawing.Point(37, 124);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Size = new System.Drawing.Size(329, 309);
            this.gbOperation.TabIndex = 0;
            this.gbOperation.TabStop = false;
            this.gbOperation.Text = "Operations";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(50, 252);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(125, 34);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // rbRetrait
            // 
            this.rbRetrait.AutoSize = true;
            this.rbRetrait.Location = new System.Drawing.Point(181, 180);
            this.rbRetrait.Name = "rbRetrait";
            this.rbRetrait.Size = new System.Drawing.Size(69, 22);
            this.rbRetrait.TabIndex = 2;
            this.rbRetrait.TabStop = true;
            this.rbRetrait.Text = "Retrait";
            this.rbRetrait.UseVisualStyleBackColor = true;
            // 
            // rbDepot
            // 
            this.rbDepot.AutoSize = true;
            this.rbDepot.Location = new System.Drawing.Point(50, 180);
            this.rbDepot.Name = "rbDepot";
            this.rbDepot.Size = new System.Drawing.Size(66, 22);
            this.rbDepot.TabIndex = 2;
            this.rbDepot.TabStop = true;
            this.rbDepot.Text = "Dépot";
            this.rbDepot.UseVisualStyleBackColor = true;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(129, 115);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(162, 24);
            this.txtMontant.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Montant";
            // 
            // txtSolde
            // 
            this.txtSolde.Location = new System.Drawing.Point(129, 39);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.Size = new System.Drawing.Size(162, 24);
            this.txtSolde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solde";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.lst2);
            this.groupBox1.Controls.Add(this.lst1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(482, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfert de listes";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(211, 168);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "<<<<";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(211, 116);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = ">>>>";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.ItemHeight = 15;
            this.lst2.Location = new System.Drawing.Point(319, 39);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(144, 244);
            this.lst2.TabIndex = 0;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 15;
            this.lst1.Items.AddRange(new object[] {
            "TOTO",
            "TATA",
            "TITI"});
            this.lst1.Location = new System.Drawing.Point(26, 39);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(144, 244);
            this.lst1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.gestionDesUtilisateursToolStripMenuItem,
            this.usersManagmentToolStripMenuItem,
            this.miseÀJoursToolStripMenuItem,
            this.nouvelleMiseÀJoursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lectureEcritureDeFichiersToolStripMenuItem,
            this.sérialisationToolStripMenuItem,
            this.validationFormulaireToolStripMenuItem,
            this.baseDeDonnéesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.fichierToolStripMenuItem.Text = "Fichier";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // lectureEcritureDeFichiersToolStripMenuItem
            // 
            this.lectureEcritureDeFichiersToolStripMenuItem.Name = "lectureEcritureDeFichiersToolStripMenuItem";
            this.lectureEcritureDeFichiersToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.lectureEcritureDeFichiersToolStripMenuItem.Text = "Lecture/Ecriture de fichiers";
            this.lectureEcritureDeFichiersToolStripMenuItem.Click += new System.EventHandler(this.lectureEcritureDeFichiersToolStripMenuItem_Click);
            // 
            // sérialisationToolStripMenuItem
            // 
            this.sérialisationToolStripMenuItem.Name = "sérialisationToolStripMenuItem";
            this.sérialisationToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.sérialisationToolStripMenuItem.Text = "Sérialisation";
            this.sérialisationToolStripMenuItem.Click += new System.EventHandler(this.sérialisationToolStripMenuItem_Click);
            // 
            // validationFormulaireToolStripMenuItem
            // 
            this.validationFormulaireToolStripMenuItem.Name = "validationFormulaireToolStripMenuItem";
            this.validationFormulaireToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.validationFormulaireToolStripMenuItem.Text = "Validation formulaire";
            this.validationFormulaireToolStripMenuItem.Click += new System.EventHandler(this.validationFormulaireToolStripMenuItem_Click);
            // 
            // baseDeDonnéesToolStripMenuItem
            // 
            this.baseDeDonnéesToolStripMenuItem.Name = "baseDeDonnéesToolStripMenuItem";
            this.baseDeDonnéesToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.baseDeDonnéesToolStripMenuItem.Text = "Base de données";
            this.baseDeDonnéesToolStripMenuItem.Click += new System.EventHandler(this.baseDeDonnéesToolStripMenuItem_Click);
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(173, 25);
            this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            this.gestionDesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gestionDesUtilisateursToolStripMenuItem_Click);
            // 
            // usersManagmentToolStripMenuItem
            // 
            this.usersManagmentToolStripMenuItem.Name = "usersManagmentToolStripMenuItem";
            this.usersManagmentToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.usersManagmentToolStripMenuItem.Text = "Users Managment";
            this.usersManagmentToolStripMenuItem.Click += new System.EventHandler(this.usersManagmentToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(595, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tester UserService";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Utilisateur connecté:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(801, 47);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetWinform.Properties.Resources.iconfinder_exit_28363;
            this.pictureBox1.Location = new System.Drawing.Point(937, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // miseÀJoursToolStripMenuItem
            // 
            this.miseÀJoursToolStripMenuItem.Name = "miseÀJoursToolStripMenuItem";
            this.miseÀJoursToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.miseÀJoursToolStripMenuItem.Text = "mise à jours";
            // 
            // nouvelleMiseÀJoursToolStripMenuItem
            // 
            this.nouvelleMiseÀJoursToolStripMenuItem.Name = "nouvelleMiseÀJoursToolStripMenuItem";
            this.nouvelleMiseÀJoursToolStripMenuItem.Size = new System.Drawing.Size(130, 25);
            this.nouvelleMiseÀJoursToolStripMenuItem.Text = "nouvelle mise à jours";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOperation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOperation.ResumeLayout(false);
            this.gbOperation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperation;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.RadioButton rbRetrait;
        private System.Windows.Forms.RadioButton rbDepot;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSolde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lectureEcritureDeFichiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sérialisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validationFormulaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem usersManagmentToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleMiseÀJoursToolStripMenuItem;
    }
}

