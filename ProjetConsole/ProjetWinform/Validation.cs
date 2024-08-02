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
        //Validation implicite : permet de valider le contenu d'un champs pendant la saisie
        //Validation explicite : permet de valider le contenu d'un formulaire au moment de son envoi
        //Expression régulière : permet de définir un pattern (un format de données) à respecter
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

        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                Contact c = new Contact(Convert.ToInt32(txtId.Text), txtNom.Text, txtPrenom.Text, txtEmail.Text, Convert.ToInt64(txtTelephone.Text));
                dao.AddContact(c);
            }
            else
            {
                MessageBox.Show("Formulaire invalide!!!");
            }
        }
        bool isNumericBack;
        //Le deuxième paramètre contient les arguments
        //son contenu dépend du type de l'évènement
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumericBack = false;
            if(char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                isNumericBack = true;
            }
            else
            {
                e.Handled = true; //Permet de dire que l'évènement a été géré
            }
        }

        private bool isFormValid()
        {
            //Id: validation implicite (évènement keyPress)
            if(Convert.ToInt32(txtId.Text.Length) < 1)
            {
                MessageBox.Show("Le champs ID doit être rempli", "Vérification ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                txtId.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtId.BackColor = Color.White;
            }

            //Nom 
            if (!regNom.IsMatch(txtNom.Text))
            {
                MessageBox.Show("Le champs Nom n'est pas valide", "Vérification Nom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNom.Focus();
                txtNom.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtNom.BackColor = Color.White;
            }

            //Prénom 
            if (!regPrenom.IsMatch(txtPrenom.Text))
            {
                MessageBox.Show("Le champs Prénom n'est pas valide", "Vérification Prénom", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Le champs Email n'est pas valide", "Vérification Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }

            //Telephone 
            if (!regTelephone.IsMatch(txtTelephone.Text))
            {
                MessageBox.Show("Le champs Telephone n'est pas valide", "Vérification Telephone", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Validation_Load_1(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'testDataSet.contact'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.contactTableAdapter.Fill(this.testDataSet.contact);

        }
    }
}
