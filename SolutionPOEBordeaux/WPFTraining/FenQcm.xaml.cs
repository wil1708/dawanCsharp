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
using System.Windows.Threading;
using WPFTraining.DAO;
using WPFTraining.Entites;

namespace WPFTraining
{
    /// <summary>
    /// Logique d'interaction pour FenQcm.xaml
    /// </summary>
    public partial class FenQcm : Window
    {
        private TestQcm qcmTest;
        private int numQstEnCours;
        private Question qst;

        private DispatcherTimer monTimer;
        public FenQcm()
        {
            InitializeComponent();

            monTimer = new DispatcherTimer();
            monTimer.Interval = TimeSpan.FromSeconds(1);
            monTimer.Tick += tacheMonTimer; //méthode executée chaque seconde
        }

        private void tacheMonTimer(object sender, EventArgs e)
        {
            int nb = Convert.ToInt32(TBCompteur.Text);
            if (nb > 0)
                TBCompteur.Text = Convert.ToString(nb - 1);
            else
                BtnSuivant_Click(sender, null);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            qcmTest = new TestQcm()
            {
                Candidat = new Candidat() { Id = 1, Nom = "toto", Email = "toto@dawan.fr" },
                Qcm = QcmDao.GenererExemple()
            };
            TBIntituleQcm.Text = qcmTest.Qcm.Intitule;
            AfficherQuestion();
        }

        private void AfficherQuestion()
        {
            monTimer.Stop();
            TBCompteur.Text = "5";
            monTimer.Start();
            if (numQstEnCours < qcmTest.Qcm.Questions.Count) //si numQstEnCours < nombre total de questions dans le qcm
            {
                //  récupérer la question qui est à la position numQstEnCours
                qst = qcmTest.Qcm.Questions[numQstEnCours];
                //  remplir les textBlock
                TBQuestionEnonce.Text = qst.Enonce;

                PanelReponse.Children.Clear();//effacer le panel pour recevoir les choix de réponses

                //si qst multiple => créer des cases à cocher et les ajouter au StackPanel
                if (qst.ChoixMultiple)
                {
                    foreach (Reponse rep in qst.Reponses)
                    {
                        CheckBox c = new CheckBox();
                        c.Content = rep; //on associe l'objet ici pour pouvoir exploiter la réponse complète
                        PanelReponse.Children.Add(c);
                    }
                }
                else //          sinon créer des boutons radios
                {
                    foreach (Reponse rep in qst.Reponses)
                    {
                        RadioButton c = new RadioButton();
                        c.Content = rep; //on associe l'objet ici pour pouvoir exploiter la réponse complète
                        PanelReponse.Children.Add(c);
                    }
                }
            }
            else
            {
                monTimer.Stop();
                TBCompteur.Visibility = Visibility.Hidden;
                TBQuestionEnonce.Text = "Score = " + qcmTest.Score;//afficher le score dans TBQstEnonce
                PanelReponse.Visibility = Visibility.Hidden;//masquer le panelReponses
                BtnSuivant.Visibility = Visibility.Hidden; //masquer le bouton suivant
            }
        }

        private void BtnSuivant_Click(object sender, RoutedEventArgs e)
        {
            //faire une boucle sur les composants du panelReponses
            //  si réponse correcte +1, -1
            if (qst.ChoixMultiple)
            {
                foreach (var item in PanelReponse.Children)
                {
                    CheckBox r = item as CheckBox;
                    if (r.IsChecked == true)
                    {
                        Reponse rep = r.Content as Reponse;
                        if (rep.Correcte)
                            qcmTest.Score += 1;
                        else
                            qcmTest.Score -= 1;
                    }
                }
            }
            else
            {
                foreach (var item in PanelReponse.Children)
                {
                    RadioButton r = item as RadioButton;
                    if (r.IsChecked == true)
                    {
                        Reponse rep = r.Content as Reponse;
                        if (rep.Correcte)
                            qcmTest.Score += 1;
                        else
                            qcmTest.Score -= 1;

                        break;
                    }
                }
            }
            //incrémenter nummQstEnCours
            numQstEnCours++;
            //rappeler la méthode AfficherQuestion
            AfficherQuestion();
        }
    }
}
