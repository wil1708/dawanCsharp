using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_Calculatrice_Graphique
{
    public partial class Form1 : Form
    {
        string operateur = "";
        double premierNombre = 0.0;
        double secondNombre = 0.0;
        int taille;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            if (btnON.Text.Equals("ON"))
            {
                txtResultat.Text = "0";
                txtResultat.Enabled = true;
                txtOperation.Enabled = true;
                foreach(Control item in panel1.Controls)
                {
                    if (!item.Text.Equals("ON"))
                    {
                        item.Enabled = true;
                    }
                }
                btnON.Text = "OFF";
            }
            else if (btnON.Text.Equals("OFF")){
                txtResultat.Text = "";
                txtOperation.Clear();
                txtResultat.Enabled = false;
                txtOperation.Enabled = false;
                foreach(Control item in panel1.Controls)
                {
                    if (!item.Text.Equals("OFF"))
                    {
                        item.Enabled = false;
                    }
                }
                btnON.Text = "ON"; 
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Au démarrage on désactive les boutons
            
            txtResultat.Enabled = false;
            txtOperation.Enabled = false;
            foreach (Control item in panel1.Controls)
            {
                if (!item.Text.Equals("ON"))
                {
                    item.Enabled = false;
                }
                 
            }
            
        }

        private void buttonChiffre_Click(object sender, EventArgs e)
        {
            //sender: Objet à l'origine de l'événement
            //représente le contrôle qui a déclenché l'événement
            Button chiffre = (Button)sender;
            txtOperation.Text += chiffre.Text;

            if (!operateur.Equals("")){
                secondNombre = Convert.ToDouble(txtOperation.Text.Substring(taille));
            }
        }

        private void buttonOperateur_Click(object sender, EventArgs e)
        {
            //On récupère l'objet à l'origine de l'évènement
            Button btnOperation = (Button)sender;
            //On récupère le premier nombre
            premierNombre = Convert.ToDouble(txtOperation.Text);
            txtOperation.Text += btnOperation.Text;
            operateur = btnOperation.Text;
            //Une fois l'opérateur saisi, on peut récupérer le premierNombre
            //Le secondNombre, c'est la taille du txtOperation - la taille du premierNombre + opérateur
            //ex: 1234+15489
            taille = txtOperation.Text.Length;           
        }

        private void buttonEgal_Click(object sender, EventArgs e)
        {
            
                switch (operateur)
                {
                    case "+":
                    txtResultat.Text = (premierNombre + secondNombre).ToString(); 
                        break;
                    case "-":
                    txtResultat.Text = (premierNombre - secondNombre).ToString();
                        break;
                    case "/":
                    txtResultat.Text = (premierNombre / secondNombre).ToString();
                        break;
                    case "*":
                    txtResultat.Text = (premierNombre * secondNombre).ToString();
                        break;           
                }            
        }
        
        private void button17_Click(object sender, EventArgs e)
        {
            txtOperation.Text = "";
            txtResultat.Text = "0";
            operateur = "";
            premierNombre = 0;
            secondNombre = 0;
            taille = 0;
        }

        //Bouton<<<<<<<<<
        private void button3_Click(object sender, EventArgs e)
        {
            string contenu = txtOperation.Text;
            try
            {
                txtOperation.Text = contenu.Substring(0, contenu.Length - 1);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtOperation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
