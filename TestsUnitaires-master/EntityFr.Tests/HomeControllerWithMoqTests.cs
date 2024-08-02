using EntityFr.Controllers;
using EntityFr.Repository;
using EntityFr.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace EntityFr.Tests
{
    [TestClass]
    public class HomeControllerWithMoqTests
    {
        Mock<IRepository> mock = new Mock<IRepository>();
        ContactService service;
        HomeController controller;


        [TestMethod]
        [TestCategory("Controller with MOQ package")]
        public void Index_Test()
        {

            //Arrange
            //Paramétrer le repo virtual
            List<Contact> lst = new List<Contact>();
            lst.Add(new Contact());
            lst.Add(new Contact());

            mock.Setup(x => x.getAll()).Returns(lst);
            service = new ContactService(mock.Object);
            controller = new HomeController(service);

            //Act
            List<Contact> resultat = controller.Index();

            //Assert
            Assert.AreEqual(2, resultat.Count);
        }

        [TestMethod]
        [TestCategory("Controller with MOQ package")]
        public void Edit_Test()
        {
            //Arrange
            service = new ContactService(mock.Object);
            controller = new HomeController(service);
            Contact c = new Contact() { Id = 1, Nom = "dawan", Prenom = "jehann" };

            mock.Setup(x => x.findById(1)).Returns(c);

            //Act
            Contact contact = controller.Edit(1);

            //Assert
            Assert.AreEqual("dawan", contact.Nom);
            Assert.AreEqual("jehann", contact.Prenom);
        }
    }
}
