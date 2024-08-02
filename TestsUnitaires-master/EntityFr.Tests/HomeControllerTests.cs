using EntityFr.Controllers;
using EntityFr.Repository;
using EntityFr.Services;
using EntityFr.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EntityFr.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        private MockRepository mockRepo;
        private ContactService service;
        private HomeController controller;

        [TestInitialize]
        public void Init()
        {
            mockRepo = new MockRepository();
            service = new ContactService(mockRepo);
            controller = new HomeController(service);
        }

        [TestMethod]
        [TestCategory("Controller")]
        public void Index_Tests()
        {
            //Arrange
            //mockRepo = new MockRepository();
            //service = new ContactService(mockRepo);
            //controller = new HomeController(service); 

            mockRepo.contacts.Add(new Contact() { Id = 1, Nom = "Dawan", Prenom = "Jehann" });
            mockRepo.contacts.Add(new Contact() { Id = 2, Nom = "Dawan2", Prenom = "Jehann2" });
            

            //Act
            List<Contact> lst = controller.Index();

            //Assert
            Assert.AreEqual(2, lst.Count);
        }

        [TestMethod]
        [TestCategory("Controller")]
        public void Edit_Test()
        {
            //Arrange
            //mockRepo = new MockRepository();
            //service = new ContactService(mockRepo);
            //controller = new HomeController(service);

            mockRepo.contacts.Add(new Contact(){ Id = 1, Nom = "Dawan", Prenom = "Jehann" });

            //Act
            Contact c = controller.Edit(1);

            //Assert
            Assert.AreEqual("Dawan", c.Nom);
            Assert.AreEqual("Jehann", c.Prenom);
        }
    }
}
