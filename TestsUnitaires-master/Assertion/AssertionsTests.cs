using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assertion
{
    [TestClass]
    public class AssertionsTests
    {
        //3 classes sont fournies pour faire des assertions:
        //Assert
        //CollectionAssert
        //StringAssert

        [TestMethod]
        [TestCategory("Classe Assert")]
        public void AreEqual()
        {
            double attendu = 25;
            double obtenu = Math.Pow(5, 2);
            Assert.AreEqual(attendu, obtenu, "{0} puissance {1} est 25", 5, 2);

            //AreNotEqual
        }

        [TestMethod]
        [TestCategory("Classe Assert")]
        public void AreSame()
        {
            Employe e1 = new Employe("Lionel");
            Employe e2 = new Employe("Lionel");
            Employe e3 = e1;

            Assert.AreSame(e1, e3);
            //AreNotSame
            //AreSame permet de tester les ref d'objets
        }

        [TestMethod]
        [TestCategory("Classe Assert")]
        public void ObjectEquality()
        {
            Employe e1 = new Employe("Lionel");
            Employe e2 = new Employe("Lionel");

            //Pour comparer des objets - la classe doit implémenter la méthode Equals
            Assert.AreEqual(e1, e2);
               
        }

        [TestMethod]
        [TestCategory("Classe Assert")]
        public void InstanceOf()
        {
            Technicien tech = new Technicien("tech");

            Employe e = new Employe("sara");

            Assert.IsNotInstanceOfType(e, typeof(Technicien));
        }

    }
}
