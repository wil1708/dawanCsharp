using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExerciceTDD
{
    [TestClass]
    public class TDD_Test
    {
        [TestMethod]
        [TestCategory("TDD")]
        public void Add_Test()
        {
            int x = 5;
            int y = 10;
            int attendu = 15;
            int obtenu = Calcul.Add(x, y);

            Assert.AreEqual(attendu, obtenu);
        }

        [TestMethod]
        [TestCategory("TDD")]
        public void Add_NegatifNumber_Test()
        {
            int x = -5;
            int y = -10;
            int attendu = -15;
            int obtenu = Calcul.Add(x, y);

            Assert.AreEqual(attendu, obtenu);
        }

        [TestMethod]
        [TestCategory("TDD")]
        public void Add_NegatifNumber_WithPositifNumber_Test()
        {
            int x = -5;
            int y = 10;
            int attendu = 5;
            int obtenu = Calcul.Add(x, y);

            Assert.AreEqual(attendu, obtenu);
        }

        //un password ne peut pas être null ou une chaine vide et doit contenir 8 char au minimum
        [TestMethod]
        [TestCategory("TDD")]
        public void CheckPasswordIsOK()
        {
            string pwd = "Total12!";
            User user = new User();
            bool resultat = user.CheckPassword(pwd);
            Assert.IsTrue(resultat);

        }

        [TestMethod]
        [TestCategory("TDD")]
        public void CheckPasswordEmpty_Return_false()
        {
            string pwd = "";
            User user = new User();
            bool resultat = user.CheckPassword(pwd);
            Assert.IsFalse(resultat);

        }

        [TestMethod]
        [TestCategory("TDD")]
        public void CheckPasswordShort_Return_false()
        {
            string pwd = "toto";
            User user = new User();
            bool resultat = user.CheckPassword(pwd);
            Assert.IsFalse(resultat);

        }

        [TestMethod]
        [TestCategory("TDD")]
        public void CheckPasswordNull_Return_false()
        {
            string pwd = null;
            User user = new User();
            bool resultat = user.CheckPassword(pwd);
            Assert.IsFalse(resultat);

        }

        [TestMethod]
        [TestCategory("TDD")]
        public void CheckPasswordLenght_Sup8_Return_true()
        {
            string pwd = "sdqsd54654sqdsq";
            User user = new User();
            bool resultat = user.CheckPassword(pwd);
            Assert.IsTrue(resultat);

        }
    }
}
