using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFTraining.AccessDonnees;
using WPFTraining.Entites;

namespace WPFTraining
{
    /// <summary>
    /// Logique d'interaction pour FenExemple2.xaml
    /// </summary>
    public partial class FenExemple2 : Window
    {
        private ProduitDao produitDao;
        public static Panier monPanier;

        public FenExemple2()
        {
            InitializeComponent();
        }

        private void ComboProduits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            monPanier = new Panier(); // on prépare notre panier vide
            produitDao = new ProduitDao();
            ComboProduits.ItemsSource = produitDao.Lister(); //on remplit la combo avec les choix

        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //récupérer l'item sélectionné de la combo
                Produit p = ComboProduits.SelectedItem as Produit;
                //récupérer la quantité (Text de TBoxQte)
                int qte = Convert.ToInt32(TBoxQte.Text);
                //créer une ligne panier
                LignePanier ligne = new LignePanier(p, qte);
                //ajouter la ligne dans monPanier
                monPanier.Ajouter(ligne);
                //mettre à jour le bouton "voir le panier (nbArticles)"
                RafraichirTextBtnPanier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public void RafraichirTextBtnPanier()
        {
            BtnAfficherPanier.Content = $"Voir le panier ({monPanier.NbArticles})";
        }

        private void BtnAfficherPanier_Click(object sender, RoutedEventArgs e)
        {
            FenPanier f = new FenPanier();
            f.Owner = this;
            f.ShowDialog();
        }
    }
}
