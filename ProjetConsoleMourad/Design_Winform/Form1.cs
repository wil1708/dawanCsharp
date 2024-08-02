using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = !menuPanel.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Inscription inscription = new Inscription();
            inscription.TopLevel = false;
            mainPanel.Controls.Add(inscription);
            
            inscription.Show();*/
            openForm(new Inscription());
        }

        private Form activeForm = null;
        private void openForm(Form f)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            f.BringToFront();
            f.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            openForm(new Connexion());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openForm(new Deconnexion());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            activeForm.Close();
        }
    }
}
