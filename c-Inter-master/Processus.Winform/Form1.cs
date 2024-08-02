using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processus.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("chrome");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("c:\\");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com/search?q=" + txtGoogle.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
                btnOuvrir.Visible = true;
            }
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            Process.Start(txtFile.Text);
            txtFile.Text = "";
            btnOuvrir.Visible = false;
        }
    }
}
