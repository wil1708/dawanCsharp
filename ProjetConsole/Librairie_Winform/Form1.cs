using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librairie_Winform
{
    public partial class Form1 : Form
    {
        double prixUnitaire;
        double total = 0.0;
        double montant;
        int nombreProduit = 0;
        int produitListAchat;
        string produitSelectionne;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //Vérifier que les champs prixUnitaire et nombreProduit sont bien remplis
            if(!(string.IsNullOrEmpty(txtPrix.Text) && string.IsNullOrEmpty(txtNombreProduit.Text)))
            {
                produitSelectionne = cmbProduit.SelectedItem.ToString();

                //Vérifier que le produit sélectionné n'existe pas dans la liste d'achat
                if (!lstAchat.Items.Contains(produitSelectionne))
                {
                    produitListAchat = lstAchat.Items.Add(produitSelectionne);
                    produitListAchat++;
                    lblNombreProduit.Text = produitListAchat.ToString();

                    prixUnitaire = Convert.ToInt32(txtPrix.Text);
                    nombreProduit = Convert.ToInt32(txtNombreProduit.Text);
                    montant = prixUnitaire * nombreProduit;
                    lstMontant.Items.Add(montant);
                    total += montant;
                    lblMontantTotal.Text = total.ToString();
                }
            }
        }

        private void cmbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrix.Text = "";
            txtNombreProduit.Text = "";
            txtPrix.Focus();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(lstAchat.SelectedIndex != -1)
            {
                //Récupérer index du produit sélectionné
                int index = lstAchat.SelectedIndex;

                //Mise à jour des 2 labels nombre produit et montant total
                produitListAchat = Convert.ToInt32(lblNombreProduit.Text);
                produitListAchat--;
                lblNombreProduit.Text = produitListAchat.ToString();

                total = Convert.ToDouble(lblMontantTotal.Text);
                montant = (double)lstMontant.Items[index];
                total -= montant; //total = total - montant
                lblMontantTotal.Text = total.ToString();

                //Suppression du produit sélectionné et son prix 
                lstAchat.Items.RemoveAt(index);
                lstMontant.Items.RemoveAt(index);
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {

            txtPrix.Text = "";
            txtNombreProduit.Text = "";
            lstAchat.Items.Clear();
            lstMontant.Items.Clear();
            total = 0; ;
            lblMontantTotal.Text = total.ToString();
            produitListAchat = 0;
            lblNombreProduit.Text = produitListAchat.ToString();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNouveauProduit_Click(object sender, EventArgs e)
        {
            AjouterProduit ajout = new AjouterProduit();
            //this permet de garder le lien de parenté entre les deux fenêtres
            //ajout.Show(this);
            ajout.ShowDialog(this);
        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstAchat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
