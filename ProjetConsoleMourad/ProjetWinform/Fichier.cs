using ProjetDLL;
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
    public partial class Fichier : Form
    {
        public Fichier()
        {
            InitializeComponent();
        }

        //Texte ecriture dans un fichier
        private void button1_Click(object sender, EventArgs e)
        {
            //saveFileDialog : Inivite l'utilisateur à selectionner un emplacement pour enregistrer un fichier
            string path;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                Tools.EcritureFichier(path, txtEcriture.Text);
            } else
            {
                MessageBox.Show("Ecriture dans un fichier est annulée");
            }

        }

        //Texte Lecture dans un fichier
        private void button2_Click(object sender, EventArgs e)
        {
            string path;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                txtLecture.Text =  Tools.LectureFichier(path);
            } else
            {
                MessageBox.Show("Lecture dans un fichier est annulée");
            }

        }
    }
}
