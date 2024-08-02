using ProjetWinform.DAO;
using ProjetWinform.Model;
using ProjetWinform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetWinform
{
    public partial class Form1 : Form
    {
        UserService service = new UserService(new UserDAO());

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void SetLogin(string login)
        {
            lblUser.Text = login;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            double solde = Convert.ToDouble(txtSolde.Text);
            double montant = Convert.ToDouble(txtMontant.Text);

            if (rbDepot.Checked)
            {
                solde += montant;
                txtSolde.Text = solde.ToString();
            }else if (rbRetrait.Checked)
            {
                if(montant <= solde)
                {
                    solde -= montant;
                    txtSolde.Text = solde.ToString();
                }
                else
                {
                    MessageBox.Show("Solde insuffisant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }else if(!(rbDepot.Checked) || (rbRetrait.Checked))
            {
                MessageBox.Show("Veuillez choisir Retrait ou Dépot ! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                
            }
        }

        public void NonAdmin()
        {
            usersManagementToolStripMenuItem.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Transfert une list d'items
            if(lst1.SelectedItem != null)
            {
                lst2.Items.Add(lst1.SelectedItem);
                lst1.Items.Remove(lst1.SelectedItem);
            }
            else
            {
                MessageBox.Show("La liste est vide");
            }
             
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lst2.SelectedItem != null)
            {
                lst1.Items.Add(lst2.SelectedItem);
                lst2.Items.Remove(lst2.SelectedItem);
            }
            else
            {
                MessageBox.Show("La liste est vide");
            }
            
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lectureEcritureDeFichiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fichier fichier = new Fichier();
            fichier.ShowDialog();
        }

        private void sérialisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comptes comptes = new Comptes();
            comptes.ShowDialog();
        }

        private void validationFormulaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            validation.ShowDialog();
        }

        private void baseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowDialog();
        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterUtilisateur utilisateur = new AjouterUtilisateur();
            utilisateur.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User("admin", "admin", "test", Profile.ADMIN);
            service.AddUser(u);
            MessageBox.Show("User inséré dans la BDD");
        }

        private void usersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement um = new UserManagement();
            um.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Etes-vous sûr de vouloir vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Authentification auth = this.Owner as Authentification;
                auth.Visible = true;
            }
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
