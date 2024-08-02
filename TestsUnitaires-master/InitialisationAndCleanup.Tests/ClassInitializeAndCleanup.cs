using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace InitialisationAndCleanup.Tests
{
    [TestClass]
    public class ClassInitializeAndCleanup
    {
        //Initialisation des params niveau classe

         static Rectangle rec;
        static string nom = "vide";



        //Niveau Assembly: Initialise toutes les ressources partagés toutes les classes du projet
        //Ex: Appel d'API distante



        [AssemblyInitialize] 
        public static void AssmeblyInit(TestContext testContext)
        {

            string testName = testContext.TestName;
            if (testName.Equals("Surface_Test"))
            {
                nom = "test assembly";
            }
            MessageBox.Show("Assembly Init...... ");
            
        }

        [AssemblyCleanup]
        public static void AssmeblyReset()
        {
            MessageBox.Show("Surface fin: " + nom);
            MessageBox.Show("Assembly Reset...... ");

        }

        [ClassInitialize] //La méthode Init s'execute 1 seule fois avant toutes les méthodes de test
        public static  void Init(TestContext testContext)
        {
           
            rec = new Rectangle();
            rec.Hauteur = 10;
            rec.Largeur = 20;

            MessageBox.Show("Classe Initialize....");
        }

        [ClassCleanup] //La méthode Reset s'execute après toute les méthodes de tests
        public static void Reset()
        {
            rec = null;
            MessageBox.Show("Classe Cleanup....");
        }


        [TestMethod]
        [TestCategory("Class Level: Initialisation and Cleanup")]
        public void Surface_Test()
        {
            //Arrange
            //Setup();

            MessageBox.Show("Surface debut: " + nom);

            double resultatAttendu = 200;
            

            //Act
            double resultatObtenu = rec.Surface();

            //Assert
            Assert.AreEqual(resultatAttendu, resultatObtenu);

            MessageBox.Show("Méthode Surface_Test ");
            MessageBox.Show("Surface fin: " + nom);

        }

        [TestMethod]
        [TestCategory("Class Level: Initialisation and Cleanup")]
        public void Perimetre_Test()
        {
            //Arrange
            //Setup();
           // MessageBox.Show("Perimetre: " + nom);
            double resultatAttendu = 60;

            //Act
            double resultatObtenu = rec.Perimetre();

            //Assert
            Assert.AreEqual(resultatAttendu, resultatObtenu);

            MessageBox.Show("Méthode Perimetre_Test");

        }
    }
}
