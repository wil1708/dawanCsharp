using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_WinformApiClient
{
    public partial class Form1 : Form
    {
        private ApiContact apiClient = new ApiContact();

        int id = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public async void Remplir()
        {
            List<Contact> lst = await apiClient.AllContacts();
            dataGridView1.DataSource = lst;
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            Remplir();
        }

        private async void BtnAjouter_ClickAsync(object sender, EventArgs e)
        {
            Contact c = new Contact() { Nom = txtNom.Text, Prenom = txtPrenom.Text };
            
            if (BtnAjouter.Text.Equals("Ajouter"))
            {
                var res = await apiClient.AddContact(c);
                MessageBox.Show("Contact ajouté. Son URI est " + res.AbsoluteUri);
            }
            else
            {
                c.Id = id;
                var res = await apiClient.UpdateContact(id, c);
                MessageBox.Show("Contact mis à jour? " + res.ToString());
                BtnAjouter.Text = "Ajouter";
            }
            
            txtNom.Text = txtPrenom.Text = "";
            Remplir();
        }

        private async void BtnEditer_ClickAsync(object sender, EventArgs e)
        {
            txtNom.Text = dataGridView1.CurrentRow.Cells["nom"].Value.ToString();
            txtPrenom.Text = dataGridView1.CurrentRow.Cells["prenom"].Value.ToString();
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            BtnAjouter.Text = "Modifier";  
        }

        private async void BtnSupprimer_ClickAsync(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());

            if (id != 0)
            {
                var res = await apiClient.DeleteContact(id);
                MessageBox.Show("Contact supprimé" + res.ToString());
                Remplir();
            }
        }
    }
}
