using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformExercice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void baseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            bdd.ShowDialog();
        }
    }
}
