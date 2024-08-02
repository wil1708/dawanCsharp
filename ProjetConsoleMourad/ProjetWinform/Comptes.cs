using ProjetDLL;
using ProjetDLL.Encapsulation;
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
    public partial class Comptes : Form
    {
        public Comptes()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Etes vous sur de vouloir supprimer le compte ? ", "Suppression d'un compte", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CompteBancaire cb = (CompteBancaire)lstCompte.SelectedItem;
                lstCompte.Items.Remove(cb);
            } else
            {
                MessageBox.Show("Suppression annulée");
            }

            btnSupprimer.Visible = false;
            btnAjouter.Enabled = true;
            btnAjouter.Text = "Ajouter";
            txtNumero.Text = "";
            txtSolde.Text = "";
        }

        private void Comptes_Load(object sender, EventArgs e)
        {
            List<CompteBancaire> lstCpte = new List<CompteBancaire>();
            lstCpte.Add(new CompteBancaire("aaa11aaa", 1500));
            lstCpte.Add(new CompteBancaire("bbb22bbb", 8500));
            lstCpte.Add(new CompteBancaire("ccc33ccc", 65400000));
            lstCpte.Add(new CompteBancaire("ddd44dd", 801));

            foreach(CompteBancaire cb in lstCpte)
            {
                lstCompte.Items.Add(cb);
            }
        }

        private void lstCompte_Click(object sender, EventArgs e)
        {
            btnAjouter.Enabled = false;
            btnSupprimer.Visible = true;
            btnAjouter.Visible = true;
            btnAnnuler.Visible = true;
        }


        private void lstCompte_DoubleClick(object sender, EventArgs e)
        {
            CompteBancaire cb = (CompteBancaire)lstCompte.SelectedItem;
            txtNumero.Text = cb.Numero;
            txtSolde.Text = cb.Solde.ToString();
            btnAjouter.Text = "Modifier";
            txtNumero.Enabled = false;
            btnSupprimer.Visible = false;
            btnAjouter.Enabled = true;
            btnAjouter.Visible = true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            btnSupprimer.Visible = false;
            btnAnnuler.Visible = false;
            btnAjouter.Enabled = true;
            btnAjouter.Text = "Ajouter";
            txtNumero.Enabled = true;
            txtNumero.Text = "";
            txtSolde.Text = "";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string num = "";
            double solde = 0.0;
            CompteBancaire cb = null;

            try
            {
                num = txtNumero.Text;
                solde = Convert.ToDouble(txtSolde.Text);
                cb = new CompteBancaire(num, solde);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }



            if (btnAjouter.Text.Equals("Ajouter"))
            {
                lstCompte.Items.Add(cb);
            } else if(btnAjouter.Text.Equals("Modifier"))
            {
                int index = lstCompte.SelectedIndex;
                lstCompte.Items.RemoveAt(index);
                lstCompte.Items.Insert(index, cb);
                btnAjouter.Text = "Ajouter";
                txtNumero.Enabled = true;
            }

            txtNumero.Text = "";
            txtSolde.Text = "";

            btnSupprimer.Visible = false;
            btnAjouter.Enabled = true;
            btnAnnuler.Visible = false;
        }

        //Ecriture dans un fichier (serialisation: convertion objet vers binaire)
        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                List<CompteBancaire> listCB = new List<CompteBancaire>();
                foreach (CompteBancaire compteB in lstCompte.Items)
                {
                    listCB.Add(compteB);
                }
                Tools.ExportBin(path, listCB);
            }else
            {
                MessageBox.Show("Export Bin annulé");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "fichiers binaire(*.bin) | *.bin| tous les fichiers (*.*) | *.*";
            openFileDialog1.FileName = "";

            string path;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                List<CompteBancaire> listCB  = Tools.ImportBin(path);
                foreach (CompteBancaire compteBancaire in listCB)
                {
                    lstCompte.Items.Add(compteBancaire);
                }
            } else
            {
                MessageBox.Show("Import Bin annulé");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                List<CompteBancaire> listCB = new List<CompteBancaire>();
                foreach (CompteBancaire cb in lstCompte.Items)
                {
                    listCB.Add(cb);
                }
                Tools.ExportXML(path, listCB);
            } else
            {
                MessageBox.Show("Export XML annulé");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "fichiers xml(*.xml) | *.xml| tous les fichiers (*.*) | *.*";
            openFileDialog1.FileName = "";

            string path;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                List<CompteBancaire> listCB = Tools.ImportXML(path);
                foreach (CompteBancaire compteBancaire in listCB)
                {
                    lstCompte.Items.Add(compteBancaire);
                }
            } else
            {
                MessageBox.Show("Import XML annulé");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            string path;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                List<CompteBancaire> listCB = new List<CompteBancaire>();
                foreach (CompteBancaire cb in lstCompte.Items)
                {
                    listCB.Add(cb);
                }
                Tools.ExportJSON(path, listCB);
            }
            else
            {
                MessageBox.Show("Export JSON annulé");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "fichiers JSON(*.json) | *.json| tous les fichiers (*.*) | *.*";
            openFileDialog1.FileName = "";

            string path;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                List<CompteBancaire> listCB = Tools.importJSON(path);
                foreach (CompteBancaire compteBancaire in listCB)
                {
                    lstCompte.Items.Add(compteBancaire);
                }
            }
            else
            {
                MessageBox.Show("Import JSON annulé");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string path;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                List<CompteBancaire> listCB = new List<CompteBancaire>();
                foreach (CompteBancaire cb in lstCompte.Items)
                {
                    listCB.Add(cb);
                }
                Tools.ExportCSV(path, listCB);
            }
            else
            {
                MessageBox.Show("Export CSV annulé");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "fichiers CSV(*.csv) | *.csv| tous les fichiers (*.*) | *.*";
            openFileDialog1.FileName = "";

            string path;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                List<CompteBancaire> listCB = Tools.ImportCSV(path);
                foreach (CompteBancaire compteBancaire in listCB)
                {
                    lstCompte.Items.Add(compteBancaire);
                }
            }
            else
            {
                MessageBox.Show("Import CSV annulé");
            }
        }
    }
}
