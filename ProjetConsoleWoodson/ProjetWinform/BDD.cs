using ProjetWinform.DAO;
using ProjetWinform.Model;
using ProjetWinform.Service;
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
    public partial class BDD : Form
    {
        ProduitService service = new ProduitService();
        List<Produit> lst = new List<Produit>();

        public BDD()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjouterProduit produit = new AjouterProduit();
            //this permet de garder un lien de parenté entre les deux fenêtres
            produit.Show(this);
        }

        public void Remplir(List<Produit> lp)
        {
            lst = lp;
            dataGridView1.DataSource = false; //Mettre à zero le contenu du datasource
            dataGridView1.AutoGenerateColumns = false;  //On demande au datagrid de ne pas regenerer les colonnes
            dataGridView1.DataSource = lst;

        }

        private void BDD_Load(object sender, EventArgs e)
        {
            Remplir(service.getAllProducts(ConnexionSQL.getConnexion()));
            // TODO: cette ligne de code charge les données dans la table 'testDataSet.produit'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.produitTableAdapter.Fill(this.testDataSet.produit);

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
            if(id != 0)
            {
                AjouterProduit modifierProduit = new AjouterProduit();

                //On recupère le produit selectionné
                Produit p = service.findById(id, ConnexionSQL.getConnexion());

                //Remplir les champs form avec le produit selectionné
                modifierProduit.txtID.Text = p.Id.ToString();
                modifierProduit.txtDescription.Text = p.Description;
                modifierProduit.txtPrix.Text = p.Prix.ToString();
                modifierProduit.txtQuantite.Text = p.Quantite.ToString();

                //Désactiver le champs ID
                modifierProduit.txtID.Enabled = false;

                //Mettre à jours le label titre
                modifierProduit.lblTitre.Text = "Modifier un produit";

                //Bouton ajouter devient modifier
                modifierProduit.btnAjouter.Text = "Modifier";

                modifierProduit.ShowDialog(this);

            } else
            {
                MessageBox.Show("Aucun produit selectionné");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
            if(id != 0)
            {
                service.deleteProduct(id, ConnexionSQL.getConnexion());
                Remplir(service.getAllProducts(ConnexionSQL.getConnexion()));
            } else
            {
                MessageBox.Show("Aucun produit selectionné");
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            List<Produit> produits = service.findBykey(txtRecherche.Text, ConnexionSQL.getConnexion());
            Remplir(produits);
        }
    }
}
