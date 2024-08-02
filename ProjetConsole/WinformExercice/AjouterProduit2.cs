using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformExercice.DAO;
using WinformExercice.Model;
using WinformExercice.Service;

namespace WinformExercice
{
    public partial class AjouterProduit2 : Form
    {
        Produit2Service service = new Produit2Service();
        List<Produit2> lst = new List<Produit2>();
        public AjouterProduit2()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            Produit2 produitByID = service.GetById(id, ConnexionSQL.GetConnexion());
            string description = txtDescription.Text;
            double prix = Convert.ToDouble(txtPrix.Text);
            int quantite = Convert.ToInt32(txtQuantite.Text);
            Produit2 produit = new Produit2(id, description, prix, quantite);

            if(btnAjouter.Text == "Ajouter")
            {
                if (id != produitByID.Id)
                {
                    service.AddProduit2(produit, ConnexionSQL.GetConnexion());
                }
                else
                {
                    MessageBox.Show("Id existe déjà dans la base de données");
                }
            }
            else if (btnAjouter.Text == "Modifier")
            {
                service.UpdateProduit2(produit, ConnexionSQL.GetConnexion());
            }

            BDD bdd = this.Owner as BDD;
            bdd.Remplir(service.GetAllProduit2(ConnexionSQL.GetConnexion()));

            this.Close();






        }

    }
}
