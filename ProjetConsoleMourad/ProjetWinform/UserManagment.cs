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
    public partial class UserManagment : Form
    {
        UserService service = new UserService(new UserDAO());

        public UserManagment()
        {
            InitializeComponent();
        }

        private void UserManagment_Load(object sender, EventArgs e)
        {
            foreach (var profil in User.Profiles)
            {
                cmbProfile.Items.Add(profil);
            }

            Remplir(service.findAllUser());
            
            
           
        }

        public void Remplir(List<User> lst)
        {
            dgUsers.AutoGenerateColumns = false;
            dgUsers.DataSource = false;
            dgUsers.DataSource = lst;
            dgUsers.ClearSelection();
            dgUsers.CurrentCell = null;
        }

        private void Clear()
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
            cmbProfile.SelectedIndex = -1;
            picture.Image = null;
            picture.ImageLocation = "";
            btnAjouter.Text = "Ajouter";
            txtLogin.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture.Image = Image.FromFile(openFileDialog1.FileName);
                picture.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //Vérifier que tous les champs sont bien remplis
            if(!txtLogin.Text.Equals("") && !txtPassword.Text.Equals("") && picture.Image != null && !picture.ImageLocation.Equals("") && cmbProfile.SelectedIndex != -1)
            {
                User u = new User(txtLogin.Text, txtPassword.Text, picture.ImageLocation, (Profile)cmbProfile.SelectedIndex);

                if (btnAjouter.Text.Equals("Ajouter"))
                {
                    //Vérifier si user existe en BD
                    User user = service.getByLogin(txtLogin.Text);
                    if (user != null)
                    {
                        MessageBox.Show("Utilisateur existe déjà en BD");
                    }
                    else
                    {
                        service.addUser(u);
                        
                    }
                }
                else
                {
                    service.updateUser(u);
                }

                Remplir(service.findAllUser());
                Clear();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgUsers.CurrentCell != null)
            {
                string login = dgUsers.CurrentRow.Cells["login"].Value.ToString();

                if (!string.IsNullOrEmpty(login))
                {
                    User u = service.getByLogin(login);
                    txtLogin.Text = u.Login;
                    txtPassword.Text = u.Password;
                    cmbProfile.SelectedIndex = (int)u.Profil;
                    picture.Image = Image.FromFile(u.Photo);
                    picture.ImageLocation = u.Photo;
                    txtLogin.Enabled = false;
                    btnAjouter.Text = "Modifier";
                }

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dgUsers.CurrentCell != null) { 
            string login = dgUsers.CurrentRow.Cells["login"].Value.ToString();

            if ( !string.IsNullOrEmpty(login))
            {
              if( MessageBox.Show("Etes-vous sûr de vouloir supprimer l'utilisateur "+login, "Suppression d'un utilisateur",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        service.removeByLogin(login);
                        Remplir(service.findAllUser());
                    }
            }
            }

        }
    }
}
