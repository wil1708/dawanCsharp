using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Calcutateur.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //Une classe abstraite qui contient des propriétés et des méthodes d'instances
        //qui nous fournissent des infos sur le projet à tester

        public TestContext TestContext { get; set; }



        [TestMethod]
        [TestCategory("Demo"), TestCategory("Calculateurs")]
        [TestProperty("Test Groupe", "Securité")]
        [Priority(2)]
        [Owner("Proprio")]
        public void TestMethod1()
        {
        }

        [TestMethod]
        [TestCategory("Demo")]
        [TestProperty("Test Groupe", "Securité")]
        [Priority(2)]
        [Owner("Proprio")]
        public void MyTestMethod()
        {
            Console.WriteLine("contenu de la console......");
            Debug.WriteLine("message de la classe Debug");
            MessageBox.Show("Message BOX....");
            TestContext.WriteLine(TestContext.CurrentTestOutcome.ToString());

        }
    }
}
