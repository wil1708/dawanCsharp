using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Addition_Graphique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Gère le clic sur le bouton btnAjouter
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Addition", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            /*int var1, var2, somme;
            var1  = Convert.ToInt32(textBox1.Text);
            var2 = Convert.ToInt32(textBox2.Text);
            somme = var1 + var2;
            MessageBox.Show("Somme = "+ somme);*/
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
