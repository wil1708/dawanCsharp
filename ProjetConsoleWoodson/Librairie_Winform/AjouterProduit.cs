using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librairie_Winform
{
    public partial class AjouterProduit : Form
    {
        public AjouterProduit()
        {
            InitializeComponent();
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            string produit = txtAjouterProd.Text;
            Form1 f = this.Owner as Form1; //Récuperer la fenêtre appelante
            f.cmbProduit.Items.Add(produit);
            this.Close();
        }
    }
}
