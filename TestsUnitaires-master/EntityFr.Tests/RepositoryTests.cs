using EntityFr.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EntityFr.Tests
{
    [TestClass]
    public class RepositoryTests
    {
        RepositoryContact repo = new RepositoryContact();
      
        [TestMethod]
        [TestCategory("Entity FR")]
        public void GetAll_Test()
        {
            List<Contact> resultat = repo.getAll();
            Assert.AreEqual(0, resultat.Count);
        }

        [TestMethod]
        [TestCategory("Entity FR")]
        public void Insert_Test()
        {
            //Arrange
            Contact c = new Contact() { Nom = "dawan", Prenom = "Jehann" };
            int tailleAvantInsertion = repo.getAll().Count; //0

            //Act
            repo.Insert(c);
            int tailleApresInsertion = repo.getAll().Count;

            //Assert
            Assert.AreEqual(tailleApresInsertion, tailleAvantInsertion + 1);
        }

        [TestMethod]
        [TestCategory("Entity FR")]
        public void findById_Test()
        {
            //Arrange
            int id = 1;
            
            //Act
            Contact c = repo.findById(1);

            //Assert
            Assert.IsNotNull(c);
        }

        [TestMethod]
        [TestCategory("Entity FR")]
        public void Update_Test()
        {
            //Arrange
            Contact c = repo.findById(1);
            c.Nom = "NouveauN";
            c.Prenom = "NouveauP";

            //Act
            repo.Update(c);
            Contact contactUpdated = repo.findById(1);

            //Assert
            Assert.AreEqual("NouveauN", contactUpdated.Nom);
            Assert.AreEqual("NouveauP", contactUpdated.Prenom);
        }

        [TestMethod]
        [TestCategory("Entity FR")]
        [ExpectedException(typeof(Exception))]
        public void Delete_Test()
        {
            

            //Act
            repo.Delete(1);
            Contact contact = repo.findById(1);

            
        }

    }
}
