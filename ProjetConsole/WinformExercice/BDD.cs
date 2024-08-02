
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
    public partial class BDD : Form
    {
        Produit2Service service = new Produit2Service();
        List<Produit2> lst = new List<Produit2>();
        public BDD()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AjouterProduit2 produit = new AjouterProduit2();
            produit.Show(this);
        }

        public void Remplir(List<Produit2> lp)
        {
            lst = lp;
            dataGridView1.DataSource = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lst;
        }

        private void BDD_Load(object sender, EventArgs e)
        {
            /*Remplir(service.GetAllProduit2(ConnexionSQL.GetConnexion()));
            this.produitTableAdapter.Fill(this.test2DataSet.produit);*/
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
            if(id != 0)
            {
                AjouterProduit2 modifierProduit = new AjouterProduit2();

                Produit2 p = service.GetById(id, ConnexionSQL.GetConnexion());

                modifierProduit.txtID.Text = p.Id.ToString();
                modifierProduit.txtDescription.Text = p.Description;
                modifierProduit.txtPrix.Text = p.Prix.ToString();
                modifierProduit.txtQuantite.Text = p.Quantite.ToString();

                modifierProduit.txtID.Enabled = false;
                modifierProduit.lblTitre.Text = "Modifier un produit";
                modifierProduit.btnAjouter.Text = "Modifier";
                modifierProduit.ShowDialog(this);

            }
            else
            {
                MessageBox.Show("Aucun produit selectionné");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
            if(id != 0)
            {
                service.DeleteProduit2(id, ConnexionSQL.GetConnexion());
                Remplir(service.GetAllProduit2(ConnexionSQL.GetConnexion()));
            }
            else
            {
                MessageBox.Show("Aucun produit sélectionné");
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            List<Produit2> produits = service.FindByKey(txtRecherche.Text, ConnexionSQL.GetConnexion());
            Remplir(produits);
        }
    }
}
