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

namespace WPFTraining
{
    /// <summary>
    /// Logique d'interaction pour FenExemple1.xaml
    /// </summary>
    public partial class FenExemple1 : Window
    {
        public FenExemple1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = (MainWindow)this.Owner;
            mw.Title = "titre modifié depuis fenExemple1";
        }
    }
}
