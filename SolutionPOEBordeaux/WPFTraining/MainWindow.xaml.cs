using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFTraining.AccessDonnees;
using WPFTraining.Entites;
using WPFTraining.Services;

namespace WPFTraining
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProduitDao dao;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void miExemple1_Click(object sender, RoutedEventArgs e)
        {
            FenExemple1 f = new FenExemple1(); //on instancie la fenêtre
            f.Owner = this; //on associe l'objet en cours au Owner
            f.ShowDialog(); //on affiche f en mode "modale"
        }

        private void miQuitter1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void RafraichirGrid()
        {
            List<Produit> lp = dao.Lister();
            //afficher cette liste dans le grid DGProduits
            DGProduits.ItemsSource = null;
            DGProduits.ItemsSource = lp;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //récupérer une liste de produits
            dao = new ProduitDao();
            List<Produit> lp = dao.Lister();
            //afficher cette liste dans le grid DGProduits
            DGProduits.ItemsSource = lp;
        }

        private void BtnSauvegarder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TBoxId.Text);
                string description = TBoxDescription.Text;
                double prix = Convert.ToDouble(TBoxPrix.Text);

                Produit p = new Produit(id, description, prix);

                if (TBoxId.IsEnabled)
                {
                    dao.Inserer(p);
                }
                else
                {
                    dao.Modifier(p);
                    TBoxId.IsEnabled = true;
                }
                

                RafraichirGrid();
                TBoxId.Clear();
                TBoxDescription.Clear();
                TBoxPrix.Clear();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (var vis = sender as Visual; vis != null; vis = VisualTreeHelper.GetParent(vis) as Visual)
            {
                if (vis is DataGridRow)
                {
                    DataGridRow row = (DataGridRow)vis;
                    Produit p = row.Item as Produit;
                    dao.Supprimer(p.Id.Value);
                    RafraichirGrid();
                    break;
                }
            }
            int id = 0; //TODO récupérer l'id de l'élément sélectionné
            dao.Supprimer(id);
            RafraichirGrid();
        }

        private void BtnExporter_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == true)
            {
                try
                {
                    FichierService.ExportCSV(sfd.FileName, ';', dao.Lister());
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                 
            }
            
        }

        private void BtnImporter_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == true)
            {
                try
                {
                    List<string> lignesIgnorees;
                    List<Produit> prodImp = FichierService.ImportCSV(ofd.FileName, ';', out lignesIgnorees);

                    foreach (Produit p in prodImp)
                    {
                        dao.Inserer(p);
                    }
                    RafraichirGrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            //récupérer l'élément sélectionné du grid : selecteditem
            Produit p = DGProduits.SelectedItem as Produit;
            //remplir les textbox puis disable le TBoxId
            TBoxId.Text = p.Id.ToString();
            TBoxId.IsEnabled = false;
            TBoxDescription.Text = p.Description;
            TBoxPrix.Text = p.Prix.ToString();
        }

        private void miExemple2_Click(object sender, RoutedEventArgs e)
        {
            FenExemple2 f = new FenExemple2(); 
             
            f.ShowDialog();
        }

        private void miQcm_Click(object sender, RoutedEventArgs e)
        {
            FenQcm f = new FenQcm();
            f.ShowDialog();
        }
    }
}
