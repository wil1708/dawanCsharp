using _5_CRUD_Winform.DAO;
using _5_CRUD_Winform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_CRUD_Winform
{
    public partial class Form1 : Form
    {
        ContactDAO dao = new ContactDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Remplir();
        }

        public void Remplir()
        {
            dgContact.DataSource = dao.getAll();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
          
            Contact c = new Contact() { Nom = txtNom.Text, Prenom = txtPrenom.Text };
            if (btnAjouter.Text.Equals("Ajouter"))
            {
                dao.Insert(c);
            }
            else
            {
                c.Id = Convert.ToInt32(txtId.Text);
                dao.Update(c);
            }
            
            Remplir();
            Clear();
            
        }

        private void Clear()
        {
            txtNom.Text = txtPrenom.Text = "";
            btnAjouter.Text = "Ajouter";
            txtId.Text = "";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = (int)dgContact.CurrentRow.Cells["id"].Value;
            dao.Delete(id);
            Remplir();
        }

        private void dgContact_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)dgContact.CurrentRow.Cells["id"].Value;
            Contact c = dao.findById(id);
            txtId.Text = c.Id.ToString();
            txtNom.Text = c.Nom;
            txtPrenom.Text = c.Prenom;
            btnAjouter.Text = "Modifier";
        }
    }
}
