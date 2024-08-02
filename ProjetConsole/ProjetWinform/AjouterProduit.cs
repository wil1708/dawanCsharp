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
            Produit produitByID = service.FindById(id, ConnexionSQL.GetConnexion());
            string description = txtDescription.Text;
            double prix = Convert.ToDouble(txtPrix.Text);
            int quantite = Convert.ToInt32(txtQuantite.Text);
            Produit produit = new Produit(id, description, prix, quantite);

            if(btnAjouter.Text == "Ajouter")
            {
                if(id != produitByID.Id)
                {
                    service.AddProduct(produit, ConnexionSQL.GetConnexion());
                }
                else
                {
                    MessageBox.Show("Id existe déjà dans la base de données");
                }
            }else if(btnAjouter.Text == "Modifier")
            {
                service.UpdateProduct(produit, ConnexionSQL.GetConnexion());
            }
            //Appeler la méthode Remplir se situant dans la BDD dans cette fenêtre
            //Dans produit.Show(this); de la fenêtre appelant il faut mettre this
            //this.Owner permettra de récupérer les methides de BDD.cs se situant dans la fenêtre BDD.cs[Design]
            BDD bdd = this.Owner as BDD;
            bdd.Remplir(service.GetAllProducts(ConnexionSQL.GetConnexion()));

            //Fermer la fenêtre
            this.Close();






        }
    }
}
