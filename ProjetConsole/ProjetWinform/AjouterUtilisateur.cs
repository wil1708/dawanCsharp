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
    public partial class AjouterUtilisateur : Form
    {
        UtilisateurService service = new UtilisateurService();
        public AjouterUtilisateur()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            bool admin = Convert.ToBoolean(Convert.ToInt32(txtAdmin.Text));

            Utilisateur utilisateurByLogin = service.FindByLogin(login, ConnexionSQL.GetConnexion());

            Utilisateur utilisateur = new Utilisateur();
            utilisateur.Login = login;
            utilisateur.Password = password;
            utilisateur.Admin = admin;

            if(!(login.Equals(utilisateurByLogin.Login)))
            {
                service.AddUser(utilisateur, ConnexionSQL.GetConnexion());
                Console.WriteLine("je passe");
            }else
            {
                MessageBox.Show("Le Login existe déjà dans la base de données");
            }
            
            this.Close();
        }
    }
}
