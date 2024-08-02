using ProjetWinform.DAO;
using ProjetWinform.Model;
using ProjetWinform.MyTools;
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
    public partial class Authentification : Form
    {
        UserService service = new UserService(new UserDAO());
        public Authentification()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string erreur = "Echec connexion...";
            string login = txtLogin.Text;
            string password = txtPassword.Text; ;

           if(service.CheckLogin(login, password))
            {
                Form1 form1 = new Form1();
                form1.SetLogin(login);
                this.Visible = false;
                txtLogin.Text = txtPassword.Text = "";
                if (!service.IsUserAdmin(login))
                {
                    form1.NonAdmin();
                }
                form1.ShowDialog(this); //garder un lien de parenté avec la fenêtre appelante
                
            }
            else
            {
                lblErreur.Text = erreur;
                txtLogin.Text = txtPassword.Text = "";
                txtLogin.Focus();
            }
            
            //Si user existe en BDD - Afficher Form1
            //Sinon message d'erreur dans lblErreur

        }
    }
}
