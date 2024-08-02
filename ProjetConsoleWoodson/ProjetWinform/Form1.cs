using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            double solde = Convert.ToDouble(txtSolde.Text);
            double montant = Convert.ToDouble(txtMontant.Text);

            if(rbDepot.Checked)
            {
                solde += montant;
                txtSolde.Text = solde.ToString();
            } else if(rbRetrait.Checked)
            {
                if(montant<=solde)
                {
                    solde -= montant;
                    txtSolde.Text = solde.ToString();
                } else
                {
                    MessageBox.Show("Solde insuffisant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(!(rbDepot.Checked) || (rbRetrait.Checked))
            {
                MessageBox.Show("Veuillez choisir Retrait ou Dépot ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Transfert une list d'items
            if(lst1.SelectedItem != null)
            {
                lst2.Items.Add(lst1.SelectedItem);
                lst1.Items.Remove(lst1.SelectedItem);
            } else
            {
                MessageBox.Show("La liste est vide");
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(lst2.SelectedItem != null)
            {
                lst1.Items.Add(lst2.SelectedItem);
                lst2.Items.Remove(lst2.SelectedItem);
            }else
            {
                MessageBox.Show("La liste est vide");
            }

        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lectureEcritureDeFichiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fichier fichier = new Fichier();
            fichier.ShowDialog();
        }

        private void sérialisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comptes comptes = new Comptes();
            comptes.ShowDialog();
        }

        private void validationFormulaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            validation.ShowDialog();
        }

        private void baseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowDialog();
        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterUtilisateur utilisateur = new AjouterUtilisateur();
            utilisateur.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
