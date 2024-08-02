using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWinform
{
    public partial class Validation : Form
    {
        //Validation implicite : permet de valeur le contenu d'un champs pendant la saisie
        //Validation explicite: Permet de valider le contenu d'un formulaire au moment de son envoie
        //Expression regulière: Permet de définir un pattern (un format de données) à respecter
        Regex regTelephone = new Regex("^[0-9]{10,13}$"); // ex: 0536475825
        Regex regNom = new Regex("^[A-Z]{1}[a-zA-Z]*$");
        Regex regPrenom = new Regex("^[A-Z]{1}[a-zA-Z]*$");
        //daWan31@gMail.com
        Regex regEmail = new Regex("^[a-zA-Z0-9]{1,30}@[a-zA-Z0-9]{1,30}\\.[a-zA-Z]{2,3}$");

        PersistenceContact dao = new PersistenceContact();

        public Validation()
        {
            InitializeComponent();
        }




        private void Validation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'testDataSet.contact'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contactTableAdapter.Fill(this.testDataSet.contact);

        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
           if(isFormValid())
            {
                Contact c = new Contact(Convert.ToInt32(txtID.Text), txtNom.Text, txtPrenom.Text,
                    txtEmail.Text, Convert.ToInt64(txtTelephone.Text));
                dao.AddContact(c);
            } else
            {
                MessageBox.Show("Formulaire invalid!!!");
            }



        }

        bool isNumericBack;
        //Le deuxième paramètre contient les arguments
        //son contenu depend du type de l'événement
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumericBack = false;
            if(char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                isNumericBack = true;
            }else
            {
                e.Handled = true;  //Permet de dire que l'evenement a été géré
            }

        }

        private bool isFormValid()
        {
            //ID: Validation implicite (evenement keyPress)
            if(Convert.ToInt32(txtID.Text.Length) < 1)
            {
                MessageBox.Show("Le champs ID doit être rempli", "Verification ID", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtID.Focus();
                txtID.BackColor = Color.Silver;
                return false;
            } else
            {
                txtID.BackColor = Color.White;
            }

            //Nom
            if(!regNom.IsMatch(txtNom.Text))
            {
                MessageBox.Show("Le champs Nom n'est pas valide", "Verification Nom", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtNom.Focus();
                txtNom.BackColor = Color.Silver;
                return false;
            } else
            {
                txtNom.BackColor = Color.White;
            }

            //Prenom
            if (!regPrenom.IsMatch(txtPrenom.Text))
            {
                MessageBox.Show("Le champs Prenom n'est pas valide", "Verification Prenom", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrenom.Focus();
                txtPrenom.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtPrenom.BackColor = Color.White;
            }

            //Email
            if (!regEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Le champs Emiail n'est pas valide", "Verification Email", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }

            //Email
            if (!regTelephone.IsMatch(txtTelephone.Text))
            {
                MessageBox.Show("Le champs Telephone n'est pas valide", "Verification Telephone", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTelephone.Focus();
                txtTelephone.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtTelephone.BackColor = Color.White;
            }

            this.Close();
            return true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
