using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CollectionAssertions
{
    [TestClass]
    public class CollectionAssertionsTests
    {
        [TestMethod]
        [TestCategory("Classe CollectionAssert")]
        public void StringCollection_Test()
        {
            List<string> collection1 = new List<string>();
            collection1.Add("sara");
            collection1.Add("raphael");
            collection1.Add("lionel");

            List<string> collection2 = new List<string>();
            collection2.Add("sara");
            collection2.Add("raphael");
            collection2.Add("lionel");

            CollectionAssert.AreEquivalent(collection1, collection2);
        }

        [TestMethod]
        [TestCategory("Classe CollectionAssert")]
        public void IntCollection_Test()
        {
            List<int> collection1 = new List<int>();
            collection1.Add(10);
            collection1.Add(20);
            collection1.Add(30);

            List<int> collection2 = new List<int>();
            collection2.Add(10);
            collection2.Add(20);
            collection2.Add(30);

            CollectionAssert.AreEquivalent(collection1, collection2);
        }

        [TestMethod]
        [TestCategory("Classe CollectionAssert")]
        public void ObjectCollection_Test()
        {
            List<Employe> collection1 = new List<Employe>();
            collection1.Add(new Employe() { Name = "dawan" });
            collection1.Add(new Employe() { Name = "jehann" });
            collection1.Add(new Employe() { Name = "paris" });

            List<Employe> collection2 = new List<Employe>();
            collection2.Add(new Employe() { Name = "dawan" });
            collection2.Add(new Employe() { Name = "jehann" });
            collection2.Add(new Employe() { Name = "paris" });

            //Verifie les ref
            CollectionAssert.AreEquivalent(collection1, collection2);

            //AreEqual: vérifie l'égalité des objets
            CollectionAssert.AreEqual(collection1, collection2);
        }

        [TestMethod]
        [TestCategory("Classe CollectionAssert")]
        public void Collection_Contains_Test()
        {
            List<Employe> collection1 = new List<Employe>();
            collection1.Add(new Employe() { Name = "dawan" });
            collection1.Add(new Employe() { Name = "jehann" });
            collection1.Add(new Employe() { Name = "paris" });

            CollectionAssert.Contains(collection1, new Employe() { Name = "dawan" });
        }

        [TestMethod]
        [TestCategory("Classe CollectionAssert")]
        public void Collection_IsSubsut_Test()
        {
            List<Employe> collection1 = new List<Employe>();
            collection1.Add(new Employe() { Name = "dawan" });
            collection1.Add(new Employe() { Name = "jehann" });
            collection1.Add(new Employe() { Name = "paris" });

            List<Employe> collection2 = new List<Employe>();
            collection2.Add(new Employe() { Name = "dawan" });
            collection2.Add(new Employe() { Name = "jehann" });

            //Collection2 contient de nouveaux objets - ce n'est un sous ensemble de collection1
            CollectionAssert.IsNotSubsetOf(collection2, collection1);

        }

        [TestMethod]
        [TestCategory("Classe CollectionAssert")]
        public void Collection_AreInstanceOF_Test()
        {
            List<Employe> collection1 = new List<Employe>();
            collection1.Add(new Employe() { Name = "dawan" });
            collection1.Add(new Employe() { Name = "jehann" });
            collection1.Add(new Employe() { Name = "paris" });

            CollectionAssert.AllItemsAreInstancesOfType(collection1, typeof(Employe));

        }

        [TestMethod]
        [TestCategory("Classe CollectionAssert")]
        public void Collection_ItemAreUnique_Test()
        {
            List<Employe> collection1 = new List<Employe>();
            collection1.Add(new Employe() { Name = "dawan" });
            collection1.Add(new Employe() { Name = "jehann" });
            collection1.Add(new Employe() { Name = "dawan" });

            CollectionAssert.AllItemsAreUnique(collection1);

        }
    }
}
