using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asynchrone.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            lblChar.Text = "Fichier en cours de traitement......";
            int cout = await nombreCaracteres();
            lblChar.Text = "Nombre de caractères: " + cout.ToString();

        }

        public async Task<int> nombreCaracteres()
        {
            int count = 0;
            StreamReader sr = new StreamReader("c:\\test\\fichier.txt");
            string contenu = await sr.ReadToEndAsync();
            count = contenu.Length;
            Thread.Sleep(5000);
            return count;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //Appel de la méthode synchrone
            //DownloadHtml("http://www.dawan.fr");

            //Appel de la méthode asynchrone
            //await DownloadAsync("http://www.dawan.fr");

            //Appel de la méthode sunchrone non void
            //string contenu = GetString("http://www.dawan.fr");
            //MessageBox.Show(contenu.Substring(0, 100));

            //Appel de la méthode Asynchrone non void

            lblChar.Text = "Téléchargement en cours...... ";
            var resultat = await GetStringAsync("http://www.dawan.fr");
            

            lblChar.Text = resultat.Substring(0, 20);
        }

        //Méthode synchrone
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            //Ecriture du contenu HTML dans un fichier
            using (var sr = new StreamWriter("c:\\test\\result.html"))
            {
                sr.Write(html);
            }

        }

        //Méthode asynchrone
        public async Task DownloadAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            //Ecriture du contenu HTML dans un fichier
            using (var sr = new StreamWriter("c:\\test\\result.html"))
            {
                await sr.WriteAsync(html);
            }
        }

        //Méthode synchrone non void
        public string GetString(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        //Méthode Asynchrone non void
        public async Task<string> GetStringAsync(string url)
        {
            var webClient = new WebClient();
             var result = await webClient.DownloadStringTaskAsync(url);
            Thread.Sleep(2000);
            return result;
        }
    }
}
