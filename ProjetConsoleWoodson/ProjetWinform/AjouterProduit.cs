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
    public partial class AjouterProduit : Form
    {
        ProduitService service = new ProduitService();
        List<Produit> lst = new List<Produit>();

        public AjouterProduit()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            Produit produitByID = service.findById(id, ConnexionSQL.getConnexion());
            string description = txtDescription.Text;
            double prix = Convert.ToDouble(txtPrix.Text);
            int quantite = Convert.ToInt32(txtQuantite.Text);
            Produit produit = new Produit(id, description, prix, quantite);

            if(btnAjouter.Text =="Ajouter")
            {
                if(id != produitByID.Id)
                {
                    service.addProduct(produit, ConnexionSQL.getConnexion());
                } else
                {
                    MessageBox.Show("Id existe déjà dans la base de données");
                }
            }else if(btnAjouter.Text == "Modifier")
            {
                service.updateProduct(produit, ConnexionSQL.getConnexion());
            }

            //Appeler la methode Remplir se situant dans le BDD dans cette  fenetre
            //Dans produit.Show(this); du fenetre appelant il faut mettre this
            //this.Owner permettra de récuperer les methodes de BDD.cs se situant dans la fenetre BDD.cs[Design]
            BDD bdd = this.Owner as BDD;
            bdd.Remplir(service.getAllProducts(ConnexionSQL.getConnexion()));

            //Fermer la fenetre 
            this.Close();
        }
    }
}
