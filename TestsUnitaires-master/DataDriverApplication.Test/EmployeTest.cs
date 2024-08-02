using DataDrivenApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataDriverApplication.Test
{
    [TestClass]
    public class EmployeTest
    {
        public TestContext TestContext { get; set; }

        //Ajouter les 2 réferences - 1 vers le projet à tester et 1 autre vers ADO.NET (System.Data)


        //Source=Base de données
        [TestMethod]
        [DataSource("System.Data.SqlClient", 
            @"data source=WINDOWS10\SQLEXPRESS;initial catalog=mstest;integrated security=true",
            "Employe",
            DataAccessMethod.Sequential
            )]
        [TestCategory("Base de données")]
        public void DataDrivenEmploye_db_tests()
        {
            Employe emp = new Employe();
            emp.Nom = TestContext.DataRow["nom"].ToString();
            emp.Email = TestContext.DataRow["email"].ToString();

            Assert.IsNotNull(emp.Nom);
            Assert.IsNotNull(emp.Email);
        }

        //Source = fichier XML

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "c:\\test\\Employes.xml",
            "employe",
            DataAccessMethod.Sequential)]
        [TestCategory("Fichier XML")]
        public void DataDrivenEmploye_XML_tests()
        {
            Employe emp = new Employe();
            emp.Nom = TestContext.DataRow["Nom"].ToString();
            emp.Email = TestContext.DataRow["Email"].ToString();

            Assert.IsNotNull(emp.Nom);
            Assert.IsNotNull(emp.Email);
        }

        //Source = fichier CSV

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
          "c:\\test\\Employes.csv",
          "Employes.csv",
          DataAccessMethod.Sequential)]
        [TestCategory("Fichier CSV")]
        public void DataDrivenEmploye_CSV_tests()
        {
            Employe emp = new Employe();
            emp.Nom = TestContext.DataRow["Name"].ToString();
            emp.Email = TestContext.DataRow["Email"].ToString();

            Assert.IsNotNull(emp.Nom);
            Assert.IsNotNull(emp.Email);
        }
    }
}
