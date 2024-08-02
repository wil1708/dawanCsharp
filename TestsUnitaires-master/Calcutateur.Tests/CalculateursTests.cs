using Calculateur.DLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calcutateur.Tests
{
    [TestClass]
    public class CalculateursTests
    {
        [TestMethod]
        [TestCategory("Calculateurs")]
        [TestProperty("Test Groupe", "Performance")]
        [Priority(1)]
        [Owner("Dawan")]
        public void Division_NumerateurPositif_DenominateurPositif_ReturnResultatPositif()
        {
            //Pattern AAA
            //Arrange: initialisation des params et des objets de la méthode à tester
            //Act: execution de la méthode à tester
            //Assert: Vérifier que le résultat obtenu correspond au résultat attendu

            //Arrange:
            int numerateur = 20;
            int denominateur = 4;
            int resultatAttendu = 5;

            //Act
            int resultatObtenu = Calculateurs.Division(numerateur, denominateur);

            //Assert
            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }

        [TestMethod]
        [TestCategory("Calculateurs")]
        [TestProperty("Test Groupe", "Performance")]
        [Priority(1)]
        [Owner("Dawan")]
        public void Division_NumerateurPositif_DenominateurNegatif_ReturnResultatNegatif()
        {
            //Arrange:
            int numerateur = 20;
            int denominateur = -4;
            int resultatAttendu = -5;

            //Act
            int resultatObtenu = Calculateurs.Division(numerateur, denominateur);

            //Assert
            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }

        [TestMethod]
        [TestCategory("Calculateurs")]
        [TestProperty("Test Groupe", "Performance")]
        [Priority(1)]
        [Owner("Dawan")]
        public void Division_NumerateurNegatif_DenominateurNegatif_ReturnResultatPositif()
        {
            //Arrange:
            int numerateur = -20;
            int denominateur = -4;
            int resultatAttendu = 5;

            //Act
            int resultatObtenu = Calculateurs.Division(numerateur, denominateur);

            //Assert
            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }

        [TestMethod]
        [TestCategory("Exo")]
        public void chaineLenght_Test()
        {
            //Arrange
            string chaine = "test";
            int resultatAttendu = 4;

            //Act
            int resultatObtenu =  Calculateurs.chaineLength(chaine);

            //Assert
            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }

        [TestMethod]
        [TestCategory("Exo")]
        public void nombreMots_Test()
        {
            //Arrange
            string chaine = "ceci est une chaine";
            int resultatAttendu = 4;

            //Act
            int resultatObtenu = Calculateurs.nombreMots(chaine);

            //Assert
            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }

        [TestMethod]
        [TestCategory("Exo")]
        public void sommeTab_Test()
        {
            //Arrange
            int[] tab = { 1, 2, 3, 4 };
            int resultatAttendu = 10;

            //Act
            int resultatObtenu = Calculateurs.sommeTab(tab);

            //Assert
            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }

        //Traiter les exceptions
        [TestMethod]
        [TestCategory("Exception")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Division_DenominateurEgaleZero_Return_DivideByZeroException()
        {
            //Arrange
            int numerateur = 10;
            int denominateur = 0;

            //Act

            Calculateurs.Division(numerateur, denominateur);

            //try
            //{
            //    Calculateurs.Division(numerateur, denominateur);
            //}
            //catch (DivideByZeroException ex)
            //{

            //    Assert.AreEqual("Tentative de division par zéro........", ex.Message);
            //    Console.WriteLine(ex.Message);
            //    throw;
            //}

        }

        //Test de la méthode privée via une méthode publique
        [TestMethod]
        [TestCategory("Test méthode privée via méthode publique")]
        public void Add_Test()
        {
            //Arrange
            int x = 10;
            int y = 15;
            int resultatAttendu = 25;

            //Act
           int resultatObtenu = Calculateurs.Add(x, y);

            //Assert
            Assert.AreEqual(resultatAttendu, resultatObtenu);
        }

        //Test de la méthode private static

        [TestMethod]
        [TestCategory("Méthode private static")]
        public void IsPositif_NombrePositif_ReturnTrue()
        {
            //Pour tester une méthode privée on utilise un type privé

            //Arrange
            PrivateType p = new PrivateType(typeof(Calculateurs));

            //Act
            bool resultatObtenu = (bool)p.InvokeStatic("IsPositif", 10);

            //Assert
            Assert.IsTrue(resultatObtenu);
        }

        [TestMethod]
        [TestCategory("Méthode private static")]
        public void IsPositif_NombreNegatif_ReturnFalse()
        {
            //Pour tester une méthode static privée on utilise un type privé

            //Arrange
            PrivateType p = new PrivateType(typeof(Calculateurs));

            //Act
            bool resultatObtenu = (bool)p.InvokeStatic("IsPositif", -5);

            //Assert
            Assert.IsFalse(resultatObtenu);
        }


        //Test méthode private non static

        [TestMethod]
        [TestCategory("Méthode private non static")]
        public void IsNegatif_NumberNegatif_ReturnTrue()
        {
            //pour tester une méthode privée non static on utilise on objet privé

            //Arrange
            PrivateObject obj = new PrivateObject(typeof(Calculateurs));

            //Act
            bool reslutatObtenu = (bool)obj.Invoke("IsNegatif", -15);

            //Assert
            Assert.IsTrue(reslutatObtenu);
        }

        [TestMethod]
        [TestCategory("Méthode private non static")]
        public void IsNegatif_NumberPositif_ReturnFalse()
        {
            //pour tester une méthode privée non static on utilise on objet privé

            //Arrange
            PrivateObject obj = new PrivateObject(typeof(Calculateurs));

            //Act
            bool reslutatObtenu = (bool)obj.Invoke("IsNegatif", 20);

            //Assert
            Assert.IsFalse(reslutatObtenu);
        }
    }
}
