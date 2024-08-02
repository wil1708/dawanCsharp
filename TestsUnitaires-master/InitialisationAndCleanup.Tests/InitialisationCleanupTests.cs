using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace InitialisationAndCleanup.Tests
{
    [TestClass]
    public class InitialisationCleanupTests
    {
        //3 niveau d'initialisation:
        //Méthode de Test - Classe - Assembly

        Rectangle rec;

        [TestInitialize] //la méthode Setup sera appelée avant l'exécution de chaque méthode de test
        public void Setup()
        {
            rec = new Rectangle();
            rec.Hauteur = 5;
            rec.Largeur = 10;

            MessageBox.Show("Méthode Setup - TestInitialize");
        }

        [TestCleanup] //Méthode Reset s'exécute après chaque méthode de Test
        public void Reset()
        {
            rec = null;
            MessageBox.Show("Méthode Reset - TestCleanup");
        }


        [TestMethod]
        [TestCategory("Initialisation and Cleanup")]
        public void Surface_Test()
        {
            //Arrange
            //Setup();

            double resultatAttendu = 50;

            //Act
            double resultatObtenu = rec.Surface();

            //Assert
            Assert.AreEqual(resultatAttendu, resultatObtenu);

            MessageBox.Show("Méthode Surface_Test ");

        }

        [TestMethod]
        [TestCategory("Initialisation and Cleanup")]
        public void Perimetre_Test()
        {
            //Arrange
            //Setup();

            double resultatAttendu = 30;

            //Act
            double resultatObtenu = rec.Perimetre();

            //Assert
            Assert.AreEqual(resultatAttendu, resultatObtenu);

            MessageBox.Show("Méthode Perimetre_Test");

        }
    }
}
