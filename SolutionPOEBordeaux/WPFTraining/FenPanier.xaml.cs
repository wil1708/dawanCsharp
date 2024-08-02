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
    /// Logique d'interaction pour FenPanier.xaml
    /// </summary>
    public partial class FenPanier : Window
    {
        private FenExemple2 fenExemple2s;

        public FenPanier()
        {
            InitializeComponent();
        }

        private void RafraichirGrid()
        {
            DGLignesPanier.ItemsSource = null;
            DGLignesPanier.ItemsSource = FenExemple2.monPanier.Lignes;
            TBTotalPanier.Text = $"Total panier = {FenExemple2.monPanier.Total} euros";
            fenExemple2s.RafraichirTextBtnPanier();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fenExemple2s = this.Owner as FenExemple2;
            RafraichirGrid();
        }

        private void btnReduireQte_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LignePanier ligne = RecupererGridLigne(sender);
                FenExemple2.monPanier.ChangerQte(ligne, -1);
                RafraichirGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAjouterQte_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LignePanier ligne = RecupererGridLigne(sender);
                FenExemple2.monPanier.ChangerQte(ligne,1);
                RafraichirGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LignePanier ligne = RecupererGridLigne(sender);
                FenExemple2.monPanier.Supprimer(ligne);
                RafraichirGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private LignePanier RecupererGridLigne(object sender)
        {
            for (var vis = sender as Visual; vis != null; vis = VisualTreeHelper.GetParent(vis) as Visual)
            {
                if (vis is DataGridRow)
                {
                    DataGridRow row = (DataGridRow)vis;
                    return row.Item as LignePanier;
                }
            }
            return null;
        }
    }
}
